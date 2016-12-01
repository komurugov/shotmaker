using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class Step
	{
		public string Text { get; set; }
		public List<StepResult> Results { get; set; }
	}
}