using System;
using System.Windows.Forms;
using ScreenshotMaker.BLL;
using System.Drawing;
using System.Runtime.InteropServices;
using ScreenshotMaker.BLL.Win32Interop;
using System.Collections.Generic;
using static ScreenshotMaker.BLL.Win32Interop.Win32Interop;

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

			SetControlsPropertiesForEditing();

			textBoxTestExecution.Text = "318";
			textBoxTestCase.Text = @"D:\my\proj\shotmaker\task\test case.xml";
			textBoxOutputFolder.Text = @"D:\my\_temp";
		}

		private void SetControlsPropertiesForEditing()
		{
			panelWork.Enabled = false;
			buttonEdit.Enabled = false;
			panelEdit.Enabled = true;
			buttonApply.Enabled = true;
			textBoxTestCase.Focus();
		}

		private void SetControlsPropertiesForWorking()
		{
			panelEdit.Enabled = false;
			buttonApply.Enabled = false;
			panelWork.Enabled = true;
			buttonEdit.Enabled = true;
			treeViewTestExecution.Focus();
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
			string prefix = "";
			Color color = Color.Black;
			if (presenterItem.Selectable)
				switch (presenterItem.Status)
				{
					case PresenterItemStatus.None:
						color = Color.IndianRed;    // dark red color from sketch was FromArgb(192, 0, 0)
						break;
					case PresenterItemStatus.Skipped:
						color = Color.IndianRed;
						prefix = "SKIPPED: ";
						break;
					case PresenterItemStatus.Done:
						switch (presenterItem.Result)
						{
							case PresenterItemResult.Failed:
								prefix = "FAILED: ";
								break;
							case PresenterItemResult.Passed:
								prefix = "PASSED: ";
								break;
						}
						break;
				}
			node.Text = prefix + presenterItem.Text;
			node.NodeFont = new Font(node.TreeView.Font, presenterItem.Selectable ? FontStyle.Underline : FontStyle.Regular);
			node.ForeColor = color;
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
				SetInputFileName(openFileDialog.FileName);
		}

		private void buttonChooseOutputFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				SetOutputFolderPath(folderBrowserDialog.SelectedPath);
		}

		private double _normalOpacity = 100;

		public void PrepareBeforeScreenshot()
		{
			// This two ways work too slowly:
			//WindowState = FormWindowState.Minimized;
			//Visible = false;

			_normalOpacity = Opacity;
			Opacity = 0;
		}

		public void RestoreAfterScreenshot()
		{
			Opacity = _normalOpacity;
			Activate();
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

		private void SelectPreviousSelectableTreeItem()
		{
			TreeNode node = null;
			if (treeViewTestExecution.SelectedNode == null)
			{
				if (treeViewTestExecution.Nodes.Count > 0)
					node = treeViewTestExecution.Nodes[treeViewTestExecution.Nodes.Count - 1];
			}
			else
				node = treeViewTestExecution.SelectedNode.PrevVisibleNode;
			while (node != null)
				if (IsNodeSelectable(node))
				{
					treeViewTestExecution.SelectedNode = node;
					return;
				}
				else
					node = node.PrevVisibleNode;
			Refresh();
		}

		private bool IsEntireScreenNeededToBeCaptured()
		{
			return radioButtonScreenshotAreaScreen.Checked;
		}



		private void MakeScreenshot(IntPtr window)
		{
			if (_choosedActionForMadeScreenshot == null)
				return;
			if (_choosedActionForMadeScreenshot(window))
				SelectNextSelectableTreeItem();
		}

		private static int _hHook;

		Func<IntPtr, bool> _choosedActionForMadeScreenshot;

		private void OnMouseHook(POINT point)
		{
			if (UnhookWindowsHookEx(_hHook))
				_hHook = 0;

			IntPtr window = GetAncestor(WindowFromPoint(point), GA_ROOTOWNER);
			if (window == null)
				ShowMessage("A window wasn't pointed!");
			else
				MakeScreenshot(window);
			RestoreAfterScreenshot();
		}

		public static int MouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (nCode < 0)
				return CallNextHookEx(_hHook, nCode, wParam, lParam);
			long code = wParam.ToInt64();
			if (new List<long>
			{
				(long)WindowsMessages.WM_LBUTTONUP,
				(long)WindowsMessages.WM_MBUTTONUP,
				(long)WindowsMessages.WM_RBUTTONUP
			}.Contains(code))
				return 1;
			else if (new List<long>
			{
				(long)WindowsMessages.WM_LBUTTONDOWN,
				(long)WindowsMessages.WM_MBUTTONDOWN,
				(long)WindowsMessages.WM_RBUTTONDOWN
			}.Contains(code))
			{
				var mouseHookStruct = (MouseHookStruct)Marshal.PtrToStructure(lParam, typeof(MouseHookStruct));

				Program.MainForm.OnMouseHook(mouseHookStruct.pt);

				return 1;
			}
			else
				return CallNextHookEx(_hHook, nCode, wParam, lParam);
		}

		private void buttonTestExecutionSelectedItemPassed_Click(object sender, EventArgs e)
		{
			_choosedActionForMadeScreenshot = GetSelectedPresenterItem()?.ActionPassed;
			ExecuteChoosedAction();
		}

		private void buttonTestExecutionSelectedItemFailed_Click(object sender, EventArgs e)
		{
			IPresenterItem selectedPresenterItem = GetSelectedPresenterItem();
			if (selectedPresenterItem?.ActionFailed != null)
				if (selectedPresenterItem.ActionFailed())
					SelectNextSelectableTreeItem();
		}

		private void ExecuteChoosedAction()
		{
			PrepareBeforeScreenshot();
			if (IsEntireScreenNeededToBeCaptured())
			{
				MakeScreenshot(GetDesktopWindow());
				RestoreAfterScreenshot();
			}
			else
				SetHook();
		}

		private void buttonTestExecutionSelectedItemSkip_Click(object sender, EventArgs e)
		{
			IPresenterItem selectedPresenterItem = GetSelectedPresenterItem();
			if (selectedPresenterItem?.ActionSkip != null)
				if (selectedPresenterItem.ActionSkip())
					SelectNextSelectableTreeItem();
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

		private void Apply()
		{
			if (_presenter.OpenFile())
				SetControlsPropertiesForWorking();
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			Apply();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			SetControlsPropertiesForEditing();
		}

		private void textBoxTestCase_TextChanged(object sender, EventArgs e)
		{
			SetInputFileName((sender as TextBox).Text);
		}

		private void textBoxOutputFolder_TextChanged(object sender, EventArgs e)
		{
			SetOutputFolderPath((sender as TextBox).Text);
		}

		private void treeViewTestExecution_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
		{
			e.Cancel = true;
		}

		private void editTextBoxesOnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				Apply();
				e.Handled = true;
			}
		}

		private void treeViewTestExecution_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Down:
					SelectNextSelectableTreeItem();
					e.Handled = true;
					break;
				case Keys.Up:
					SelectPreviousSelectableTreeItem();
					e.Handled = true;
					break;
			}
		}

		private void SetHook()
		{
			_hHook = SetWindowsHookEx(
				(int)WindowsHooks.WH_MOUSE_LL,
				new HookProc(MouseHookProc),
				(IntPtr)0,
				0);
			if (_hHook == 0)
			{
				ErrorCodes errorCode = (ErrorCodes)Marshal.GetLastWin32Error();
				ShowMessage("SetWindowsHookEx failed: " + errorCode);
			}
		}
	}
}