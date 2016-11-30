using ScreenshotMaker.BLL;
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

namespace ScreenshotMaker.PrL
{
	public partial class FormMain : Form, IView
	{
//        IPresenter presenter;
		public FormMain(IPresenter presenter)
		{
			InitializeComponent();

			presenter.SetView(this);

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
		}

		private void button14_Click(object sender, EventArgs e)
		{
			//var serializer = new XmlSerializer(typeof(Xml2TestCaseDTO.rss));
			//string[] files = new string[] {
			//"C:\\proj\\shotmaker\\task\\examples of input\\OLSS-4818.xml",
			//"C:\\proj\\shotmaker\\task\\examples of input\\test case.xml",
			//"C:\\proj\\shotmaker\\task\\examples of input\\test1.xml",
			//"C:\\proj\\shotmaker\\task\\examples of input\\test2.xml",
			//"C:\\proj\\shotmaker\\task\\examples of input\\test3.xml",
			//"C:\\proj\\shotmaker\\task\\examples of input\\test4.xml",
			//"C:\\proj\\shotmaker\\task\\examples of input\\test5.xml"
			//};
			//foreach (string s in files)
			//{ 
			//    var xml = XmlReader.Create(s/*openFileDialog1.FileName*/);
			//    var dto = serializer.Deserialize(xml) as Xml2TestCaseDTO.rss;
			//    MessageBox.Show(dto.channel.item.title.ToString());
			//}
		}

		public void UpdateElement(string item)
		{
			throw new NotImplementedException();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		public string GetTestExecutionName()
		{
			throw new NotImplementedException();
		}

		public string GetOuputFolderPath()
		{
			throw new NotImplementedException();
		}

		public void ShowMessage(string message)
		{
			throw new NotImplementedException();
		}

		public void RefreshTreeStructure()
		{
			throw new NotImplementedException();
		}

		public string GetInputFileName()
		{
			throw new NotImplementedException();
		}

		//public void Reload(IModelDTO dto)
		//{
		//    throw new NotImplementedException();
		//}
	}
}