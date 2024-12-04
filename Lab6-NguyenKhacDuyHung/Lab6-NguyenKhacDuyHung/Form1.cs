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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btncong_Click(object sender, EventArgs e)
		{
			float a, b;
			bool chka = float.TryParse(txta.Text, out a);
			if(!chka ) 
			{
				if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					txta.Clear();
					txta.Focus();
				}
			}
			bool chkb = float.TryParse(txtb.Text, out b);
			if(!chkb)
			{
				if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					txtb.Clear();
					txtb.Focus();
				}
			}
			txtkq.Text = (a + b).ToString();
		}

		private void btntru_Click(object sender, EventArgs e)
		{
			float a, b;
			bool chka = float.TryParse(txta.Text, out a);
			if (!chka)
			{
				if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					txta.Clear();
					txta.Focus();
				}
			}
			bool chkb = float.TryParse(txtb.Text, out b);
			if (!chkb)
			{
				if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					txtb.Clear();
					txtb.Focus();
				}
			}
			txtkq.Text = (a - b).ToString();
		}

		private void btnnhan_Click(object sender, EventArgs e)
		{
			float a, b;
			bool chka = float.TryParse(txta.Text, out a);
			if (!chka)
			{
				if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					txta.Clear();
					txta.Focus();
				}
			}
			bool chkb = float.TryParse(txtb.Text, out b);
			if (!chkb)
			{
				if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					txtb.Clear();
					txtb.Focus();
				}
			}
			txtkq.Text = (a * b).ToString();
		}

		private void btnchia_Click(object sender, EventArgs e)
		{
			float a, b;
			bool chka = float.TryParse(txta.Text, out a);
			if (!chka)
			{
				if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					txta.Clear();
					txta.Focus();
				}
			}
			bool chkb = float.TryParse(txtb.Text, out b);
			if (!chkb)
			{
				if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					txtb.Clear();
					txtb.Focus();
				}
			}
			if(b !=  0)
			{
				txtkq.Text = (a / b).ToString();
			}
			else
			{
				txtkq.Text = "Không thể chia cho 0";
			}
		}

		private void btncalc_Click(object sender, EventArgs e)
		{
			txta.Clear();
			txtb.Clear();
			txtkq.Clear();
			txta.Focus();
		}

		private void btnclose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
