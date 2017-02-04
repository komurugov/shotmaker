using System;
using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class Step : IGenerateFileInfoForTestCaseItem
	{
		public Step(string text, int number, IGenerateFileInfoForTestCaseItem parent)
		{
			Text = text;
			Results = new List<StepResult>();
			Number = number;
			Parent = parent;
		}
		public int Number { get; set; }
		public string Text { get; set; }
		public List<StepResult> Results { get; set; }
		public IGenerateFileInfoForTestCaseItem Parent { get; }

		public ScreenshotFileInfoDto GenerateFileInfoForTestCaseItem(TestCaseItemInfoDto itemDto)
		{
			return Parent.GenerateFileInfoForTestCaseItem(itemDto);
		}
	}
}