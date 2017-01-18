using System;

namespace ScreenshotMaker.BLL
{
	internal class PresenterSelectableItem : IPresenterItem
	{
		private PrL.IView _view;
		private TestCase.ItemCoordinates _testCaseCoordinates;
		private TestCase _testCase;

		public PresenterSelectableItem(TestCase testCase, TestCase.ItemCoordinates coordinates, PrL.IView view)
		{
			_testCase = testCase;
			_testCaseCoordinates = coordinates;
			_view = view;
		}

		public string Text
		{
			get
			{
				string prefix = "";
				switch (_testCase.GetStatus(_testCaseCoordinates))
				{
					case BLL.Status.Done:
						switch (_testCase.GetResult(_testCaseCoordinates))
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
				return prefix + _testCase.GetText(_testCaseCoordinates);
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
				switch (_testCase.GetStatus(_testCaseCoordinates))
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
				switch (_testCase.GetResult(_testCaseCoordinates))
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
			_testCase.MakeScreenshot(result, _testCaseCoordinates);
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
			get { return () => { _testCase.Skip(_testCaseCoordinates); _view.RefreshData(); }; }
		}

		public Action ActionShow
		{
			get
			{

				if (_testCase.HasScreenshot(_testCaseCoordinates))
					return () => _testCase.Show(_testCaseCoordinates);
				else
					return null;
			}
		}
	}
}