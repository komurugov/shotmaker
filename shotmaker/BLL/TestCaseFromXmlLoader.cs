using ScreenshotMaker.DAL;
using System.IO;
using System.Linq;
using HtmlAgilityPack;

namespace ScreenshotMaker.BLL
{
	public static class TestCaseFromXmlLoader
	{
		public static TestCase Load(string filePath)
		{
			if (!File.Exists(filePath))
				throw new FileNotFoundException(string.Format("Can't find file {0}", filePath));

			string s;

			rss dto = XmlLoader.LoadFromFile(filePath);

			TestCase testCase = new TestCase();

			s = dto.channel.item.title;
			s = s.Replace("[", "");
			s = s.Replace("] ", "-");
			testCase.IdAndTitle = s;

			rssChannelItemCustomfield field = dto.channel.item.customfields.First(n => n.customfieldname == "Setup");
			s = field.customfieldvalues.customfieldvalue;
			HtmlDocument doc = new HtmlDocument();


			return null;
		}
	}
}