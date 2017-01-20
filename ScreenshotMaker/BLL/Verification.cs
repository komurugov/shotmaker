using System;
using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class Verification : IGeneratePathAndFileNameForTestCaseItem
	{
		public Verification(TestCase testCase)
		{
			Parent = testCase;
		}

		public int Number { get; set; }
		public List<Data> Data { get; set; }
		public List<Step> Steps { get; set; }
		public IGeneratePathAndFileNameForTestCaseItem Parent { get; }

		public void GeneratePathAndFileNameForTestCaseItem(TestCaseItem testCaseItem, out string path, out string fileName)
		{
			Parent.GeneratePathAndFileNameForTestCaseItem(testCaseItem, out path, out fileName);
		}
	}
}