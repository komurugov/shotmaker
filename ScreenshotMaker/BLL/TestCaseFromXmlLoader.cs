using System.IO;
using ScreenshotMaker.DAL;

namespace ScreenshotMaker.BLL
{
	public static class TestCaseFromXmlLoader
	{
		public static TestCase Load(string filePath)
		{
			var dto = XmlLoader.LoadFromFile(filePath);
			var testCase = Dto2TestCaseConverter.ConvertDto2TestCase(dto);
			return testCase;
		}
	}
}