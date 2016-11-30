using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotMaker.BLL
{
	class PresenterSimpleItem : IPresenterItem
	{
		PresenterSimpleItem(string text)
		{
			Text = text;
		}

		public string Text { get; set; }

		public void DoFail()
		{
		}

		public void DoPass()
		{
		}

		public void DoShow()
		{
		}

		public void DoSkip()
		{
		}

		public bool EnableFail()
		{
			return false;
		}

		public bool EnablePass()
		{
			return false;
		}

		public bool EnableShow()
		{
			return false;
		}

		public bool EnableSkip()
		{
			return false;
		}

		public Color GetColor()
		{
			return Color.Black;
		}

		public string GetText()
		{
			return Text;
		}

		public bool HasUnderline()
		{
			return false;
		}

		public bool IsSelectable()
		{
			return false;
		}
	}

	class PresenterSelectableItem : IPresenterItem
	{
		PresenterSelectableItem(IScreenshotable item)
		{
			ModelItem = item;
		}

		public IScreenshotable ModelItem { get; set; }

		public void DoFail()
		{
			if (ModelItem != null)
				ModelItem.MakeScreenshot(Result.Failed);
		}

		public void DoPass()
		{
			if (ModelItem != null)
				ModelItem.MakeScreenshot(Result.Passed);
		}

		public void DoShow()
		{
			if (ModelItem != null)
				ModelItem.Show();
		}

		public void DoSkip()
		{
			if (ModelItem != null)
				ModelItem.Skip();
		}

		public bool EnableFail()
		{
			return true;
		}

		public bool EnablePass()
		{
			return true;
		}

		public bool EnableShow()
		{
			return ModelItem != null && ModelItem.HasScreenshot();
		}

		public bool EnableSkip()
		{
			return true;
		}

		public Color GetColor()
		{
			throw new NotImplementedException();
		}

		public string GetText()
		{
			return ModelItem.Text;
			throw new NotImplementedException();
		}

		public bool HasUnderline()
		{
			throw new NotImplementedException();
		}

		public bool IsSelectable()
		{
			return true;
		}
	}
}