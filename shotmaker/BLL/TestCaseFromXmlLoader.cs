using ScreenshotMaker.DAL;

namespace ScreenshotMaker.BLL
{
	public static class TestCaseFromXmlLoader
	{
		public static TestCase Load(string filePath)
		{
			string s;

			rss dto = XmlLoader.LoadFromFile(filePath);

			TestCase testCase = new TestCase();

			s = dto.channel.item.title;
			//s.Replace('[', '');
			//s.Replace()

			return null;
		}
	}
}