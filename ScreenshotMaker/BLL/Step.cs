using System;
using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class Step : IGeneratePathAndFileNameForTestCaseItem
	{
		public Step(string text, int number, IGeneratePathAndFileNameForTestCaseItem parent)
		{
			Text = text;
			Results = new List<StepResult>();
			Number = number;
			Parent = parent;
		}
		public int Number { get; set; }
		public string Text { get; set; }
		public List<StepResult> Results { get; set; }
		public IGeneratePathAndFileNameForTestCaseItem Parent { get; }

		public PathAndFileName GeneratePathAndFileNameForTestCaseItem(TestCaseItem testCaseItem)
		{
			return Parent.GeneratePathAndFileNameForTestCaseItem(testCaseItem);
		}
	}
}