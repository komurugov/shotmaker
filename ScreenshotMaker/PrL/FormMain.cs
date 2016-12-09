﻿using System;
using System.Windows.Forms;
using ScreenshotMaker.BLL;
using ScreenshotMaker.DAL;

namespace ScreenshotMaker.PrL
{
	public partial class FormMain : Form, IView
	{
		private IPresenter _presenter;

		public FormMain(IPresenter presenter)
		{
			InitializeComponent();

			presenter.View = this;

			_presenter = presenter;

			treeView2.ExpandAll();
		}

		public string GetTestExecutionName()
		{
			throw new NotImplementedException();
		}

		public string GetOuputFolderPath()
		{
			throw new NotImplementedException();
		}

		public void ShowMessage(string message)
		{
			MessageBox.Show(message);
		}

		public void RefreshTreeStructure()
		{
			throw new NotImplementedException();
		}

		public void RefreshData()
		{
			throw new NotImplementedException();
		}

		public string InputFileName { get; private set; }

		public string GetInputFileName()
		{
			return InputFileName;
		}

		private void button14_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				InputFileName = openFileDialog1.FileName;
				_presenter.OpenFile();
			}
		}

		//		private void ConsoleWriteLine(string s)
		//		{
		//			richTextBox1.Text += s + "\n";
		//		}

		//		private void button14_Click(object sender, EventArgs e)
		//		{
		//			string[] files = new string[] {
		//			"C:\\proj\\shotmaker\\task\\examples of input\\OLSS-4818.xml",
		//			"C:\\proj\\shotmaker\\task\\examples of input\\test case.xml",
		//			"C:\\proj\\shotmaker\\task\\examples of input\\test1.xml",
		//			"C:\\proj\\shotmaker\\task\\examples of input\\test2.xml",
		//			"C:\\proj\\shotmaker\\task\\examples of input\\test3.xml",
		//			"C:\\proj\\shotmaker\\task\\examples of input\\test4.xml",
		//			"C:\\proj\\shotmaker\\task\\examples of input\\test5.xml"
		//			};
		//			foreach (string s in files)
		//			{
		//				//				var dto = XmlLoader.LoadFromFile(s);
		//				//				MessageBox.Show(dto.channel.item.title.ToString());
		//				var testCase = TestCaseFromXmlLoader.Load(s);
		//				ConsoleWriteLine("");
		//				ConsoleWriteLine(testCase.IdAndTitle);
		//				ConsoleWriteLine("Setup:");
		//				foreach (Setup setup in testCase.Setups)
		//					ConsoleWriteLine(setup.Text);
		//				foreach (Verification verification in testCase.Verifications)
		//				{
		//					ConsoleWriteLine("Verification Data:");
		//					foreach (Data data in verification.Data)
		//						ConsoleWriteLine(data.Text);
		//					ConsoleWriteLine("Verification Steps:");
		//					foreach (Step step in verification.Steps)
		//					{
		//						ConsoleWriteLine("Step:");
		//						ConsoleWriteLine(step.Text);
		//						ConsoleWriteLine("Results:");
		//						foreach (var result in step.Results)
		//							ConsoleWriteLine(result.Text);
		//					}
		//				}
		////				MessageBox.Show(testCase.IdAndTitle);
		//			}
		//		}
	}
}