using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenshotMaker.PrL;

namespace ScreenshotMaker.BLL
{
	class Presenter : IPresenter
	{
		public 	Presenter()
		{
		}

		private IView _view;

		private Tree<IPresenterItem> _items;

		public Tree<IPresenterItem> GetTree()
		{
			return _items;
		}

		public void ChangeOutputFolder(string path)
		{
			throw new NotImplementedException();
		}

		public void ChangeTestExecution(string name)
		{
			throw new NotImplementedException();
		}

		public void DoFailed(IPresenterItem selectedItem)
		{
			var item = selectedItem as PresenterSelectableItem;
			item.DoFail();
		}

		public void DoPassed(PresenterItemHash selectedItemHash)
		{
			throw new NotImplementedException();
		}

		public void DoSkipped(PresenterItemHash selectedItemHash)
		{
			throw new NotImplementedException();
		}

		public void LoadFile(string path)
		{
			throw new NotImplementedException();
		}

		public void SetView(IView view)
		{
			_view = view;
		}

		public void Show(PresenterItemHash selectedItemHash)
		{
			throw new NotImplementedException();
		}

		public void LoadFile()
		{
			throw new NotImplementedException();
		}

		public void ChangeTestExecution()
		{
			throw new NotImplementedException();
		}

		public void ChangeOutputFolder()
		{
			throw new NotImplementedException();
		}
	}
}
