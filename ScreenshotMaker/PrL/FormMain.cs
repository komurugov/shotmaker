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
			return textBox1.Text;
		}

		private string _outputFolderPath;

		public string GetOuputFolderPath()
		{
			return _outputFolderPath;
		}

		private void SetOutputFolderPath(string path)
		{
			textBox7.Text = path;
			folderBrowserDialog1.SelectedPath = path;
			_outputFolderPath = path;
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
			treeView2.ExpandAll();

			SelectNextSelectableTreeItem();
			treeView2.TopNode = treeView2.Nodes[0];
		}

		private void RefreshTreeNodeRecursively(TreeNode node)
		{
			RefreshTreeNode(node);
			foreach (TreeNode subNode in node.Nodes)
				RefreshTreeNodeRecursively(subNode);
		}

		private void RefreshTreeNode(TreeNode node)
		{
			var presenterNode = node.Tag as Tree<IPresenterItem>;
			if (presenterNode == null)
				return;
			IPresenterItem presenterItem = presenterNode.Value;
			node.Text = presenterItem.Text;
			node.NodeFont = new Font(node.TreeView.Font, presenterItem.Selectable ? FontStyle.Underline : FontStyle.Regular);
			node.ForeColor = !presenterItem.Selectable || presenterItem.Status == PresenterItemStatus.Done ? Color.Black : Color.FromArgb(192, 0, 0) /*dark red*/;
		}

		public void RefreshData()
		{
			RefreshTreeNodeRecursively(treeView2.Nodes[0]);

			OnChangeSelectedNode();
		}

		private string _inputFileName;

		public string GetInputFileName()
		{
			return _inputFileName;
		}

		private void SetInputFileName(string name)
		{
			textBox8.Text = name;
			openFileDialog1.FileName = name;
			_inputFileName = name;
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
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
				SetOutputFolderPath(folderBrowserDialog1.SelectedPath);
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

		private void button1_Click(object sender, EventArgs e)
		{
			//			new TestCaseItem("").MakeScreenshot(Result.Unknown);

			new PresenterSelectableItem(new TestCaseItem(""), this).ActionPassed();
		}

		private IPresenterItem _selectedPresenterItem;

		private void treeView2_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			var selectedPresenterItemTree = e.Node.Tag as Tree<IPresenterItem>;
			if (selectedPresenterItemTree == null)
				return;
			var selectedPresenterItem = selectedPresenterItemTree.Value;
			if (selectedPresenterItem == null)
				return;
			if (selectedPresenterItem.Selectable)
				_selectedPresenterItem = selectedPresenterItem;
			else
				e.Cancel = true;
		}

		private void OnChangeSelectedNode()
		{
			button18.Enabled = _selectedPresenterItem.ActionPassed != null;
			button17.Enabled = _selectedPresenterItem.ActionFailed != null;
			button16.Enabled = _selectedPresenterItem.ActionSkip != null;
			button15.Enabled = _selectedPresenterItem.ActionShow != null;

			TreeNode selectedNode = treeView2.SelectedNode;
			label3.Text = selectedNode.Text;
			label3.ForeColor = selectedNode.ForeColor;
			textBox9.Text = selectedNode.Parent == null ? "" : selectedNode.Parent.Text;
		}

		private bool IsNodeSelectable(TreeNode node)
		{
			var presenterItemTree = node.Tag as Tree<IPresenterItem>;
			return presenterItemTree != null && presenterItemTree.Value != null && presenterItemTree.Value.Selectable;
		}
		
		private void SelectNextSelectableTreeItem()
		{
			TreeNode node;
			if (treeView2.SelectedNode == null)
				node = treeView2.Nodes[0];
			else
				node = treeView2.SelectedNode.NextVisibleNode;
			while (node != null)
				if (IsNodeSelectable(node))
				{
					treeView2.SelectedNode = node;
					return;
				}
				else
					node = node.NextVisibleNode;
			Refresh();
		}

		private void button18_Click(object sender, EventArgs e)
		{
			if (_selectedPresenterItem != null && _selectedPresenterItem.ActionPassed != null)
			{
				_selectedPresenterItem.ActionPassed();
				SelectNextSelectableTreeItem();
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			if (_selectedPresenterItem != null && _selectedPresenterItem.ActionFailed != null)
			{
				_selectedPresenterItem.ActionFailed();
				SelectNextSelectableTreeItem();
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			if (_selectedPresenterItem != null && _selectedPresenterItem.ActionSkip != null)
			{
				_selectedPresenterItem.ActionSkip();
				SelectNextSelectableTreeItem();
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			if (_selectedPresenterItem != null && _selectedPresenterItem.ActionShow != null)
				_selectedPresenterItem.ActionShow();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = treeView2.SelectedNode.Text;
		}

		private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
		{
			OnChangeSelectedNode();
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