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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(488, 103);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(90, 23);
			this.button13.TabIndex = 35;
			this.button13.Text = "Choose...";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(182, 103);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(300, 20);
			this.textBox7.TabIndex = 34;
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(488, 77);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(90, 23);
			this.button14.TabIndex = 33;
			this.button14.Text = "Choose...";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.button14_Click);
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(182, 77);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(300, 20);
			this.textBox8.TabIndex = 32;
			// 
			// textBox9
			// 
			this.textBox9.BackColor = System.Drawing.SystemColors.Control;
			this.textBox9.Location = new System.Drawing.Point(98, 502);
			this.textBox9.Multiline = true;
			this.textBox9.Name = "textBox9";
			this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox9.Size = new System.Drawing.Size(479, 75);
			this.textBox9.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(98, 586);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(479, 75);
			this.label3.TabIndex = 30;
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button15
			// 
			this.button15.Enabled = false;
			this.button15.Location = new System.Drawing.Point(502, 688);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(75, 23);
			this.button15.TabIndex = 29;
			this.button15.Text = "S&how";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.button15_Click);
			// 
			// button16
			// 
			this.button16.Enabled = false;
			this.button16.Location = new System.Drawing.Point(263, 688);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(75, 23);
			this.button16.TabIndex = 28;
			this.button16.Text = "&Skip";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.button16_Click);
			// 
			// button17
			// 
			this.button17.Enabled = false;
			this.button17.Location = new System.Drawing.Point(182, 688);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(75, 23);
			this.button17.TabIndex = 27;
			this.button17.Text = "&Failed";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.button17_Click);
			// 
			// button18
			// 
			this.button18.Enabled = false;
			this.button18.Location = new System.Drawing.Point(101, 688);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(75, 23);
			this.button18.TabIndex = 26;
			this.button18.Text = "&Passed";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.button18_Click);
			// 
			// treeView2
			// 
			this.treeView2.BackColor = System.Drawing.SystemColors.Window;
			this.treeView2.FullRowSelect = true;
			this.treeView2.HideSelection = false;
			this.treeView2.Location = new System.Drawing.Point(98, 143);
			this.treeView2.Name = "treeView2";
			this.treeView2.ShowLines = false;
			this.treeView2.ShowNodeToolTips = true;
			this.treeView2.ShowPlusMinus = false;
			this.treeView2.ShowRootLines = false;
			this.treeView2.Size = new System.Drawing.Size(480, 340);
			this.treeView2.TabIndex = 25;
			this.treeView2.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView2_BeforeSelect);
			this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(182, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(300, 20);
			this.textBox1.TabIndex = 36;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(98, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 37;
			this.label1.Text = "Test Execution:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(675, 143);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(630, 458);
			this.richTextBox1.TabIndex = 38;
			this.richTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(98, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 39;
			this.label2.Text = "Test Case:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(98, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 40;
			this.label4.Text = "Output folder:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(952, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 41;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1046, 80);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 42;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1350, 735);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

