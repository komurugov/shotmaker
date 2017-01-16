using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class Step
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
	}
}