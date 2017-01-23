using System;
using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class TestCase : IGeneratePathAndFileNameForTestCaseItem
	{
		public string ExecutionIdAndTitle { get; set; }
		public string IdAndTitle { get; set; }

		public List<Setup> Setups { get; set; }
		public List<Verification> Verifications { get; set; }

		public void ClearSession()
		{
		}

		public PathAndFileName GeneratePathAndFileNameForTestCaseItem(TestCaseItem testCaseItem)
		{
			string pathRoot = string.Format(@"{0}\{1}\", ExecutionIdAndTitle, IdAndTitle);
			PathAndFileName partOfPathAndFileName = GeneratePartOfPathAndFileNameForTestCaseItem(testCaseItem);
			return new PathAndFileName(pathRoot + partOfPathAndFileName.Path, partOfPathAndFileName.FileName);
		}

		private PathAndFileName GeneratePartOfPathAndFileNameForTestCaseItem(TestCaseItem item)
		{
			if (item is Setup)
				return GeneratePartOfPathAndFileNameForConcreteTestCaseItem(item as Setup);
			if (item is Data)
				return GeneratePartOfPathAndFileNameForConcreteTestCaseItem(item as Data);
			if (item is StepResult)
				return GeneratePartOfPathAndFileNameForConcreteTestCaseItem(item as StepResult);
			throw new InvalidOperationException();
		}

		private PathAndFileName GeneratePartOfPathAndFileNameForConcreteTestCaseItem(Data data)
		{
			Verification verification = data.Parent as Verification;
			if (verification == null)
				throw new InvalidOperationException();
			int verificationNum = verification.Number;
			int dataNum = verification.Data.IndexOf(data);
			if (dataNum < 0)
				throw new InvalidOperationException();
			var result = new PathAndFileName();
			result.Path = string.Format(@"Verification-{0}\", verificationNum.ToString("D2"));
			result.FileName = string.Format("Data-{0}-{1}", (dataNum + 1).ToString("D2"), data.Text);
			return result;
		}

		private PathAndFileName GeneratePartOfPathAndFileNameForConcreteTestCaseItem(Setup setup)
		{
			int setupNum = Setups.IndexOf(setup);
			if (setupNum < 0)
				throw new InvalidOperationException();
			var result = new PathAndFileName();
			result.Path = @"Setup\";
			result.FileName = string.Format("{0}-{1}", (setupNum + 1).ToString("D2"), setup.Text);
			return result;
		}

		private PathAndFileName GeneratePartOfPathAndFileNameForConcreteTestCaseItem(StepResult stepResult)
		{
			Step step = stepResult.Parent as Step;
			if (step == null)
				throw new InvalidOperationException();
			int stepResultNum = step.Results.IndexOf(stepResult);
			if (stepResultNum < 0)
				throw new InvalidOperationException();
			int stepNum = step.Number;
			Verification verification = step.Parent as Verification;
			int verificationNum = verification.Number;
			var result = new PathAndFileName();
			result.Path = string.Format(@"Verification-{0}\",
				verificationNum.ToString("D2"));
			result.FileName = string.Format("Step {0}-{1}{2}",
				stepNum,
				step.Results.Count > 1 ? (stepResultNum + 1).ToString("D2") + "-" : "",
				stepResult.Text);
			return result;
		}
	}
}