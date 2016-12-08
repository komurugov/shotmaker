using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ScreenshotMaker.DAL;

namespace ScreenshotMaker.BLL
{
	public static class TestCaseFromXmlLoader
	{
		public static TestCase Load(string filePath)
		{
			if (!File.Exists(filePath))
				throw new FileNotFoundException(string.Format("Can't find file {0}", filePath));

			var dto = XmlLoader.LoadFromFile(filePath);

			var testCase = new TestCase
			{
				IdAndTitle = GetIdAndTitle(dto),
				Setups = GetSetups(dto),
				Verifications = GetVerifications(dto)
			};

			return testCase;
		}

		private static List<Verification> GetVerifications(rss dto)
		{
			var result = new List<Verification>();
			
			var verificationItems = dto
				.channel
				.item
				.customfields
				.First(n => n.customfieldname == "Manual Test Steps")
				.customfieldvalues
				.steps;

			foreach (var verificationItem in verificationItems)
				result.Add(GetVerification(verificationItem));
			return result;
		}

		private static Verification GetVerification(rssChannelItemCustomfieldCustomfieldvaluesStep verificationItem)
		{
			var result = new Verification();
			result.Data = GetData(verificationItem.data.Text);
			result.Steps = GetSteps(verificationItem);
			return result;
		}

		private static List<Step> GetSteps(rssChannelItemCustomfieldCustomfieldvaluesStep step)
		{
			var result = new List<Step>();
			foreach (var stepString in DivideHtmlIntoLines(step.step.Text))
				result.Add(new Step(stepString));

			int stepNumber = 0;
			foreach (string resultString in DivideHtmlIntoLines(step.result.Text))
			{
				int numberFromResultString;
				string textFromResultString;
				if (TryExtractStepNumberAndText(resultString, out numberFromResultString, out textFromResultString))
					stepNumber = numberFromResultString;
				else
					textFromResultString = resultString;

				if (stepNumber > 0 && stepNumber <= result.Count)
					result[stepNumber - 1].Results.Add(new StepResult(textFromResultString));
				else
					throw new InvalidDataException("Nonexisting number of Step");
			}
			return result;
		}

		private static bool TryExtractStepNumberAndText(string inputString, out int stepNumber, out string remainingText)
		{
			inputString = inputString.TrimStart();
			const string stepPrefix = "Step";
			if (inputString.IndexOf(stepPrefix) == 0)
				inputString = inputString.Remove(0, stepPrefix.Length);

			if (!TryExtractNumberAndText(inputString.TrimStart(), out stepNumber, out remainingText))
				return false;

			remainingText = remainingText.TrimStart();
			if (remainingText != "" && ".-:".Contains(remainingText[0]))
				remainingText = remainingText.Remove(0, 1).TrimStart();
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

		private static List<Data> GetData(string data)
		{
			var result = new List<Data>();
			foreach (var line in DivideHtmlIntoLines(data))
				result.Add(new Data(line));
			return result;
		}

		private static string GetIdAndTitle(rss dto)
		{
			string result = dto.channel.item.title;
			result = result.Replace("[", "");
			return result.Replace("] ", "-");
		}

		private static readonly string[] HtmlTags =
		{
			@"<br/>",
			@"<br />",
			@"<ul>", @"</ul>", @"<li>", @"</li>", @"<ul class=""alternate"" type=""square"">",
			@"<p>", @"</p>"
		};

		private static List<string> DivideHtmlIntoLines(string inputString)
		{
			return new List<string> (
				inputString.Split(HtmlTags, StringSplitOptions.RemoveEmptyEntries).
				Select(n => (n.IndexOf(@"\n") == 0 ? n.Remove(0, 2) : n).TrimStart())
				);
		}

		private static List<Setup> GetSetups(rss dto)
		{
			var field = dto.channel.item.customfields.First(n => n.customfieldname == "Setup");
			string fieldValue = field.customfieldvalues.customfieldvalue;
			var result = new List<Setup>();
			foreach (var line in DivideHtmlIntoLines(fieldValue))
				result.Add(new Setup(line));
			return result;
		}
	}
}