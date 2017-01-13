using System;
using System.Windows.Forms;
using ScreenshotMaker.BLL;
using ScreenshotMaker.DAL;
using System.Drawing;

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

		private TreeNode CreateSubtree(Tree<IPresenterItem> presenterItem)
		{
			var treeNode = new TreeNode();
			treeNode.Tag = presenterItem;
			foreach (Tree<IPresenterItem> presenterSubItem in presenterItem)
				treeNode.Nodes.Add(CreateSubtree(presenterSubItem));
			return treeNode;
		}

		public void RefreshTreeStructure()
		{
			treeView2.Nodes.Clear();
			treeView2.Nodes.Add(CreateSubtree(_presenter.Items));
		}

		private void RefreshTreeNodeRecursively(TreeNode node)
		{
			RefreshTreeNode(node);
			foreach (TreeNode subNode in node.Nodes)
				RefreshTreeNodeRecursively(subNode);
		}

		private void RefreshTreeNode(TreeNode node)
		{
			var presenterNode = Tag as Tree<IPresenterItem>;
			if (presenterNode == null)
				return;
			IPresenterItem presenterItem = presenterNode.Value;
			node.Text = presenterItem.Text;
			node.NodeFont = new Font(node.NodeFont, presenterItem.Selectable ? FontStyle.Underline : FontStyle.Regular);
			node.ForeColor = presenterItem.Status == PresenterItemStatus.Done ? Color.Black : Color.Red;
		}

		public void RefreshData()
		{
			RefreshTreeNodeRecursively(treeView2.Nodes[0]);
		}

		private string _inputFileName;

		public string GetInputFileName()
		{
			return _inputFileName;
		}

		private void SetInputFileName(string name)
		{
			_inputFileName = name;
			textBox8.Text = name;
			openFileDialog1.FileName = name;
		}


		private void button14_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				SetInputFileName(openFileDialog1.FileName);
				_presenter.OpenFile();
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			//			new TestCaseItem("").MakeScreenshot(Result.Unknown);
			new PresenterSelectableItem(new TestCaseItem(""), this).ActionPassed();
		}

		private double _normalOpacity = 100;

		public void PrepareBeforeScreenshot()
		{
			//WindowState = FormWindowState.Minimized;

			//Visible = false;

			_normalOpacity = Opacity;
			Opacity = 0;
		}

		public void RestoreAfterScreenshot()
		{
			Opacity = _normalOpacity;
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