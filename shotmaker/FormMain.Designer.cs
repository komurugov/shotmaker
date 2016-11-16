namespace shotmaker
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
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Installed OLSS and ECM 5.0 Server");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Installed OLSS Client and AUU");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Preconditions", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Internal Authentication");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("OLSS user \'user1\' with privileges to login into AUU Web UI");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Data", new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("AUU Login page with \"User name\" and \"Password\" without \"Domain\"");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("1. Navigate to AUU home page", new System.Windows.Forms.TreeNode[] {
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Password is encrypted");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
        "ehavior in case of long text.", new System.Windows.Forms.TreeNode[] {
            treeNode60});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("AUU System Information page is open");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Current user is \'user1\'");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode(resources.GetString("treeViewMain.Nodes"), new System.Windows.Forms.TreeNode[] {
            treeNode62,
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Steps", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode61,
            treeNode64});
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Verification: 1", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Case: OLSS-4435-TC-AUU-Login-Positive-Scenarios-0001 ", new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Execution: OLSS-4589-TE-Sprint-4-Saratov", new System.Windows.Forms.TreeNode[] {
            treeNode67});
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewMain
            // 
            this.treeViewMain.Location = new System.Drawing.Point(37, 54);
            this.treeViewMain.Name = "treeViewMain";
            treeNode52.Name = "Node4";
            treeNode52.Text = "Installed OLSS and ECM 5.0 Server";
            treeNode53.Name = "Node6";
            treeNode53.Text = "Installed OLSS Client and AUU";
            treeNode54.Name = "Node3";
            treeNode54.Text = "Preconditions";
            treeNode55.Name = "Node9";
            treeNode55.Text = "Internal Authentication";
            treeNode56.Name = "Node10";
            treeNode56.Text = "OLSS user \'user1\' with privileges to login into AUU Web UI";
            treeNode57.Name = "Node8";
            treeNode57.Text = "Data";
            treeNode58.Name = "Node13";
            treeNode58.Text = "AUU Login page with \"User name\" and \"Password\" without \"Domain\"";
            treeNode59.Name = "Node12";
            treeNode59.Text = "1. Navigate to AUU home page";
            treeNode60.Name = "Node15";
            treeNode60.Text = "Password is encrypted";
            treeNode61.Name = "Node14";
            treeNode61.Text = "2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
    "ehavior in case of long text.";
            treeNode62.Name = "Node17";
            treeNode62.Text = "AUU System Information page is open";
            treeNode63.Name = "Node18";
            treeNode63.Text = "Current user is \'user1\'";
            treeNode64.Name = "Node16";
            treeNode64.Text = resources.GetString("treeNode64.Text");
            treeNode65.Name = "Node11";
            treeNode65.Text = "Steps";
            treeNode66.Name = "Node7";
            treeNode66.Text = "Verification: 1";
            treeNode67.Checked = true;
            treeNode67.Name = "Node2";
            treeNode67.Text = "Case: OLSS-4435-TC-AUU-Login-Positive-Scenarios-0001 ";
            treeNode68.Checked = true;
            treeNode68.Name = "Node0";
            treeNode68.Text = "Execution: OLSS-4589-TE-Sprint-4-Saratov";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode68});
            this.treeViewMain.ShowLines = false;
            this.treeViewMain.ShowPlusMinus = false;
            this.treeViewMain.ShowRootLines = false;
            this.treeViewMain.Size = new System.Drawing.Size(480, 381);
            this.treeViewMain.TabIndex = 0;
            this.treeViewMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Passed";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Failed";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Skip";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(442, 462);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 541);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeViewMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

