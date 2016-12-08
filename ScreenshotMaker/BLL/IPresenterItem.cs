using System;

namespace ScreenshotMaker.BLL
{
	public interface IPresenterItem
	{
		bool Selectable { get; }
		string Text { get; }
		PresenterItemStatus Status { get; }
		PresenterItemResult Result { get; }

		Action ActionPassed { get; }
		Action ActionFailed { get; }
		Action ActionSkip { get; }
		Action ActionShow { get; }
	}
}