using System;

namespace ScreenshotMaker.BLL
{
	internal class PresenterSelectableItem : IPresenterItem
	{
		private readonly ITestCaseItem _modelItem;

		private PresenterSelectableItem(ITestCaseItem item)
		{
			_modelItem = item;
		}

		public string Text
		{
			get { return _modelItem.Text; }
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
						return PresenterItemStatus.Done;
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

		public Action ActionPassed
		{
			get { return () =>  _modelItem.MakeScreenshot(BLL.Result.Passed); }
		}

		public Action ActionFailed
		{
			get { return () => _modelItem.MakeScreenshot(BLL.Result.Failed); }
		}

		public Action ActionSkip
		{
			get { return () => _modelItem.Skip(); }
		}

		public Action ActionShow
		{
			get
			{
				//return _modelItem.HasScreenshot() 
				//	? (() =>  _modelItem.Show()) 
				//	: null;
				if (_modelItem.HasScreenshot())
					return () => _modelItem.Show();
				else
					return null;
			}
		}
	}
}