namespace shotmaker
{
    internal interface IDomainView
    {
        void UpdateElement(string item);
        void Reload(IModelDTO dto);
    }
}