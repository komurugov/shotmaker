using System;

namespace shotmaker
{
    internal class ShotmakerPresenter : IPresenter
    {
        private IDomainView domainView;
        private IModel model;

        public ShotmakerPresenter(IDomainView domainView)
        {
            this.domainView = domainView;
        }

        public void DoPass(IModelDTO selectedItem)
        {
            
        }

        public void DoPass(int selectedItem)
        {
            IModel item = model.FindItem(selectedItem);            
            item.DoPass();
            domainView.UpdateElement(item);
        }

        public void LoadFile(string v)
        {
            model = new ConcreteModel();
            IModelDTO dto = model.ToDTO();
            domainView.Reload(dto);
        }
    }
}