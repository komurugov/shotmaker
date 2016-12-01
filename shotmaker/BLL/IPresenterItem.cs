namespace ScreenshotMaker.BLL
{
	public enum PresenterItemStatus
	{
		None,
		Done,
		Skipped
	}

	public enum PresenterItemResult
	{
		Unknown,
		Passed,
		Failed
	}

	public interface IPresenterItem
	{
		bool Selectable { get; }
		string Text { get; }
		PresenterItemStatus Status { get; }
		PresenterItemResult Result { get; }
		bool PassedEnabled { get; }
		bool FailedEnabled { get; }
		bool SkipEnabled { get; }
		bool ShowEnabled { get; }

		void ApplyPassed();
		void ApplyFailed();
		void ApplySkip();
		void ApplyShow();
	}
}