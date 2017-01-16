﻿using System;

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
				string prefix = "";
				switch (_modelItem.Status)
				{
					case BLL.Status.Done:
						switch (_modelItem.Result)
						{
							case BLL.Result.Failed:
								prefix = "FAILED: ";
								break;
							case BLL.Result.Passed:
								prefix = "PASSED: ";
								break;
						}
						break;
					case BLL.Status.Skipped:
						prefix = "SKIPPED: ";
						break;
				}
				return prefix + _modelItem.Text;
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

		private void MakeScreenshot(Result result)
		{
			_view.PrepareBeforeScreenshot();
			_modelItem.MakeScreenshot(result);
			_view.RestoreAfterScreenshot();
			_view.RefreshData();
		}

		public Action ActionPassed
		{
			get { return () =>  MakeScreenshot(BLL.Result.Passed); }
		}

		public Action ActionFailed
		{
			get { return () => MakeScreenshot(BLL.Result.Failed); }
		}

		public Action ActionSkip
		{
			get { return () => { _modelItem.Skip(); _view.RefreshData(); }; }
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