using System;
using shotmaker.PrL;

namespace shotmaker
{
    public interface IPresenter
    {
	    void SetView(IView view);
        void LoadFile(string path);
	    void ChangeTestExecution(string name);
	    void ChangeOutputFolder(string path);
        void DoPassed(PresenterItem selectedItem);
	    void DoFailed(PresenterItem selectedItem);
	    void DoSkipped(PresenterItem selectedItem);
	    void Show(PresenterItem selectedItem);
    }
}