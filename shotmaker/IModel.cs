namespace shotmaker
{
    internal interface IModel
    {
        IModel FindItem(int selectedItem);
        IModelDTO ToDTO();
        void DoPass();
    }
}