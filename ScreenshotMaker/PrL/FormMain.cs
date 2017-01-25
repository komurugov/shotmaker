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

			treeViewTestExecution.ExpandAll();
		}

		public string GetTestExecutionName()
		{
			return textBoxTestExecution.Text;
		}

		private string _outputFolderPath;

		public string GetOuputFolderPath()
		{
			return _outputFolderPath;
		}

		private void SetOutputFolderPath(string path)
		{
			textBoxOutputFolder.Text = path;
			folderBrowserDialog.SelectedPath = path;
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
			if (presenterItem != null)
				foreach (Tree<IPresenterItem> presenterSubItem in presenterItem)
					treeNode.Nodes.Add(CreateSubtree(presenterSubItem));
			return treeNode;
		}

		public void RefreshTreeStructure()
		{
			treeViewTestExecution.Nodes.Clear();
			treeViewTestExecution.Nodes.Add(CreateSubtree(_presenter.Items));
			treeViewTestExecution.ExpandAll();

			SelectNextSelectableTreeItem();
			if (treeViewTestExecution.Nodes.Count > 0)
				treeViewTestExecution.TopNode = treeViewTestExecution.Nodes[0];
		}

		private void RefreshTreeNodeRecursively(TreeNode node)
		{
			RefreshTreeNode(node);
			if (node != null)
				foreach (TreeNode subNode in node.Nodes)
					RefreshTreeNodeRecursively(subNode);
		}

		private void RefreshTreeNode(TreeNode node)
		{
			IPresenterItem presenterItem = (node?.Tag as Tree<IPresenterItem>)?.Value;
			if (presenterItem == null)
				return;
			node.Text = presenterItem.Text;
			node.NodeFont = new Font(node.TreeView.Font, presenterItem.Selectable ? FontStyle.Underline : FontStyle.Regular);
			node.ForeColor = !presenterItem.Selectable || presenterItem.Status == PresenterItemStatus.Done
				? Color.Black
				: Color.IndianRed; // dark red color from sketch was FromArgb(192, 0, 0)
		}

		public void RefreshData()
		{
			if (treeViewTestExecution.Nodes.Count > 0)
				RefreshTreeNodeRecursively(treeViewTestExecution.Nodes[0]);
			OnChangeSelectedNode();
		}

		private string _inputFileName;

		public string GetInputFileName()
		{
			return _inputFileName;
		}

		private void SetInputFileName(string name)
		{
			textBoxTestCase.Text = name;
			openFileDialog.FileName = name;
			_inputFileName = name;
		}


		private void buttonChooseTestCase_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				SetInputFileName(openFileDialog.FileName);
				_presenter.OpenFile();
			}
		}

		private void buttonChooseOutputFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				SetOutputFolderPath(folderBrowserDialog.SelectedPath);
		}

		private double _normalOpacity = 100;

		public void PrepareBeforeScreenshot()
		{
			// This two ways works too slowly:
			//WindowState = FormWindowState.Minimized;
			//Visible = false;

			_normalOpacity = Opacity;
			Opacity = 0;
		}

		public void RestoreAfterScreenshot()
		{
			Opacity = _normalOpacity;
		}

		private IPresenterItem GetSelectedPresenterItem()
		{
			return GetPresenterItem(treeViewTestExecution.SelectedNode);
		}

		private IPresenterItem GetPresenterItem(TreeNode selectedNode)
		{
			var presenterItem = (selectedNode?.Tag as Tree<IPresenterItem>)?.Value;
			if (presenterItem != null && presenterItem.Selectable)
				return presenterItem;
			return null;
		}

		private void treeViewTestExecution_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			var selectedPresenterItem = GetPresenterItem(e.Node);
			if (selectedPresenterItem == null)
				e.Cancel = true;
		}

		private void OnChangeSelectedNode()
		{
			IPresenterItem selectedPresenterItem = GetSelectedPresenterItem();
			buttonTestExecutionSelectedItemPassed.Enabled = selectedPresenterItem?.ActionPassed != null;
			buttonTestExecutionSelectedItemFailed.Enabled = selectedPresenterItem?.ActionFailed != null;
			buttonTestExecutionSelectedItemSkip.Enabled = selectedPresenterItem?.ActionSkip != null;
			buttonTestExecutionSelectedItemShow.Enabled = selectedPresenterItem?.ActionShow != null;

			TreeNode selectedNode = treeViewTestExecution.SelectedNode;
			labelTestExecutionSelectedItem.Text = selectedNode == null
				? ""
				: selectedNode.Text;
			labelTestExecutionSelectedItem.ForeColor = selectedNode == null
				? ForeColor
				: selectedNode.ForeColor;
			textBoxTextExecutionSelectedItemParent.Text = selectedNode?.Parent == null
				? ""
				: selectedNode.Parent.Text;
		}

		private bool IsNodeSelectable(TreeNode node)
		{
			var presenterItemTree = node?.Tag as Tree<IPresenterItem>;
			return presenterItemTree?.Value != null && presenterItemTree.Value.Selectable;
		}

		private void SelectNextSelectableTreeItem()
		{
			TreeNode node = null;
			if (treeViewTestExecution.SelectedNode == null)
			{
				if (treeViewTestExecution.Nodes.Count > 0)
					node = treeViewTestExecution.Nodes[0];
			}
			else
				node = treeViewTestExecution.SelectedNode.NextVisibleNode;
			while (node != null)
				if (IsNodeSelectable(node))
				{
					treeViewTestExecution.SelectedNode = node;
					return;
				}
				else
					node = node.NextVisibleNode;
			Refresh();
		}

		private void buttonTestExecutionSelectedItemPassed_Click(object sender, EventArgs e)
		{
			IPresenterItem selectedPresenterItem = GetSelectedPresenterItem();
			if (selectedPresenterItem?.ActionPassed != null)
			{
				selectedPresenterItem.ActionPassed();
				SelectNextSelectableTreeItem();
			}
		}

		private void buttonTestExecutionSelectedItemFailed_Click(object sender, EventArgs e)
		{
			IPresenterItem selectedPresenterItem = GetSelectedPresenterItem();
			if (selectedPresenterItem?.ActionFailed != null)
			{
				selectedPresenterItem.ActionFailed();
				SelectNextSelectableTreeItem();
			}
		}

		private void buttonTestExecutionSelectedItemSkip_Click(object sender, EventArgs e)
		{
			IPresenterItem selectedPresenterItem = GetSelectedPresenterItem();
			if (selectedPresenterItem?.ActionSkip != null)
			{
				selectedPresenterItem.ActionSkip();
				SelectNextSelectableTreeItem();
			}
		}

		private void buttonTestExecutionSelectedItemShow_Click(object sender, EventArgs e)
		{
			IPresenterItem selectedPresenterItem = GetSelectedPresenterItem();
			if (selectedPresenterItem?.ActionShow != null)
				selectedPresenterItem.ActionShow();
		}

		private void treeViewTestExecution_AfterSelect(object sender, TreeViewEventArgs e)
		{
			OnChangeSelectedNode();
		}
	}
}