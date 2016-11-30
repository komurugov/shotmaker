namespace ScreenshotMaker.BLL
{
    internal interface IModel
    {
		void LoadFile(string path);
		void ChangeTestExecution(string name);
		void ChangeOutputFolder(string path);
		void DoPassed(ModelItem selectedItem);
		void DoFailed(ModelItem selectedItem);
		void DoSkipped(ModelItem selectedItem);
		void Show(ModelItem selectedItem);
	}
}