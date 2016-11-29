using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shotmaker.PrL;

namespace shotmaker.BLL
{
	class Presenter : IPresenter
	{
		public 	Presenter()
		{
		}

		public void ChangeOutputFolder(string path)
		{
			throw new NotImplementedException();
		}

		public void ChangeTestExecution(string name)
		{
			throw new NotImplementedException();
		}

		public void DoFailed(PresenterItem selectedItem)
		{
			throw new NotImplementedException();
		}

		public void DoPassed(PresenterItem selectedItem)
		{
			throw new NotImplementedException();
		}

		public void DoSkipped(PresenterItem selectedItem)
		{
			throw new NotImplementedException();
		}

		public void LoadFile(string path)
		{
			throw new NotImplementedException();
		}

		public void SetView(IView view)
		{
			throw new NotImplementedException();
		}

		public void Show(PresenterItem selectedItem)
		{
			throw new NotImplementedException();
		}
	}
}
