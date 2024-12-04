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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void radio2_CheckedChanged(object sender, EventArgs e)
		{
			if(radio2.Checked)
			{
				txtc.Enabled = true;
			}
			else
			{
				txtc.Enabled = false;
			}
		}

		private void btngiai_Click(object sender, EventArgs e)
		{
			float a, b, c;
			if(radio1.Checked)
			{
				a = float.Parse(txta.Text);
				b = float.Parse(txtb.Text);
				PTB1 pt1 = new PTB1(a, b);
				txtkq.Text = pt1.Giai_WF();
			}
			if (radio2.Checked)
			{
				a = float.Parse(txta.Text);
				b = float.Parse(txtb.Text);
				c = float.Parse(txtc.Text);
				PTB2 pt2 = new PTB2(a, b, c);
				txtkq.Text = pt2.Giai_WF();
			}
		}

		private void btnclose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
