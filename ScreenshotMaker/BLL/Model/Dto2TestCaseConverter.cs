using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using ScreenshotMaker.DAL;

namespace ScreenshotMaker.BLL
{
	public static class Dto2TestCaseConverter
	{
		public static TestCase ConvertDto2TestCase(rss dto)
		{
			var testCase = new TestCase();
			testCase.IdAndTitle = GetIdAndTitle(dto);
			testCase.Setups = GetSetups(dto, testCase);
			testCase.Verifications = GetVerifications(dto, testCase);
			return testCase;
		}

		private static List<Verification> GetVerifications(rss dto, TestCase testCase)
		{
			var result = new List<Verification>();

			var customfields = dto
				?.channel
				?.item
				?.customfields;
			if (customfields == null)
				return result;

			rssChannelItemCustomfield customfield;
			try
			{
				customfield = customfields.First(n => n.customfieldname == "Manual Test Steps");
			}
			catch (Exception)
			{
				return result;
			}

			var verificationItems = customfield
				?.customfieldvalues
				?.steps;
			if (verificationItems == null)
				return result;

			foreach (var verificationItem in verificationItems)
				result.Add(GetVerification(verificationItem, testCase));
			return result;
		}

		private static Verification GetVerification(rssChannelItemCustomfieldCustomfieldvaluesStep verificationItem, TestCase testCase)
		{
			if (verificationItem == null)
				return null;
			var verification = new Verification(testCase);
			verification.Number = verificationItem.index;
			verification.Data = GetData(verificationItem.data, verification);
			verification.Steps = GetSteps(verificationItem, verification);
			return verification;
		}

		private static List<Data> GetData(rssChannelItemCustomfieldCustomfieldvaluesStepData data, Verification verification)
		{
			var result = new List<Data>();
			if (data == null)
				return result;
			var lines = DivideHtmlIntoLines(data.Text);
			foreach (var line in lines)
				result.Add(new Data(line, verification));
			return result;
		}

		private static void ExtractSteps(string inputString, ref List<Step> steps, Verification verification)
		{
			int stepNumber = 0;
			string step = "";
			var linesSet = DivideHtmlIntoLines(inputString);
			foreach (var stepLine in linesSet)
			{
				int number;
				string text;
				if (TryExtractStepNumberAndText(stepLine, out number, out text))
				{
					if (stepNumber != 0)
					{
						steps.Add(new Step(step, stepNumber, verification));
						step = "";
					}
					if (number == stepNumber + 1)
						stepNumber = number;
					else
						throw new InvalidDataException(string.Format("Cant't extract Steps (inconsequental number of Step: {0} after {1})", number, stepNumber));
				}
				else
					text = stepLine;
				step += (step == "" ? "" : "\n") + text;
			}
			steps.Add(new Step(step, stepNumber, verification));
		}

		private static void ExtractResultsAndAttachToSteps(string inputString, ref List<Step> steps)
		{
			if (steps == null)
				return;
			int stepNumber = 0;
			foreach (string resultString in DivideHtmlIntoLines(inputString))
			{
				int numberFromResultString;
				string textFromResultString;
				if (TryExtractStepNumberAndText(resultString, out numberFromResultString, out textFromResultString))
					stepNumber = numberFromResultString;
				else
					textFromResultString = resultString;

				if (textFromResultString != "")
				{
					if (stepNumber > 0 && stepNumber <= steps.Count)
						steps[stepNumber - 1].Results.Add(new StepResult(textFromResultString, steps[stepNumber - 1]));
					else
						throw new InvalidDataException(string.Format("Cant't attach Result to Step (nonexisting number of Step: {0})", stepNumber));
				}
			}
		}

		private static List<Step> GetSteps(rssChannelItemCustomfieldCustomfieldvaluesStep step, Verification verification)
		{
			var steps = new List<Step>();

			string stringSteps = step
				?.step
				?.Text;
			if (stringSteps == null)
				return steps;
			ExtractSteps(stringSteps, ref steps, verification);

			string results = step
				?.result
				?.Text;
			if (results == null)
				return steps;
			ExtractResultsAndAttachToSteps(results, ref steps);
			return steps;
		}

		private static bool TryExtractStepNumberAndText(string inputString, out int stepNumber, out string remainingText)
		{
			if (inputString == null)
			{
				stepNumber = 0;
				remainingText = "";
				return false;
			}
			inputString = inputString.TrimStart();
			const string stepPrefix = "Step";
			if (inputString.IndexOf(stepPrefix) == 0)
				inputString = inputString.Remove(0, stepPrefix.Length);

			if (!TryExtractNumberAndText(inputString.TrimStart(), out stepNumber, out remainingText))
				return false;
			if (remainingText != null)
			{
				remainingText = remainingText.TrimStart();
				if (remainingText != "" && ".-:".Contains(remainingText[0]))
					remainingText = remainingText.Remove(0, 1).TrimStart();
			}
			return true;
		}

		private static bool TryExtractNumberAndText(string inputString, out int number, out string remainingText)
		{
			int firstNonDigitCharNumber = 0;
			while (firstNonDigitCharNumber < inputString.Length && Char.IsDigit(inputString[firstNonDigitCharNumber]))
				firstNonDigitCharNumber++;

			if (!int.TryParse(inputString.Substring(0, firstNonDigitCharNumber), out number))
			{
				remainingText = "";
				return false;
			}

			remainingText = inputString.Substring(firstNonDigitCharNumber);
			return true;
		}

		private static string GetIdAndTitle(rss dto)
		{
			string result = dto
				?.channel
				?.item
				?.title;
			if (result == null)
				throw new InvalidDataException("Can't extract ID and Title");
			result = result.Replace("[", "");
			return result.Replace("] ", "-");
		}

		private static readonly string[] HtmlTags =
		{
			@"<br/>",
			@"<br />",
			@"<ul>", @"</ul>", @"<li>", @"</li>", @"<ul class=""alternate"" type=""square"">", @"<ul type=""square"" class=""alternate"">",
			@"<p>", @"</p>"
		};

		private static List<string> DivideHtmlIntoLines(string inputString)
		{
			if (inputString == null)
				return new List<string>();
			return new List<string>(
				inputString
				.Split(HtmlTags, StringSplitOptions.RemoveEmptyEntries)
				.Select(n => n.IndexOf(@"\n") == 0 ? n.Remove(0, 2) : n)
				.Select(n => n.TrimStart())
				.Select(n => n.TrimEnd())
				.Where(n => n != "")
				);
		}

		private static List<Setup> GetSetups(rss dto, TestCase testCase)
		{
			var result = new List<Setup>();
			var fields = dto
				?.channel
				?.item
				?.customfields;
			if (fields == null)
				return result;
			rssChannelItemCustomfield field;
			try
			{
				field = fields.First(n => n.customfieldname == "Setup");
			}
			catch
			{
				return result;
			}
			string fieldValue = field
				?.customfieldvalues
				?.customfieldvalue;
			if (fieldValue == null)
				return result;
			foreach (var line in DivideHtmlIntoLines(fieldValue))
				result.Add(new Setup(line, testCase));
			return result;
		}
	}
}
