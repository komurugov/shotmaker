namespace ScreenshotMaker.BLL
{
	public static class Logger
	{
		public enum Levels
		{
			Info,
			Warning,
			Error,
			FatalError
		}

		public static void OutputToLog(Levels level, string text)
		{
		}
	}
}