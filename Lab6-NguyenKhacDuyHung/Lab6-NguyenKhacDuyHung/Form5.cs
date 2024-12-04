using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_NguyenKhacDuyHung
{
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form4 form4 = new Form4();
			form4.ShowDialog();
		}

		private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void bài61ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			form1.ShowDialog();
		}

		private void bài62ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.ShowDialog();
		}

		private void bài64ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.ShowDialog();
		}
	}
}
