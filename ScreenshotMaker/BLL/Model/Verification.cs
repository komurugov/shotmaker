using System;
using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class Verification : IGenerateFileInfoForTestCaseItem
	{
		public Verification(TestCase testCase)
		{
			Parent = testCase;
		}

		public int Number { get; set; }
		public List<Data> Data { get; set; }
		public List<Step> Steps { get; set; }
		public IGenerateFileInfoForTestCaseItem Parent { get; }

		public ScreenshotFileInfoDto GenerateFileInfoForTestCaseItem(TestCaseItemInfoDto itemDto)
		{
			return Parent.GenerateFileInfoForTestCaseItem(itemDto);
		}
	}
}