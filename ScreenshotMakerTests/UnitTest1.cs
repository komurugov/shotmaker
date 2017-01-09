using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScreenshotMaker.DAL;
using System.IO;

namespace MakerTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		[ExpectedException(typeof(FileNotFoundException), "Can't find file super.xml")]
		public void LoadFromInvalidPath()
		{
			XmlLoader.LoadFromFile("super.xml");
		}
	}
}
