namespace shotmaker
{
    internal interface IPresenter
    {
        void LoadFile(string v);
        void DoPass(IModelDTO selectedItem);
    }
}