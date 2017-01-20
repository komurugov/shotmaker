using System;
using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class Step : IGeneratePathAndFileNameForTestCaseItem
	{
		public Step(string text, int number)
		{
			Text = text;
			Results = new List<StepResult>();
			Number = number;
		}
		public int Number { get; set; }
		public string Text { get; set; }
		public List<StepResult> Results { get; set; }
		public IGeneratePathAndFileNameForTestCaseItem Parent { get; }

		public void GeneratePathAndFileNameForTestCaseItem(TestCaseItem testCaseItem, out string path, out string fileName)
		{
			Parent.GeneratePathAndFileNameForTestCaseItem(testCaseItem, out path, out fileName);
		}
	}
}