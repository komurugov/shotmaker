using System;

namespace ScreenshotMaker.BLL
{
	internal class PresenterSimpleItem : IPresenterItem
	{
		public PresenterSimpleItem(string text)
		{
			Text = text;
		}

		public PresenterItemResult Result
		{
			get { return PresenterItemResult.Unknown; }
		}

		public bool Selectable
		{
			get { return false; }
		}

		public PresenterItemStatus Status
		{
			get { return PresenterItemStatus.None; }
		}

		public string Text { get; set; }

		public Action ActionPassed
		{
			get { return null; }
		}

		public Action ActionFailed
		{
			get { return null; }
		}

		public Action ActionSkip
		{
			get { return null; }
		}

		public Action ActionShow
		{
			get { return null; }
		}
	}
}