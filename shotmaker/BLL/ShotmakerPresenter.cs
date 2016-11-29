using System;

namespace shotmaker
{
    internal class ShotmakerPresenter : IPresenter
    {
        private IDomainView domainView;
        //private IModel model;

        public ShotmakerPresenter(IDomainView domainView)
        {
            this.domainView = domainView;
        }

		public void ChangeOutputFolder(string path)
		{
			throw new NotImplementedException();
		}

		public void ChangeTestExecution(string name)
		{
			throw new NotImplementedException();
		}

		public void DoFailed(ushort selectedItem)
		{
			throw new NotImplementedException();
		}

		public void DoPass(IModelDTO selectedItem)
        {
            
        }

		public void DoPassed(ushort selectedItem)
		{
			throw new NotImplementedException();
		}

		public void DoPassed(int selectedItem)
        {
            //IModel item = model.FindItem(selectedItem);            
            //item.DoPass();
            //domainView.UpdateElement(item);
        }

		public void DoSkipped(ushort selectedItem)
		{
			throw new NotImplementedException();
		}

		public void LoadFile(string v)
        {
            //model = new ConcreteModel();
            //IModelDTO dto = model.ToDTO();
            //domainView.Reload(dto);
        }

		public void Show(ushort selectedItem)
		{
			throw new NotImplementedException();
		}
	}
}