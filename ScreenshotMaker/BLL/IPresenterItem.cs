using System;

namespace ScreenshotMaker.BLL
{
	public interface IPresenterItem
	{
		bool Selectable { get; }
		string Text { get; }
		PresenterItemStatus Status { get; }
		PresenterItemResult Result { get; }

		Func<bool> ActionPassed { get; }
		Func<bool> ActionFailed { get; }
		Func<bool> ActionSkip { get; }
		Func<bool> ActionShow { get; }
	}
}