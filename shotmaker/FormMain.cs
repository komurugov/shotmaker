using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shotmaker
{
    public partial class FormMain : Form, IDomainView
    {
        IPresenter presenter;
        public FormMain()
        {
            InitializeComponent();


            presenter = new ShotmakerPresenter(this as IDomainView);            

            treeView2.ExpandAll();
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Screenshotable s = treeView1.SelectedNode.Tag as Screenshotable;            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            var selectedItem = (IModelDTO)treeView2.SelectedNode.Tag;

            presenter.DoPass(selectedItem);
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            presenter.LoadFile("Path");           
        }

        public void UpdateElement(string item)
        {
            throw new NotImplementedException();
        }

        public void Reload(IModelDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
