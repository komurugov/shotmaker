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
			//testCase.Verifications = _verificationsFromDto();

			return testCase;
		}

		//private static List<Verification> _verificationsFromDto()
		//{
		//	var result = new List<Verification>
		//}

		private static string _idAndTitleFromDto(rss dto)
		{
			var s = dto.channel.item.title;
			s = s.Replace("[", "");
			return s.Replace("] ", "-");
		}

		public static List<Setup> _setupsFromString(string s)
		{

			var html = new HtmlDocument();
			html.LoadHtml(s + @"&lt;br/&gt;");
			var result = new List<Setup>();
			//			foreach (string t in lines)
			//			result.Add(new Setup(t));
			var nodes = html.DocumentNode.SelectNodes("//*");
			if (nodes == null)
				result.Add(new Setup("0" + s));
			else
				//				foreach (HtmlNode node in nodes)
				for (int i = 0; i < nodes.Count; i++)
				{
					var node = nodes[i];
					if (node.Name == "br")
					{
						result.Add(new Setup("1" + node.PreviousSibling.InnerText.Trim()));
						if (i == nodes.Count - 1)
							result.Add(new Setup("3" + node.InnerText.Trim()));
					}
					else
						result.Add(new Setup("2" + node.InnerText));
				}
			return result;
		}


		private static List<Setup> _setupsFromDto(rss dto)
		{
			var field = dto.channel.item.customfields.First(n => n.customfieldname == "Setup");
			string s = field.customfieldvalues.customfieldvalue;
//			string[] lines = s.Split(_htmlTags, StringSplitOptions.RemoveEmptyEntries);
			return _setupsFromString(s);
		}
	}
}