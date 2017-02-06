namespace ScreenshotMaker.PrL
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.buttonChooseOutputFolder = new System.Windows.Forms.Button();
			this.textBoxOutputFolder = new System.Windows.Forms.TextBox();
			this.buttonChooseTestCase = new System.Windows.Forms.Button();
			this.textBoxTestCase = new System.Windows.Forms.TextBox();
			this.textBoxTextExecutionSelectedItemParent = new System.Windows.Forms.TextBox();
			this.labelTestExecutionSelectedItem = new System.Windows.Forms.Label();
			this.buttonTestExecutionSelectedItemShow = new System.Windows.Forms.Button();
			this.buttonTestExecutionSelectedItemSkip = new System.Windows.Forms.Button();
			this.buttonTestExecutionSelectedItemFailed = new System.Windows.Forms.Button();
			this.buttonTestExecutionSelectedItemPassed = new System.Windows.Forms.Button();
			this.treeViewTestExecution = new System.Windows.Forms.TreeView();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.textBoxTestExecution = new System.Windows.Forms.TextBox();
			this.labelTestExecution = new System.Windows.Forms.Label();
			this.labelTestCase = new System.Windows.Forms.Label();
			this.labelOutputFolder = new System.Windows.Forms.Label();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.panelEdit = new System.Windows.Forms.Panel();
			this.panelWork = new System.Windows.Forms.Panel();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.panelMetaEdit = new System.Windows.Forms.Panel();
			this.panelEdit.SuspendLayout();
			this.panelWork.SuspendLayout();
			this.panelMetaEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonChooseOutputFolder
			// 
			this.buttonChooseOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonChooseOutputFolder.Location = new System.Drawing.Point(540, 60);
			this.buttonChooseOutputFolder.Name = "buttonChooseOutputFolder";
			this.buttonChooseOutputFolder.Size = new System.Drawing.Size(87, 23);
			this.buttonChooseOutputFolder.TabIndex = 35;
			this.buttonChooseOutputFolder.Text = "Choose...";
			this.buttonChooseOutputFolder.UseVisualStyleBackColor = true;
			this.buttonChooseOutputFolder.Click += new System.EventHandler(this.buttonChooseOutputFolder_Click);
			// 
			// textBoxOutputFolder
			// 
			this.textBoxOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOutputFolder.Location = new System.Drawing.Point(96, 64);
			this.textBoxOutputFolder.Name = "textBoxOutputFolder";
			this.textBoxOutputFolder.ReadOnly = true;
			this.textBoxOutputFolder.Size = new System.Drawing.Size(438, 20);
			this.textBoxOutputFolder.TabIndex = 34;
			// 
			// buttonChooseTestCase
			// 
			this.buttonChooseTestCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonChooseTestCase.Location = new System.Drawing.Point(540, 36);
			this.buttonChooseTestCase.Name = "buttonChooseTestCase";
			this.buttonChooseTestCase.Size = new System.Drawing.Size(87, 23);
			this.buttonChooseTestCase.TabIndex = 33;
			this.buttonChooseTestCase.Text = "Choose...";
			this.buttonChooseTestCase.UseVisualStyleBackColor = true;
			this.buttonChooseTestCase.Click += new System.EventHandler(this.buttonChooseTestCase_Click);
			// 
			// textBoxTestCase
			// 
			this.textBoxTestCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTestCase.Location = new System.Drawing.Point(96, 38);
			this.textBoxTestCase.Name = "textBoxTestCase";
			this.textBoxTestCase.ReadOnly = true;
			this.textBoxTestCase.Size = new System.Drawing.Size(438, 20);
			this.textBoxTestCase.TabIndex = 32;
			// 
			// textBoxTextExecutionSelectedItemParent
			// 
			this.textBoxTextExecutionSelectedItemParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTextExecutionSelectedItemParent.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxTextExecutionSelectedItemParent.Location = new System.Drawing.Point(5, 569);
			this.textBoxTextExecutionSelectedItemParent.Multiline = true;
			this.textBoxTextExecutionSelectedItemParent.Name = "textBoxTextExecutionSelectedItemParent";
			this.textBoxTextExecutionSelectedItemParent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxTextExecutionSelectedItemParent.Size = new System.Drawing.Size(646, 75);
			this.textBoxTextExecutionSelectedItemParent.TabIndex = 31;
			// 
			// labelTestExecutionSelectedItem
			// 
			this.labelTestExecutionSelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTestExecutionSelectedItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTestExecutionSelectedItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelTestExecutionSelectedItem.Location = new System.Drawing.Point(5, 647);
			this.labelTestExecutionSelectedItem.Name = "labelTestExecutionSelectedItem";
			this.labelTestExecutionSelectedItem.Size = new System.Drawing.Size(646, 75);
			this.labelTestExecutionSelectedItem.TabIndex = 30;
			this.labelTestExecutionSelectedItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonTestExecutionSelectedItemShow
			// 
			this.buttonTestExecutionSelectedItemShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTestExecutionSelectedItemShow.Enabled = false;
			this.buttonTestExecutionSelectedItemShow.Location = new System.Drawing.Point(559, 736);
			this.buttonTestExecutionSelectedItemShow.Name = "buttonTestExecutionSelectedItemShow";
			this.buttonTestExecutionSelectedItemShow.Size = new System.Drawing.Size(75, 23);
			this.buttonTestExecutionSelectedItemShow.TabIndex = 29;
			this.buttonTestExecutionSelectedItemShow.Text = "S&how";
			this.buttonTestExecutionSelectedItemShow.UseVisualStyleBackColor = true;
			this.buttonTestExecutionSelectedItemShow.Click += new System.EventHandler(this.buttonTestExecutionSelectedItemShow_Click);
			// 
			// buttonTestExecutionSelectedItemSkip
			// 
			this.buttonTestExecutionSelectedItemSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonTestExecutionSelectedItemSkip.Enabled = false;
			this.buttonTestExecutionSelectedItemSkip.Location = new System.Drawing.Point(181, 736);
			this.buttonTestExecutionSelectedItemSkip.Name = "buttonTestExecutionSelectedItemSkip";
			this.buttonTestExecutionSelectedItemSkip.Size = new System.Drawing.Size(75, 23);
			this.buttonTestExecutionSelectedItemSkip.TabIndex = 28;
			this.buttonTestExecutionSelectedItemSkip.Text = "&Skip";
			this.buttonTestExecutionSelectedItemSkip.UseVisualStyleBackColor = true;
			this.buttonTestExecutionSelectedItemSkip.Click += new System.EventHandler(this.buttonTestExecutionSelectedItemSkip_Click);
			// 
			// buttonTestExecutionSelectedItemFailed
			// 
			this.buttonTestExecutionSelectedItemFailed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonTestExecutionSelectedItemFailed.Enabled = false;
			this.buttonTestExecutionSelectedItemFailed.Location = new System.Drawing.Point(100, 736);
			this.buttonTestExecutionSelectedItemFailed.Name = "buttonTestExecutionSelectedItemFailed";
			this.buttonTestExecutionSelectedItemFailed.Size = new System.Drawing.Size(75, 23);
			this.buttonTestExecutionSelectedItemFailed.TabIndex = 27;
			this.buttonTestExecutionSelectedItemFailed.Text = "&Failed";
			this.buttonTestExecutionSelectedItemFailed.UseVisualStyleBackColor = true;
			this.buttonTestExecutionSelectedItemFailed.Click += new System.EventHandler(this.buttonTestExecutionSelectedItemFailed_Click);
			// 
			// buttonTestExecutionSelectedItemPassed
			// 
			this.buttonTestExecutionSelectedItemPassed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonTestExecutionSelectedItemPassed.Enabled = false;
			this.buttonTestExecutionSelectedItemPassed.Location = new System.Drawing.Point(19, 736);
			this.buttonTestExecutionSelectedItemPassed.Name = "buttonTestExecutionSelectedItemPassed";
			this.buttonTestExecutionSelectedItemPassed.Size = new System.Drawing.Size(75, 23);
			this.buttonTestExecutionSelectedItemPassed.TabIndex = 26;
			this.buttonTestExecutionSelectedItemPassed.Text = "&Passed";
			this.buttonTestExecutionSelectedItemPassed.UseVisualStyleBackColor = true;
			this.buttonTestExecutionSelectedItemPassed.Click += new System.EventHandler(this.buttonTestExecutionSelectedItemPassed_Click);
			// 
			// treeViewTestExecution
			// 
			this.treeViewTestExecution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeViewTestExecution.BackColor = System.Drawing.SystemColors.Window;
			this.treeViewTestExecution.FullRowSelect = true;
			this.treeViewTestExecution.HideSelection = false;
			this.treeViewTestExecution.Location = new System.Drawing.Point(5, 3);
			this.treeViewTestExecution.Name = "treeViewTestExecution";
			this.treeViewTestExecution.ShowLines = false;
			this.treeViewTestExecution.ShowNodeToolTips = true;
			this.treeViewTestExecution.ShowPlusMinus = false;
			this.treeViewTestExecution.ShowRootLines = false;
			this.treeViewTestExecution.Size = new System.Drawing.Size(646, 560);
			this.treeViewTestExecution.TabIndex = 25;
			this.treeViewTestExecution.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewTestExecution_BeforeSelect);
			this.treeViewTestExecution.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTestExecution_AfterSelect);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// textBoxTestExecution
			// 
			this.textBoxTestExecution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTestExecution.Location = new System.Drawing.Point(96, 12);
			this.textBoxTestExecution.Name = "textBoxTestExecution";
			this.textBoxTestExecution.Size = new System.Drawing.Size(531, 20);
			this.textBoxTestExecution.TabIndex = 36;
			// 
			// labelTestExecution
			// 
			this.labelTestExecution.AutoSize = true;
			this.labelTestExecution.Location = new System.Drawing.Point(9, 14);
			this.labelTestExecution.Name = "labelTestExecution";
			this.labelTestExecution.Size = new System.Drawing.Size(81, 13);
			this.labelTestExecution.TabIndex = 37;
			this.labelTestExecution.Text = "Test Execution:";
			// 
			// labelTestCase
			// 
			this.labelTestCase.AutoSize = true;
			this.labelTestCase.Location = new System.Drawing.Point(9, 40);
			this.labelTestCase.Name = "labelTestCase";
			this.labelTestCase.Size = new System.Drawing.Size(58, 13);
			this.labelTestCase.TabIndex = 39;
			this.labelTestCase.Text = "Test Case:";
			// 
			// labelOutputFolder
			// 
			this.labelOutputFolder.AutoSize = true;
			this.labelOutputFolder.Location = new System.Drawing.Point(9, 67);
			this.labelOutputFolder.Name = "labelOutputFolder";
			this.labelOutputFolder.Size = new System.Drawing.Size(71, 13);
			this.labelOutputFolder.TabIndex = 40;
			this.labelOutputFolder.Text = "Output folder:";
			// 
			// panelEdit
			// 
			this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelEdit.Controls.Add(this.buttonChooseOutputFolder);
			this.panelEdit.Controls.Add(this.labelOutputFolder);
			this.panelEdit.Controls.Add(this.labelTestCase);
			this.panelEdit.Controls.Add(this.labelTestExecution);
			this.panelEdit.Controls.Add(this.textBoxTestExecution);
			this.panelEdit.Controls.Add(this.textBoxOutputFolder);
			this.panelEdit.Controls.Add(this.buttonChooseTestCase);
			this.panelEdit.Controls.Add(this.textBoxTestCase);
			this.panelEdit.Location = new System.Drawing.Point(5, 9);
			this.panelEdit.Name = "panelEdit";
			this.panelEdit.Size = new System.Drawing.Size(646, 100);
			this.panelEdit.TabIndex = 41;
			// 
			// panelWork
			// 
			this.panelWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelWork.Controls.Add(this.textBoxTextExecutionSelectedItemParent);
			this.panelWork.Controls.Add(this.labelTestExecutionSelectedItem);
			this.panelWork.Controls.Add(this.buttonTestExecutionSelectedItemShow);
			this.panelWork.Controls.Add(this.buttonTestExecutionSelectedItemSkip);
			this.panelWork.Controls.Add(this.buttonTestExecutionSelectedItemFailed);
			this.panelWork.Controls.Add(this.buttonTestExecutionSelectedItemPassed);
			this.panelWork.Controls.Add(this.treeViewTestExecution);
			this.panelWork.Enabled = false;
			this.panelWork.Location = new System.Drawing.Point(11, 180);
			this.panelWork.Name = "panelWork";
			this.panelWork.Size = new System.Drawing.Size(661, 770);
			this.panelWork.TabIndex = 42;
			// 
			// buttonEdit
			// 
			this.buttonEdit.Enabled = false;
			this.buttonEdit.Location = new System.Drawing.Point(19, 115);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 23);
			this.buttonEdit.TabIndex = 32;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(100, 115);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 43;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// panelMetaEdit
			// 
			this.panelMetaEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelMetaEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMetaEdit.Controls.Add(this.buttonApply);
			this.panelMetaEdit.Controls.Add(this.panelEdit);
			this.panelMetaEdit.Controls.Add(this.buttonEdit);
			this.panelMetaEdit.Location = new System.Drawing.Point(11, 12);
			this.panelMetaEdit.Name = "panelMetaEdit";
			this.panelMetaEdit.Size = new System.Drawing.Size(661, 148);
			this.panelMetaEdit.TabIndex = 44;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 962);
			this.Controls.Add(this.panelMetaEdit);
			this.Controls.Add(this.panelWork);
			this.MinimumSize = new System.Drawing.Size(420, 600);
			this.Name = "FormMain";
			this.Text = "QA Screenshot Maker";
			this.panelEdit.ResumeLayout(false);
			this.panelEdit.PerformLayout();
			this.panelWork.ResumeLayout(false);
			this.panelWork.PerformLayout();
			this.panelMetaEdit.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonChooseOutputFolder;
        private System.Windows.Forms.TextBox textBoxOutputFolder;
        private System.Windows.Forms.Button buttonChooseTestCase;
        private System.Windows.Forms.TextBox textBoxTestCase;
        private System.Windows.Forms.TextBox textBoxTextExecutionSelectedItemParent;
        private System.Windows.Forms.Label labelTestExecutionSelectedItem;
        private System.Windows.Forms.Button buttonTestExecutionSelectedItemShow;
        private System.Windows.Forms.Button buttonTestExecutionSelectedItemSkip;
        private System.Windows.Forms.Button buttonTestExecutionSelectedItemFailed;
        private System.Windows.Forms.Button buttonTestExecutionSelectedItemPassed;
        private System.Windows.Forms.TreeView treeViewTestExecution;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.TextBox textBoxTestExecution;
		private System.Windows.Forms.Label labelTestExecution;
		private System.Windows.Forms.Label labelTestCase;
		private System.Windows.Forms.Label labelOutputFolder;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Panel panelEdit;
		private System.Windows.Forms.Panel panelWork;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Panel panelMetaEdit;
	}
}

