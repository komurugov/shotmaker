using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class TestCase
	{
		private string _outputDir;
		public string ExecutionIdAndTitle { get; set; }
		public string IdAndTitle { get; set; }

		public List<Setup> Setups { get; set; }
		public List<Verification> Verifications { get; set; }

		public void ClearSession()
		{
		}

		public bool SetOutputDir(string dirName) // return true if there already is folder for current Test Case in [dirName]
		{
			_outputDir = dirName;
			ClearSession();
			return false;
		}

		public enum ItemTypes
		{
			Setup,
			Data,
			StepResult
		}

		public class ItemCoordinates
		{
			public ItemCoordinates(ItemTypes type, int firstCoordinate, int secondCoordinate = 0, int thirdCoordinate = 0)
			{
				Type = type;
				FirstCoordinate = firstCoordinate;
				SecondCoordinate = secondCoordinate;
				ThirdCoordinate = thirdCoordinate;
			}
			public ItemTypes Type { get; set; }
			public int FirstCoordinate { get; set; }
			public int SecondCoordinate { get; set; }
			public int ThirdCoordinate { get; set; }
		}

		private bool TryGetItemAndSavingPathByCoordinates(ItemCoordinates coordinates, out TestCaseItem item, out string savingPath)
		{
			item = null;
			savingPath = _outputDir + @"\"
				+ ExecutionIdAndTitle + @"\"
				+ IdAndTitle + @"\";

			int verificationNum;
			Verification verification;
			switch (coordinates.Type)
			{
				case ItemTypes.Setup:
					int setupNum = coordinates.FirstCoordinate;
					if (setupNum >= Setups.Count)
						return false;
					item = Setups[setupNum];
					savingPath += "Setup" + @"\"
						+ (setupNum + 1).ToString("D2") + "-"
						+ item.Text;
					return true;
				case ItemTypes.Data:
					verificationNum = coordinates.FirstCoordinate;
					if (verificationNum >= Verifications.Count)
						return false;
					verification = Verifications[verificationNum];
					int dataNum = coordinates.SecondCoordinate;
					if (dataNum >= verification.Data.Count)
						return false;
					item = verification.Data[dataNum];
					savingPath += "Verification-" + (verificationNum + 1).ToString("D2") + @"\"
						+ "Data-" + dataNum.ToString("D2") + "-"
						+ item.Text;
					return true;
				case ItemTypes.StepResult:
					verificationNum = coordinates.FirstCoordinate;
					if (verificationNum >= Verifications.Count)
						return false;
					verification = Verifications[verificationNum];
					int stepNum = coordinates.SecondCoordinate;
					if (stepNum >= verification.Steps.Count)
						return false;
					Step step = verification.Steps[stepNum];
					int resultNum = coordinates.ThirdCoordinate;
					if (resultNum >= step.Results.Count)
						return false;
					item = step.Results[resultNum];
					savingPath += "Verification-" + (verificationNum + 1).ToString("D2") + @"\"
						+ "Step " + (stepNum + 1).ToString() + "-"
						+ (step.Results.Count > 1 ? (resultNum + 1).ToString("D2") + "-" : "")
						+ item.Text;
					return true;
			}
			return false;
		}

		public bool MakeScreenshot(Result result, ItemCoordinates coordinates)
		{
			TestCaseItem item;
			string savingPath;
			if (!TryGetItemAndSavingPathByCoordinates(coordinates, out item, out savingPath))
				return false;
			return item.MakeScreenshot(result, savingPath);
		}

		public Status GetStatus(ItemCoordinates coordinates)
		{
			TestCaseItem item;
			string savingPath;
			if (!TryGetItemAndSavingPathByCoordinates(coordinates, out item, out savingPath))
				return Status.None;
			return item.Status;
		}

		public Result GetResult(ItemCoordinates coordinates)
		{
			TestCaseItem item;
			string savingPath;
			if (!TryGetItemAndSavingPathByCoordinates(coordinates, out item, out savingPath))
				return Result.Unknown;
			return item.Result;
		}

		public string GetText(ItemCoordinates coordinates)
		{
			TestCaseItem item;
			string savingPath;
			if (!TryGetItemAndSavingPathByCoordinates(coordinates, out item, out savingPath))
				return "";
			return item.Text;
		}

		public bool HasScreenshot(ItemCoordinates coordinates)
		{
			TestCaseItem item;
			string savingPath;
			if (!TryGetItemAndSavingPathByCoordinates(coordinates, out item, out savingPath))
				return false;
			return item.HasScreenshot();
		}

		public bool Skip(ItemCoordinates coordinates)
		{
			TestCaseItem item;
			string savingPath;
			if (!TryGetItemAndSavingPathByCoordinates(coordinates, out item, out savingPath))
				return false;
			return item.Skip();
		}

		public bool Show(ItemCoordinates coordinates)
		{
			TestCaseItem item;
			string savingPath;
			if (!TryGetItemAndSavingPathByCoordinates(coordinates, out item, out savingPath))
				return false;
			return item.Show();
		}
	}
}