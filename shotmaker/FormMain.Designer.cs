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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("SKIPPED: Installed OLSS and ECM 5.0 Server");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Installed OLSS Client and AUU");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Preconditions", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Internal Authentication");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("OLSS user \'user1\' with privileges to login into AUU Web UI");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Data", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("PASSED: AUU Login page with \"User name\" and \"Password\" without \"Domain\"");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("1. Navigate to AUU home page", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("FAILED: Password is encrypted");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
        "ehavior in case of long text.", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("AUU System Information page is open");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Current user is \'user1\'");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode(resources.GetString("treeViewMain.Nodes"), new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Steps", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Verification: 1", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Case: OLSS-4435-TC-AUU-Login-Positive-Scenarios-0001 ", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Execution: OLSS-4589-TE-Sprint-4-Saratov", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeViewMain
            // 
            this.treeViewMain.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewMain.Location = new System.Drawing.Point(37, 83);
            this.treeViewMain.Name = "treeViewMain";
            treeNode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            treeNode1.Name = "Node4";
            treeNode1.Text = "SKIPPED: Installed OLSS and ECM 5.0 Server";
            treeNode2.Name = "Node6";
            treeNode2.Text = "Installed OLSS Client and AUU";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Preconditions";
            treeNode4.Name = "Node9";
            treeNode4.Text = "Internal Authentication";
            treeNode5.Name = "Node10";
            treeNode5.Text = "OLSS user \'user1\' with privileges to login into AUU Web UI";
            treeNode6.Name = "Node8";
            treeNode6.Text = "Data";
            treeNode7.ForeColor = System.Drawing.Color.Green;
            treeNode7.Name = "Node13";
            treeNode7.Text = "PASSED: AUU Login page with \"User name\" and \"Password\" without \"Domain\"";
            treeNode8.Name = "Node12";
            treeNode8.Text = "1. Navigate to AUU home page";
            treeNode9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode9.Name = "Node15";
            treeNode9.Text = "FAILED: Password is encrypted";
            treeNode10.Name = "Node14";
            treeNode10.Text = "2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
    "ehavior in case of long text.";
            treeNode11.ForeColor = System.Drawing.Color.Gray;
            treeNode11.Name = "Node17";
            treeNode11.Text = "AUU System Information page is open";
            treeNode12.ForeColor = System.Drawing.Color.Gray;
            treeNode12.Name = "Node18";
            treeNode12.Text = "Current user is \'user1\'";
            treeNode13.Name = "Node16";
            treeNode13.Text = resources.GetString("treeNode13.Text");
            treeNode14.Name = "Node11";
            treeNode14.Text = "Steps";
            treeNode15.Name = "Node7";
            treeNode15.Text = "Verification: 1";
            treeNode16.Name = "Node2";
            treeNode16.Text = "Case: OLSS-4435-TC-AUU-Login-Positive-Scenarios-0001 ";
            treeNode17.Name = "Node0";
            treeNode17.Text = "Execution: OLSS-4589-TE-Sprint-4-Saratov";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.treeViewMain.ShowLines = false;
            this.treeViewMain.ShowPlusMinus = false;
            this.treeViewMain.ShowRootLines = false;
            this.treeViewMain.Size = new System.Drawing.Size(480, 283);
            this.treeViewMain.TabIndex = 0;
            this.treeViewMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Passed";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 585);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Failed";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 585);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "&Skip";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 585);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "S&how";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(38, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 75);
            this.label1.TabIndex = 7;
            this.label1.Text = "AUU System Information page is open";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(38, 399);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(479, 75);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "C:\\JIRA\\Test Cases\\FR2\\OLSS-4818.xml";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(427, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Test Case...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(427, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Output folder...";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(37, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(384, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "C:\\Test Reports\\FR2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 670);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeViewMain);
            this.Name = "FormMain";
            this.Text = "QA Screenshot Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox3;
    }
}

