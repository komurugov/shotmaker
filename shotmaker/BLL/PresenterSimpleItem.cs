namespace ScreenshotMaker.BLL
{
	internal class PresenterSimpleItem : IPresenterItem
	{
		private PresenterSimpleItem(string text)
		{
			Text = text;
		}

		public bool FailedEnabled
		{
			get { return false; }
		}

		public bool PassedEnabled
		{
			get { return false; }
		}

		public PresenterItemResult Result
		{
			get { return PresenterItemResult.Unknown; }
		}

		public bool Selectable
		{
			get { return false; }
		}

		public bool ShowEnabled
		{
			get { return false; }
		}

		public bool SkipEnabled
		{
			get { return false; }
		}

		public PresenterItemStatus Status
		{
			get { return PresenterItemStatus.None; }
		}

		public string Text { get; set; }

		public void ApplyFailed()
		{
		}

		public void ApplyPassed()
		{
		}

		public void ApplySkip()
		{
		}

		public void ApplyShow()
		{
		}
	}
}