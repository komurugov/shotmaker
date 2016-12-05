using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HtmlAgilityPack;
using ScreenshotMaker.DAL;

namespace ScreenshotMaker.BLL
{
	public static class TestCaseFromXmlLoader
	{
		private static readonly string[] _htmlTags =
		{
			@"<br/>",
			@"<p>", @"</p>"
		};

		public static TestCase Load(string filePath)
		{
			if (!File.Exists(filePath))
				throw new FileNotFoundException(string.Format("Can't find file {0}", filePath));

			var dto = XmlLoader.LoadFromFile(filePath);

			var testCase = new TestCase();

			testCase.IdAndTitle = _idAndTitleFromDto(dto);
			testCase.Setups = _setupsFromDto(dto);
			testCase.Verifications = _verificationsFromDto(dto);

			return testCase;
		}

		private static List<Verification> _verificationsFromDto(rss dto)
		{
			var result = new List<Verification>();
			var verificationItems = dto.channel.item.customfields.First(n => n.customfieldname == "Manual Test Steps").customfieldvalues.steps;
			foreach (var verificationItem in verificationItems)
				result.Add(_verificationFromStep(verificationItem));
			return result;
		}

		private static Verification _verificationFromStep(rssChannelItemCustomfieldCustomfieldvaluesStep verificationItem)
		{
			var result = new Verification();
			result.Data = _dataFromDto(verificationItem.data);
			return result;
		}

		private static List<Data> _dataFromDto(rssChannelItemCustomfieldCustomfieldvaluesStepData data)
		{
			var result = new List<Data>();
			foreach (var t in _divideStringIntoLines(data.ToString()))
				result.Add(new Data(t));
			return result;
		}

		private static string _idAndTitleFromDto(rss dto)
		{
			var s = dto.channel.item.title;
			s = s.Replace("[", "");
			return s.Replace("] ", "-");
		}

		private static List<string> _divideStringIntoLines(string s)
		{
			var html = new HtmlDocument();
			html.LoadHtml(s + @"<br/>");
			var result = new List<string>();
			//			foreach (string t in lines)
			//			result.Add(new Setup(t));
			var nodes = html.DocumentNode.SelectNodes("//*");
			if (nodes == null)
				result.Add("0" + s);
			else
				//				foreach (HtmlNode node in nodes)
				for (int i = 0; i < nodes.Count; i++)
				{
					var node = nodes[i];
					if (node.Name == "br")
					{
						result.Add("1" + node.PreviousSibling.InnerText.Trim());
						if (i == nodes.Count - 1)
							result.Add("3" + node.InnerText.Trim());
					}
					else
						result.Add("2" + node.InnerText);
				}
			return result;
		}

		public static List<Setup> _setupsFromString(string s)
		{
			var result = new List<Setup>();
			foreach (var t in _divideStringIntoLines(s))
				result.Add(new Setup(t));
			return result;
		}


		private static List<Setup> _setupsFromDto(rss dto)
		{
			var field = dto.channel.item.customfields.First(n => n.customfieldname == "Setup");
			string s = field.customfieldvalues.customfieldvalue;
//			string[] lines = s.Split(_htmlTags, StringSplitOptions.RemoveEmptyEntries);
			return _setupsFromString(s/* + @"&lt;br/&gt;"*/);
		}
	}
}