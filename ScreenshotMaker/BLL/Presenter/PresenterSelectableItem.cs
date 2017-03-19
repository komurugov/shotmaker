using System;

namespace ScreenshotMaker.BLL
{
	internal class PresenterSelectableItem : IPresenterItem
	{
		private readonly ITestCaseItem _modelItem;
		private PrL.IView _view;

		public PresenterSelectableItem(ITestCaseItem item, PrL.IView view)
		{
			_modelItem = item;
			_view = view;
		}

		public string Text
		{
			get
			{
				return _modelItem.Text;
			}
		}

		public bool Selectable
		{
			get { return true; }
		}

		public PresenterItemStatus Status
		{
			get
			{
				switch (_modelItem.Status)
				{
					case BLL.Status.None:
						return PresenterItemStatus.None;
					case BLL.Status.Done:
						return PresenterItemStatus.Done;
					case BLL.Status.Skipped:
						return PresenterItemStatus.Skipped;
					default:
						return PresenterItemStatus.None;
				}
			}
		}

		public PresenterItemResult Result
		{
			get
			{
				switch (_modelItem.Result)
				{
					case BLL.Result.Passed:
						return PresenterItemResult.Passed;
					case BLL.Result.Failed:
						return PresenterItemResult.Failed;
					case BLL.Result.Unknown:
						return PresenterItemResult.Unknown;
					default:
						return PresenterItemResult.Unknown;
				}
			}
		}

		private bool MakeScreenshot(IntPtr window, Result result)
		{			
			try
			{
				_modelItem.MakeScreenshot(window, result, _view.GetOuputFolderPath());
			}
			catch (Exception exception)
			{
				_view.ShowMessage("Can't make and save screenshot: " + exception.Message);
				return false;
			}
			_view.RefreshData();
			return true;
		}

		public Func<IntPtr, bool> ActionPassed
		{
			get { return (window) =>  MakeScreenshot(window, BLL.Result.Passed); }
		}

		public Func<bool> ActionFailed
		{
			get { return () => MakeScreenshot(new IntPtr(), BLL.Result.Failed); }
		}

		private bool Skip()
		{
			try
			{
				_modelItem.Skip(_view.GetOuputFolderPath());
				_view.RefreshData();
				return true;
			}
			catch (Exception exception)
			{
				_view.ShowMessage("Can't skip screenshot: " + exception.Message);
				return false;
			}
		}

		public Func<bool> ActionSkip
		{
			get { return () => Skip(); }
		}

		public Func<bool> ActionShow
		{
			get
			{
				if (_modelItem.HasScreenshot())
					return () => _modelItem.Show();
				else
					return null;
			}
		}
	}
}