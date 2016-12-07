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

			var testCase = new TestCase();

			testCase.IdAndTitle = IdAndTitleFromDto(dto);
			testCase.Setups = SetupsFromDto(dto);
			testCase.Verifications = VerificationsFromDto(dto);

			return testCase;
		}

		private static List<Verification> VerificationsFromDto(rss dto)
		{
			var result = new List<Verification>();
			var verificationItems = dto.channel.item.customfields.First(n => n.customfieldname == "Manual Test Steps").customfieldvalues.steps;
			foreach (var verificationItem in verificationItems)
				result.Add(VerificationFromDto(verificationItem));
			return result;
		}

		private static Verification VerificationFromDto(rssChannelItemCustomfieldCustomfieldvaluesStep verificationItem)
		{
			var result = new Verification();
			result.Data = DataFromDto(verificationItem.data.Text);
			result.Steps = StepsFromDto(verificationItem);
			return result;
		}

		private static List<Step> StepsFromDto(rssChannelItemCustomfieldCustomfieldvaluesStep step)
		{
			var result = new List<Step>();
			foreach (var t in DivideHtmlIntoLines(step.step.Text))
				result.Add(new Step(t));
			int n = 1;
			foreach (var t in DivideHtmlIntoLines(step.result.Text))
			{
				int m;
				if (t.IndexOf('.') > 0 && int.TryParse(t.Substring(0, t.IndexOf('.')), out m))
				{
					n = m;
					if (n > 0 && n <= result.Count)
						result[n - 1].Results.Add(new StepResult(t.Substring(t.IndexOf('.') + 1)));
				}
				else
				{
					if (n > 0 && n <= result.Count)
						result[n - 1].Results.Add(new StepResult(t));
				}
			}
			return result;
		}

		private static List<Data> DataFromDto(string data)
		{
			var result = new List<Data>();
			foreach (var t in DivideHtmlIntoLines(data))
				result.Add(new Data(t));
			return result;
		}

		private static string IdAndTitleFromDto(rss dto)
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
			return new List<string > (s.Split(HtmlTags, StringSplitOptions.RemoveEmptyEntries));
		}

		public static List<Setup> SetupsFromString(string s)
		{
			var result = new List<Setup>();
			foreach (var t in DivideHtmlIntoLines(s))
				result.Add(new Setup(t));
			return result;
		}


		private static List<Setup> SetupsFromDto(rss dto)
		{
			var field = dto.channel.item.customfields.First(n => n.customfieldname == "Setup");
			string s = field.customfieldvalues.customfieldvalue;
			return SetupsFromString(s/* + @"&lt;br/&gt;"*/);
		}
	}
}