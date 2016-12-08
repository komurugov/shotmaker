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
			foreach (var t in DivideHtmlIntoLines(step.step.Text))
				result.Add(new Step(t));
			int currentStepNumber = 0;
			foreach (string t in DivideHtmlIntoLines(step.result.Text))
			{
				int number;
				string extractedText;
				string resultText;
				if (TryExtractStepNumber(t, out number, out extractedText))
				{
					currentStepNumber = number;
					resultText = extractedText;
				}
				else
					resultText = t;

				if (currentStepNumber > 0 && currentStepNumber <= result.Count)
					result[currentStepNumber - 1].Results.Add(new StepResult(resultText));
				else
					throw new InvalidDataException("Nonexisting number of Step");
			}
			return result;
		}

		private static bool TryExtractStepNumber(string t, out int stepNumber, out string extractedText)
		{
			extractedText = t;
			const string prefix = "Step ";
			if (extractedText.IndexOf(prefix) == 0)
				extractedText = extractedText.Remove(0, prefix.Length);
			string r;
			if (!TryExtractNumberFromBegin(extractedText.TrimStart(), out stepNumber, out r))
				return false;
			r = r.TrimStart();
			if (r != "" && ".-:".Contains(r[0]))
				r = r.Remove(0, 1);
			r = r.TrimStart();
			extractedText = r;
			return true;
		}

		private static bool TryExtractNumberFromBegin(string s, out int m, out string r)
		{
			r = s;
			int n = 0;
			while (n < s.Length && Char.IsDigit(s[n]))
				n++;
			if (!int.TryParse(s.Substring(0, n), out m))
				return false;
			r = s.Substring(n);
			return true;
		}

		private static List<Data> GetData(string data)
		{
			var result = new List<Data>();
			foreach (var t in DivideHtmlIntoLines(data))
				result.Add(new Data(t));
			return result;
		}

		private static string GetIdAndTitle(rss dto)
		{
			var s = dto.channel.item.title;
			s = s.Replace("[", "");
			return s.Replace("] ", "-");
		}

		private static readonly string[] HtmlTags =
		{
			@"<br/>",
			@"<br />",
			@"<ul>", @"</ul>", @"<li>", @"</li>", @"<ul class=""alternate"" type=""square"">",
			@"<p>", @"</p>"
		};

		private static List<string> DivideHtmlIntoLines(string s)
		{
			return new List<string> (s.Split(HtmlTags, StringSplitOptions.RemoveEmptyEntries).Select(n => (n.IndexOf(@"\n") == 0 ? n.Remove(0, 2) : n).TrimStart()));
		}

		private static List<Setup> GetSetups(rss dto)
		{
			var field = dto.channel.item.customfields.First(n => n.customfieldname == "Setup");
			string s = field.customfieldvalues.customfieldvalue;
			var result = new List<Setup>();
			foreach (var t in DivideHtmlIntoLines(s))
				result.Add(new Setup(t));
			return result;
		}
	}
}