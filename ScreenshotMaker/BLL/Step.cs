using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class Step
	{
		public Step(string text)
		{
			Text = text;
			Results = new List<StepResult>();
		}

		public string Text { get; set; }
		public List<StepResult> Results { get; set; }
	}
}