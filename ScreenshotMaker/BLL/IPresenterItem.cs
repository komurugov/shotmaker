using System;

namespace ScreenshotMaker.BLL
{
	public interface IPresenterItem
	{
		bool Selectable { get; }
		string Text { get; }
		PresenterItemStatus Status { get; }
		PresenterItemResult Result { get; }

		Action ActionPass { get; }

		//bool PassedEnabled { get; }
		bool FailedEnabled { get; }
		bool SkipEnabled { get; }
		bool ShowEnabled { get; }

		//void ApplyPassed();
		void ApplyFailed();
		void ApplySkip();
		void ApplyShow();
	}
}