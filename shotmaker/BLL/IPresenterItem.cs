using System.Drawing;

namespace ScreenshotMaker.BLL
{
	public interface IPresenterItem
	{
		bool IsSelectable();
		string GetText();
		Color GetColor();
		bool HasUnderline();
		bool EnablePass();
		bool EnableFail();
		bool EnableSkip();
		bool EnableShow();

		void DoPass();
		void DoFail();
		void DoSkip();
		void DoShow();
	}
}