using System;
using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class TestCase : IGeneratePathAndFileNameForTestCaseItem
	{
		private string _outputDir;
		public string ExecutionIdAndTitle { get; set; }
		public string IdAndTitle { get; set; }

		public List<Setup> Setups { get; set; }
		public List<Verification> Verifications { get; set; }

		public void ClearSession()
		{
		}

		public void GeneratePathAndFileNameForTestCaseItem(TestCaseItem testCaseItem, out string path, out string fileName)
		{
			path = _outputDir + @"\" +
				ExecutionIdAndTitle + @"\" +
				IdAndTitle + @"\";

			var setup = testCaseItem as Setup;
			if (setup != null)
			{
				path += @"Setup\";
				int setupNum = Setups.IndexOf(setup);
				if (setupNum < 0)
					throw new InvalidOperationException();
				fileName = (setupNum + 1).ToString("D2") + "-" + setup.Text;
				return;
			}

			var data = testCaseItem as Data;
			if (data != null)
			{
				Verification verification = data.Parent as Verification;
				int verificationNum = Verifications.IndexOf(verification);
				int dataNum = verification.Data.IndexOf(data);
				if (verificationNum < 0 || dataNum < 0)
					throw new InvalidOperationException();
				path += "Verification-" + (verificationNum + 1).ToString("D2") + @"\";
				fileName = "Data-" + (dataNum + 1).ToString("D2") + "-" + data.Text;
				return;
			}

			var stepResult = testCaseItem as StepResult;
			if (stepResult != null)
			{
				Step step = stepResult.Parent as Step;
				int stepResultNum = step.Results.IndexOf(stepResult);
				int stepNum = step.Number;
				Verification verification = step.Parent as Verification;
				int verificationNum = Verifications.IndexOf(verification);
				if (verificationNum < 0 || stepResultNum < 0)
					throw new InvalidOperationException();
				path += "Verification-" + (verificationNum + 1).ToString("D2") + @"\";
				fileName = "Step " + (stepNum + 1).ToString() + "-" + 
					(step.Results.Count > 1   ?   (stepResultNum + 1).ToString("D2") + "-"   :   "") + 
					stepResult.Text;
				return;
			}

			throw new InvalidOperationException();
		}

		public bool SetOutputDir(string dirName) // return true if there already is folder for current Test Case in [dirName]
		{
			_outputDir = dirName;
			ClearSession();
			return false;
		}
	}
}