using System.IO;
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
			var testCase = Dto2TestCaseConverter.ConvertDto2TestCase(dto);
			return testCase;
		}
	}
}