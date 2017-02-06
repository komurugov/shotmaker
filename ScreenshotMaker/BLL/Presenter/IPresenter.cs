using ScreenshotMaker.PrL;

namespace ScreenshotMaker.BLL
{
	public interface IPresenter
	{
		IView View { set; }

		Tree<IPresenterItem> Items { get; }
		bool OpenFile();
		void ChangeTestExecution();
		void ChangeOutputFolder();
	}
}