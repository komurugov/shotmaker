using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScreenshotMaker.DAL;

namespace MakerTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void LoadDromInvalidPath()
		{
			var t = XmlLoader.LoadFromFile("super.xml");
			
			Assert.IsNull(t);
		}
	}
}
