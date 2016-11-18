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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("PASSED: Installed OLSS Client and AUU");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Preconditions", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("PASSED: Internal Authentication");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("PASSED: OLSS user \'user1\' with privileges to login into AUU Web UI");
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
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("SKIPPED: Installed OLSS and ECM 5.0 Server");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("PASSED: Installed OLSS Client and AUU");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Preconditions", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("PASSED: Internal Authentication");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("PASSED: OLSS user \'user1\' with privileges to login into AUU Web UI");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Data", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("PASSED: AUU Login page with \"User name\" and \"Password\" without \"Domain\"");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("1. Navigate to AUU home page", new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("FAILED: Password is encrypted");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
        "ehavior in case of long text.", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("AUU System Information page is open");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Current user is \'user1\'");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode(resources.GetString("treeView1.Nodes"), new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Steps", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode27,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Verification: 1", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Case: OLSS-4435-TC-AUU-Login-Positive-Scenarios-0001 ", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Execution: OLSS-4589-TE-Sprint-4-Saratov", new System.Windows.Forms.TreeNode[] {
            treeNode33});
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
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("AUU System Information page is open");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Current user is \'user1\'");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode(resources.GetString("treeView2.Nodes"), new System.Windows.Forms.TreeNode[] {
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
            this.button13 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
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
            treeNode2.ForeColor = System.Drawing.Color.Green;
            treeNode2.Name = "Node6";
            treeNode2.Text = "PASSED: Installed OLSS Client and AUU";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Preconditions";
            treeNode4.ForeColor = System.Drawing.Color.Green;
            treeNode4.Name = "Node9";
            treeNode4.Text = "PASSED: Internal Authentication";
            treeNode5.ForeColor = System.Drawing.Color.Green;
            treeNode5.Name = "Node10";
            treeNode5.Text = "PASSED: OLSS user \'user1\' with privileges to login into AUU Web UI";
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
            this.button5.Location = new System.Drawing.Point(923, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Output folder...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(533, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(384, 20);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "C:\\Test Reports\\FR2";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(923, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "Test Case...";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(533, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(384, 20);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "C:\\JIRA\\Test Cases\\FR2\\OLSS-4818.xml";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.Location = new System.Drawing.Point(533, 442);
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
            this.label2.Location = new System.Drawing.Point(533, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 75);
            this.label2.TabIndex = 19;
            this.label2.Text = "AUU System Information page is open";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(937, 628);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "S&how";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(698, 628);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "&Skip";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(617, 628);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 16;
            this.button11.Text = "&Failed";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(536, 628);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 15;
            this.button12.Text = "&Passed";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.Location = new System.Drawing.Point(533, 83);
            this.treeView1.Name = "treeView1";
            treeNode18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode18.Name = "Node4";
            treeNode18.Text = "SKIPPED: Installed OLSS and ECM 5.0 Server";
            treeNode19.Name = "Node6";
            treeNode19.Text = "PASSED: Installed OLSS Client and AUU";
            treeNode20.Name = "Node3";
            treeNode20.Text = "Preconditions";
            treeNode21.Name = "Node9";
            treeNode21.Text = "PASSED: Internal Authentication";
            treeNode22.Name = "Node10";
            treeNode22.Text = "PASSED: OLSS user \'user1\' with privileges to login into AUU Web UI";
            treeNode23.Name = "Node8";
            treeNode23.Text = "Data";
            treeNode24.Name = "Node13";
            treeNode24.Text = "PASSED: AUU Login page with \"User name\" and \"Password\" without \"Domain\"";
            treeNode25.Name = "Node12";
            treeNode25.Text = "1. Navigate to AUU home page";
            treeNode26.Name = "Node15";
            treeNode26.Text = "FAILED: Password is encrypted";
            treeNode27.Name = "Node14";
            treeNode27.Text = "2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
    "ehavior in case of long text.";
            treeNode28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode28.Name = "Node17";
            treeNode28.Text = "AUU System Information page is open";
            treeNode29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode29.Name = "Node18";
            treeNode29.Text = "Current user is \'user1\'";
            treeNode30.Name = "Node16";
            treeNode30.Text = resources.GetString("treeNode30.Text");
            treeNode31.Name = "Node11";
            treeNode31.Text = "Steps";
            treeNode32.Name = "Node7";
            treeNode32.Text = "Verification: 1";
            treeNode33.Name = "Node2";
            treeNode33.Text = "Case: OLSS-4435-TC-AUU-Login-Positive-Scenarios-0001 ";
            treeNode34.Name = "Node0";
            treeNode34.Text = "Execution: OLSS-4589-TE-Sprint-4-Saratov";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode34});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(480, 340);
            this.treeView1.TabIndex = 14;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1409, 50);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 23);
            this.button13.TabIndex = 35;
            this.button13.Text = "Output folder...";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1019, 50);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(384, 20);
            this.textBox7.TabIndex = 34;
            this.textBox7.Text = "C:\\Test Reports\\FR2";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(1409, 24);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 23);
            this.button14.TabIndex = 33;
            this.button14.Text = "Test Case...";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1019, 24);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(384, 20);
            this.textBox8.TabIndex = 32;
            this.textBox8.Text = "C:\\JIRA\\Test Cases\\FR2\\OLSS-4818.xml";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.Location = new System.Drawing.Point(1019, 442);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox9.Size = new System.Drawing.Size(479, 75);
            this.textBox9.TabIndex = 31;
            this.textBox9.Text = resources.GetString("textBox9.Text");
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1019, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 75);
            this.label3.TabIndex = 30;
            this.label3.Text = "AUU System Information page is open";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1423, 628);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 29;
            this.button15.Text = "S&how";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(1184, 628);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 28;
            this.button16.Text = "&Skip";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(1103, 628);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 27;
            this.button17.Text = "&Failed";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(1022, 628);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 26;
            this.button18.Text = "&Passed";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.Control;
            this.treeView2.Location = new System.Drawing.Point(1019, 83);
            this.treeView2.Name = "treeView2";
            treeNode35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode35.Name = "Node4";
            treeNode35.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode35.Text = "SKIPPED: Installed OLSS and ECM 5.0 Server";
            treeNode36.Name = "Node6";
            treeNode36.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode36.Text = "PASSED: Installed OLSS Client and AUU";
            treeNode37.Name = "Node3";
            treeNode37.Text = "Preconditions";
            treeNode38.Name = "Node9";
            treeNode38.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode38.Text = "PASSED: Internal Authentication";
            treeNode39.Name = "Node10";
            treeNode39.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode39.Text = "PASSED: OLSS user \'user1\' with privileges to login into AUU Web UI";
            treeNode40.Name = "Node8";
            treeNode40.Text = "Data";
            treeNode41.Name = "Node13";
            treeNode41.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode41.Text = "PASSED: AUU Login page with \"User name\" and \"Password\" without \"Domain\"";
            treeNode42.Name = "Node12";
            treeNode42.Text = "1. Navigate to AUU home page";
            treeNode43.Name = "Node15";
            treeNode43.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode43.Text = "FAILED: Password is encrypted";
            treeNode44.Name = "Node14";
            treeNode44.Text = "2. Enter valid credentials of \'user1\' from Data. Here some flood to demonstrate b" +
    "ehavior in case of long text.";
            treeNode45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode45.Name = "Node17";
            treeNode45.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode45.Text = "AUU System Information page is open";
            treeNode46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode46.Name = "Node18";
            treeNode46.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode51});
            this.treeView2.ShowLines = false;
            this.treeView2.ShowPlusMinus = false;
            this.treeView2.ShowRootLines = false;
            this.treeView2.Size = new System.Drawing.Size(480, 340);
            this.treeView2.TabIndex = 25;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 670);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.treeView2);
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
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TreeView treeView2;
    }
}

