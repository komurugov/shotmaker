using System;
using ScreenshotMaker.PrL;

namespace ScreenshotMaker.BLL
{
	internal class Presenter : IPresenter
	{
		public IView View { private get; set; }

		public Tree<IPresenterItem> Items { get; }

		public void ChangeTestExecution()
		{
			throw new NotImplementedException();
		}

		public void ChangeOutputFolder()
		{
			throw new NotImplementedException();
		}

		public void OpenFile()
		{
			throw new NotImplementedException();
		}

		public void LoadFile()
		{
			throw new NotImplementedException();
		}
	}
}