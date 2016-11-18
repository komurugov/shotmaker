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
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("SKIPPED: Installed OLSS and ECM 5.0 Server");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("PASSED: Installed OLSS Client and AUU");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Preconditions", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("PASSED: Internal Authentication");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("PASSED: OLSS user \'user1\' with privileges to login into AUU Web UI");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Data", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("PASSED: AUU Login page with \"User name\" and \"Password\" without \"Domain\"");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("1. Navigate to AUU home page", new System.Windows.Forms.TreeNode[] {
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("FAILED: Password is encrypted");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
        "ehavior in case of long text.", new System.Windows.Forms.TreeNode[] {
            treeNode43});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("AUU System Information page is open");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Current user is \'user1\'");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode(resources.GetString("treeViewMain.Nodes"), new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Steps", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode44,
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Verification: 1", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Case: OLSS-4435-TC-AUU-Login-Positive-Scenarios-0001 ", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Execution: OLSS-4589-TE-Sprint-4-Saratov", new System.Windows.Forms.TreeNode[] {
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("SKIPPED: Installed OLSS and ECM 5.0 Server");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("PASSED: Installed OLSS Client and AUU");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Preconditions", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("PASSED: Internal Authentication");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Data", new System.Windows.Forms.TreeNode[] {
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("PASSED: AUU Login page with \"User name\" and \"Password\" without \"Domain\"");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("PASSED: OLSS user \'user1\' with privileges to login into AUU Web UI");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("1. Navigate to AUU home page", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("FAILED: Password is encrypted");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
        "ehavior in case of long text.", new System.Windows.Forms.TreeNode[] {
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("AUU System Information page is open");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Current user is \'user1\'");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode(resources.GetString("treeView1.Nodes"), new System.Windows.Forms.TreeNode[] {
            treeNode62,
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Steps", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode61,
            treeNode64});
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Verification: 1", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Case: OLSS-4435-TC-AUU-Login-Positive-Scenarios-0001 ", new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Execution: OLSS-4589-TE-Sprint-4-Saratov", new System.Windows.Forms.TreeNode[] {
            treeNode67});
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
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewMain
            // 
            this.treeViewMain.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewMain.Location = new System.Drawing.Point(37, 83);
            this.treeViewMain.Name = "treeViewMain";
            treeNode35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            treeNode35.Name = "Node4";
            treeNode35.Text = "SKIPPED: Installed OLSS and ECM 5.0 Server";
            treeNode36.ForeColor = System.Drawing.Color.Green;
            treeNode36.Name = "Node6";
            treeNode36.Text = "PASSED: Installed OLSS Client and AUU";
            treeNode37.Name = "Node3";
            treeNode37.Text = "Preconditions";
            treeNode38.ForeColor = System.Drawing.Color.Green;
            treeNode38.Name = "Node9";
            treeNode38.Text = "PASSED: Internal Authentication";
            treeNode39.ForeColor = System.Drawing.Color.Green;
            treeNode39.Name = "Node10";
            treeNode39.Text = "PASSED: OLSS user \'user1\' with privileges to login into AUU Web UI";
            treeNode40.Name = "Node8";
            treeNode40.Text = "Data";
            treeNode41.ForeColor = System.Drawing.Color.Green;
            treeNode41.Name = "Node13";
            treeNode41.Text = "PASSED: AUU Login page with \"User name\" and \"Password\" without \"Domain\"";
            treeNode42.Name = "Node12";
            treeNode42.Text = "1. Navigate to AUU home page";
            treeNode43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode43.Name = "Node15";
            treeNode43.Text = "FAILED: Password is encrypted";
            treeNode44.Name = "Node14";
            treeNode44.Text = "2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
    "ehavior in case of long text.";
            treeNode45.ForeColor = System.Drawing.Color.Gray;
            treeNode45.Name = "Node17";
            treeNode45.Text = "AUU System Information page is open";
            treeNode46.ForeColor = System.Drawing.Color.Gray;
            treeNode46.Name = "Node18";
            treeNode46.Text = "Current user is \'user1\'";
            treeNode47.Name = "Node16";
            treeNode47.Text = resources.GetString("treeNode47.Text");
            treeNode48.Name = "Node11";
            treeNode48.Text = "Steps";
            treeNode49.Name = "Node7";
            treeNode49.Text = "Verification: 1";
            treeNode50.Name = "Node2";
            treeNode50.Text = "Case: OLSS-4435-TC-AUU-Login-Positive-Scenarios-0001 ";
            treeNode51.Name = "Node0";
            treeNode51.Text = "Execution: OLSS-4589-TE-Sprint-4-Saratov";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode51});
            this.treeViewMain.ShowLines = false;
            this.treeViewMain.ShowPlusMinus = false;
            this.treeViewMain.ShowRootLines = false;
            this.treeViewMain.Size = new System.Drawing.Size(480, 340);
            this.treeViewMain.TabIndex = 0;
            this.treeViewMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Passed";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Failed";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "&Skip";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(441, 628);
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
            this.label1.Location = new System.Drawing.Point(37, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 75);
            this.label1.TabIndex = 7;
            this.label1.Text = "AUU System Information page is open";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(37, 442);
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1034, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Output folder...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(644, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(384, 20);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "C:\\Test Reports\\FR2";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1034, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "Test Case...";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(644, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(384, 20);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "C:\\JIRA\\Test Cases\\FR2\\OLSS-4818.xml";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.Location = new System.Drawing.Point(644, 442);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(479, 75);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(644, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 75);
            this.label2.TabIndex = 19;
            this.label2.Text = "AUU System Information page is open";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1048, 628);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "S&how";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(809, 628);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "&Skip";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(728, 628);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 16;
            this.button11.Text = "&Failed";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(647, 628);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 15;
            this.button12.Text = "&Passed";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.Location = new System.Drawing.Point(644, 83);
            this.treeView1.Name = "treeView1";
            treeNode52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode52.Name = "Node4";
            treeNode52.Text = "SKIPPED: Installed OLSS and ECM 5.0 Server";
            treeNode53.Name = "Node6";
            treeNode53.Text = "PASSED: Installed OLSS Client and AUU";
            treeNode54.Name = "Node3";
            treeNode54.Text = "Preconditions";
            treeNode55.Name = "Node9";
            treeNode55.Text = "PASSED: Internal Authentication";
            treeNode56.Name = "Node8";
            treeNode56.Text = "Data";
            treeNode57.Name = "Node13";
            treeNode57.Text = "PASSED: AUU Login page with \"User name\" and \"Password\" without \"Domain\"";
            treeNode58.Name = "Node10";
            treeNode58.Text = "PASSED: OLSS user \'user1\' with privileges to login into AUU Web UI";
            treeNode59.Name = "Node12";
            treeNode59.Text = "1. Navigate to AUU home page";
            treeNode60.Name = "Node15";
            treeNode60.Text = "FAILED: Password is encrypted";
            treeNode61.Name = "Node14";
            treeNode61.Text = "2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
    "ehavior in case of long text.";
            treeNode62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode62.Name = "Node17";
            treeNode62.Text = "AUU System Information page is open";
            treeNode63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode63.Name = "Node18";
            treeNode63.Text = "Current user is \'user1\'";
            treeNode64.Name = "Node16";
            treeNode64.Text = resources.GetString("treeNode64.Text");
            treeNode65.Name = "Node11";
            treeNode65.Text = "Steps";
            treeNode66.Name = "Node7";
            treeNode66.Text = "Verification: 1";
            treeNode67.Name = "Node2";
            treeNode67.Text = "Case: OLSS-4435-TC-AUU-Login-Positive-Scenarios-0001 ";
            treeNode68.Name = "Node0";
            treeNode68.Text = "Execution: OLSS-4589-TE-Sprint-4-Saratov";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode68});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(480, 340);
            this.treeView1.TabIndex = 14;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 670);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.treeView1);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TreeView treeView1;
    }
}

