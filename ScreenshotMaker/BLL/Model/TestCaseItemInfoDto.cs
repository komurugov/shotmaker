using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotMaker.BLL
{
	public class TestCaseItemInfoDto
	{
		public TestCaseItem Item { get; set; }
		public string RootFolder { get; set; }
		public System.Drawing.Imaging.ImageFormat ImageFormat { get; set; }
	}
}
