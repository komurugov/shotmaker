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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(488, 47);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 23);
            this.button13.TabIndex = 35;
            this.button13.Text = "Output folder...";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(98, 47);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(384, 20);
            this.textBox7.TabIndex = 34;
            this.textBox7.Text = "C:\\Test Reports\\FR2";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(488, 21);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 23);
            this.button14.TabIndex = 33;
            this.button14.Text = "Test Case...";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(98, 21);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(384, 20);
            this.textBox8.TabIndex = 32;
            this.textBox8.Text = "C:\\JIRA\\Test Cases\\FR2\\OLSS-4818.xml";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.Location = new System.Drawing.Point(98, 439);
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
            this.label3.Location = new System.Drawing.Point(98, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 75);
            this.label3.TabIndex = 30;
            this.label3.Text = "AUU System Information page is open";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(502, 625);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 29;
            this.button15.Text = "S&how";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(263, 625);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 28;
            this.button16.Text = "&Skip";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(182, 625);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 27;
            this.button17.Text = "&Failed";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(101, 625);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 26;
            this.button18.Text = "&Passed";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.Control;
            this.treeView2.Location = new System.Drawing.Point(98, 80);
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
            this.ClientSize = new System.Drawing.Size(674, 670);
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
            this.Name = "FormMain";
            this.Text = "QA Screenshot Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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

