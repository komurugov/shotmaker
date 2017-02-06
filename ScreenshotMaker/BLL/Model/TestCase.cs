using System;
using System.Collections.Generic;
using System.IO;

namespace ScreenshotMaker.BLL
{
	public class TestCase : IGenerateFileInfoForTestCaseItem
	{
		public string ExecutionIdAndTitle { get; set; }
		public string IdAndTitle { get; set; }

		public bool TargetFolderExists(string rootFolder)
		{
			return ScreenshotMaker.FolderExists(GetTargetFolderPath(rootFolder));
		}

		public List<Setup> Setups { get; set; }
		public List<Verification> Verifications { get; set; }

		public void ClearSession()
		{
		}

		private void ThrowExceptionIfPathPartIsEmpty(string pathPart, string pathPartName)
		{
			if (pathPart == null || pathPart == "")
				throw new InvalidOperationException("Can't generate a path with an empty name of the " + pathPartName);
		}

		private string GetTargetFolderPath(string rootFolder)
		{
			ThrowExceptionIfPathPartIsEmpty(rootFolder, "root folder");
			ThrowExceptionIfPathPartIsEmpty(ExecutionIdAndTitle, "Test Execution Id and Title");
			ThrowExceptionIfPathPartIsEmpty(IdAndTitle, "Test Case Id and Title");
			string result = Path.Combine(
				PathCleaner.GetPathWithoutInvalidChars(rootFolder),
				PathCleaner.GetPathWithoutInvalidChars(ExecutionIdAndTitle),
				PathCleaner.GetPathWithoutInvalidChars(IdAndTitle));
			return result;
		}

		public ScreenshotFileInfoDto GenerateFileInfoForTestCaseItem(TestCaseItemInfoDto itemInfoDto)
		{
			string targetFolder = GetTargetFolderPath(itemInfoDto.RootFolder);
			ScreenshotFileInfoDto screenshotFileInfoDto = GenerateFileInfo(itemInfoDto.Item);
			screenshotFileInfoDto.Path = Path.Combine(
				targetFolder,
				PathCleaner.GetPathWithoutInvalidChars(screenshotFileInfoDto.Path));

			screenshotFileInfoDto.TransformFileNames(
				s =>
				{
					string result = PathCleaner.GetFileNameWithoutInvalidChars(s);
					int maxFileNameLength = 100;
					if (result.Length > maxFileNameLength)
						result = result.Substring(0, maxFileNameLength);
					result += "." + itemInfoDto.ImageFormat.ToString().ToLower();
					return result;
				}
				);

			return screenshotFileInfoDto;
		}

		private ScreenshotFileInfoDto GenerateFileInfo(TestCaseItem item)
		{
			if (item is Setup)
				return GenerateFileInfo(item as Setup);
			if (item is Data)
				return GenerateFileInfo(item as Data);
			if (item is StepResult)
				return GenerateFileInfo(item as StepResult);
			throw new InvalidOperationException();
		}

		private ScreenshotFileInfoDto GenerateFileInfo(Data data)
		{
			Verification verification = data.Parent as Verification;
			if (verification == null)
				throw new InvalidOperationException();
			int verificationNum = verification.Number;
			int dataNum = verification.Data.IndexOf(data);
			if (dataNum < 0)
				throw new InvalidOperationException();
			var dto = new ScreenshotFileInfoDto(
				string.Format(@"Verification-{0}\", verificationNum.ToString("D2")),
				string.Format("Data-{0}-{1}", (dataNum + 1).ToString("D2"), data.Text));
			return dto;
		}

		private ScreenshotFileInfoDto GenerateFileInfo(Setup setup)
		{
			int setupNum = Setups.IndexOf(setup);
			if (setupNum < 0)
				throw new InvalidOperationException();
			var dto = new ScreenshotFileInfoDto(
				@"Setup\",
				string.Format("{0}-{1}", (setupNum + 1).ToString("D2"), setup.Text));
			return dto;
		}

		private ScreenshotFileInfoDto GenerateFileInfo(StepResult stepResult)
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
			var dto = new ScreenshotFileInfoDto(
				string.Format(@"Verification-{0}\", verificationNum.ToString("D2")),
				null);

			foreach (Result possiblyResult in Enum.GetValues(typeof(Result)))
			{
				string postfix;
				switch (possiblyResult)
				{
					case Result.Failed:
						postfix = "Failed";
						break;
					case Result.Passed:
						postfix = "Passed";
						break;
					default:
						postfix = "";
						break;
				}
				string possiblyFileName = string.Format(
					"Step {0}-{1}{2}{3}",
					stepNum,
					step.Results.Count > 1 ? (stepResultNum + 1).ToString("D2") + "-" : "",
					stepResult.Text,
					postfix == "" ? "" : "-" + postfix);
				if (possiblyResult == stepResult.Result)
					dto.FileName = possiblyFileName;
				else
					dto.AddPossiblyFileName(possiblyFileName);
			}

			return dto;
		}
	}
}