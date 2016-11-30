using System;
using ScreenshotMaker.PrL;

namespace ScreenshotMaker.BLL
{
	public interface IPresenter
	{
		void SetView(IView view);
		void LoadFile();
		void ChangeTestExecution();
		void ChangeOutputFolder();
		//   void DoPassed(PresenterItemHash selectedItemHash);
		//void DoFailed(PresenterItemHash selectedItemHash);
		//void DoSkipped(PresenterItemHash selectedItemHash);
		//void Show(PresenterItemHash selectedItemHash);

		Tree<IPresenterItem> GetTree();
	}
}