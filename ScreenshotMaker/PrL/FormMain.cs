using System;
using System.Windows.Forms;
using ScreenshotMaker.BLL;
using System.Drawing;
using System.Runtime.InteropServices;
using ScreenshotMaker.BLL.Win32Interop;

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
        private void MakeScreenshot(Func<IntPtr, bool> action, IntPtr window)
        {
            if (action == null)
                return;
            if (action(window))
                SelectNextSelectableTreeItem();
        }

        public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        //Declare the hook handle as an int.
        static int hHook = 0;

        //Declare the mouse hook constant.
        //For other hook types, you can obtain these values from Winuser.h in the Microsoft SDK.
        public const int WH_MOUSE_LL = 14;

        //Declare MouseHookProcedure as a HookProc type.
        HookProc MouseHookProcedure;

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public POINT(System.Drawing.Point pt) : this(pt.X, pt.Y) { }

            public static implicit operator System.Drawing.Point(POINT p)
            {
                return new System.Drawing.Point(p.X, p.Y);
            }

            public static implicit operator POINT(System.Drawing.Point p)
            {
                return new POINT(p.X, p.Y);
            }
        }
        //Declare the wrapper managed MouseHookStruct class.
        [StructLayout(LayoutKind.Sequential)]
        public class MouseHookStruct
        {
            public POINT pt;
            public int hwnd;
            public int wHitTestCode;
            public int dwExtraInfo;
        }

        //This is the Import for the SetWindowsHookEx function.
        //Use this function to install a thread-specific hook.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn,
        IntPtr hInstance, int threadId);

        //This is the Import for the UnhookWindowsHookEx function.
        //Call this function to uninstall the hook.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        //This is the Import for the CallNextHookEx function.
        //Use this function to pass the hook information to the next hook procedure in chain.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode,
        IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(System.Drawing.Point p);

        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetDesktopWindow();


        public static int MouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            //Marshall the data from the callback.
            MouseHookStruct MyMouseHookStruct = (MouseHookStruct)Marshal.PtrToStructure(lParam, typeof(MouseHookStruct));

            if (nCode < 0)
            {
                return CallNextHookEx(hHook, nCode, wParam, lParam);
            }
            else if (wParam.ToInt64() == 0x201 || wParam.ToInt64() == 0x204)
            {
                var tempForm = Program.MainForm;

                tempForm.MakeScreenshot(tempForm.GetSelectedPresenterItem()?.ActionPassed, WindowFromPoint(MyMouseHookStruct.pt));

                return 1;
            }
            else
                return CallNextHookEx(hHook, nCode, wParam, lParam);
        }

        private void buttonTestExecutionSelectedItemPassed_Click(object sender, EventArgs e)
		{
            if (IsEntireScreenNeededToBeCaptured())
                MakeScreenshot(GetSelectedPresenterItem()?.ActionPassed, GetDesktopWindow());
            else
            {
                button1_Click(null, null);
            }
                
        }
        private void buttonTestExecutionSelectedItemFailed_Click(object sender, EventArgs e)
		{
			IPresenterItem selectedPresenterItem = GetSelectedPresenterItem();
			if (selectedPresenterItem?.ActionFailed != null)
				if (selectedPresenterItem.ActionFailed())
					SelectNextSelectableTreeItem();
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

        private void button1_Click(object sender, EventArgs e)
        {
 //           if (hHook == 0)
            {
                // Create an instance of HookProc.
                MouseHookProcedure = new HookProc(MouseHookProc);

                var thread = System.Threading.Thread.CurrentThread.ManagedThreadId;

                hHook = SetWindowsHookEx(WH_MOUSE_LL,
                MouseHookProcedure,
                (IntPtr)0,
                0);
                //If the SetWindowsHookEx function fails.
                if (hHook == 0)
                {
                    Win32Interop.ErrorCodes errorCode = (Win32Interop.ErrorCodes)Marshal.GetLastWin32Error();
                    MessageBox.Show("SetWindowsHookEx Failed: " + errorCode);
                    return;
                }
                button1.Text = "UnHook Windows Hook";
            }
            //else
            //{
            //    bool ret = UnhookWindowsHookEx(hHook);
            //    //If the UnhookWindowsHookEx function fails.
            //    if (ret == false)
            //    {
            //        MessageBox.Show("UnhookWindowsHookEx Failed");
            //        return;
            //    }
            //    hHook = 0;
            //    button1.Text = "Set Windows Hook";
            //    this.Text = "Mouse Hook";
            //}
        }
    }
}