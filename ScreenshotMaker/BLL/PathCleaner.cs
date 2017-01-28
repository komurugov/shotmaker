using System.IO;

namespace ScreenshotMaker.BLL
{
	static class PathCleaner
	{
		public static string GetPathWithoutInvalidChars(string path)
		{
			var invalidChars = Path.GetInvalidPathChars();
			foreach (char ch in invalidChars)
				path = path.Replace(ch.ToString(), "");
			return path;
		}

		public static string GetFileNameWithoutInvalidChars(string fileName)
		{
			var invalidChars = Path.GetInvalidFileNameChars();
			foreach (char ch in invalidChars)
				fileName = fileName.Replace(ch.ToString(), "");
			return fileName;
		}
	}
}
