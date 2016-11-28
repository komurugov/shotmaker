using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace shotmaker
{
    public partial class FormMain : Form/*, IDomainView*/
    {
//        IPresenter presenter;
        public FormMain()
        {
            InitializeComponent();


//            presenter = new ShotmakerPresenter(this as IDomainView);            

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
            //Screenshotable s = treeView1.SelectedNode.Tag as Screenshotable;            
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

//          presenter.DoPass(selectedItem);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //            presenter.LoadFile("Path");           
            var serializer = new XmlSerializer(typeof(test1DTO.rss));
            //            var xml = XmlReader.Create("C:\\proj\\shotmaker\\task\\test case.xml");
            //            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            string[] files = new string[] {
            "C:\\proj\\shotmaker\\task\\examples of input\\OLSS-4818.xml",
            "C:\\proj\\shotmaker\\task\\examples of input\\test case.xml",
            "C:\\proj\\shotmaker\\task\\examples of input\\test1.xml",
            "C:\\proj\\shotmaker\\task\\examples of input\\test2.xml",
            "C:\\proj\\shotmaker\\task\\examples of input\\test3.xml",
            "C:\\proj\\shotmaker\\task\\examples of input\\test4.xml",
            "C:\\proj\\shotmaker\\task\\examples of input\\test5.xml"
            };
            foreach (string s in files)
            { 

                var xml = XmlReader.Create(s/*openFileDialog1.FileName*/);

                var dto = serializer.Deserialize(xml) as test1DTO.rss;

                MessageBox.Show(dto.channel.item.title.ToString());
            }
        }

        public void UpdateElement(string item)
        {
            throw new NotImplementedException();
        }

        //public void Reload(IModelDTO dto)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
