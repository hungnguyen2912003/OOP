using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_NguyenKhacDuyHung
{
	public partial class Form3 : Form
	{
		List<Phone> ls;
		string pic;
		public Form3()
		{
			InitializeComponent();
		}
	/*Đọc file*/
		void ReadFile()
		{
			try
			{
				FileStream f = new FileStream("D:\\Info\\Phone.txt", FileMode.Open, FileAccess.Read);
				StreamReader rd = new StreamReader(f);
				string line;
				while ((line = rd.ReadLine()) != null)
				{
					string[] item = line.Split(';');
					string id = item[0];
					string name = item[1];
					float price = float.Parse(item[2]);
					string pic = item[3];
					Phone phone = new Phone(id, name, price, pic);
					ls.Add(phone);
				}
			}
			catch(Exception e){
				Console.WriteLine(e.Message);
			}
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			ls = new List<Phone>();
			ReadFile();
			dgvDSDT.DataSource = ls;
		}

		private void btnadd_Click(object sender, EventArgs e)
		{
			string id = txtmaso.Text;
			string name = cmbhieu.Text;
			float gianhap = float.Parse(txtgianhap.Text);
			Phone phone = new Phone(id, name, gianhap, pic);
			ls.Add(phone);
			dgvDSDT.DataSource = null;
			dgvDSDT.DataSource = ls;
		}

		private void picPhone_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image file|*.png";
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				pic = ofd.FileName;
				picPhone.Image = Image.FromFile(pic);
			}
		}

		private void btndel_Click(object sender, EventArgs e)
		{
			int i;
			for(i = 0; i < ls.Count; i++)
				if (txtmaso.Text == ls[i].ID)
					break;
			if(i < ls.Count)
			{
				ls.RemoveAt(i);
				txtmaso.Clear();
				dgvDSDT.DataSource = null;
				dgvDSDT.DataSource= ls;
			}
		}

		private void btnprice_Click(object sender, EventArgs e)
		{
			Phone ph = ls.Find(p =>  p.ID == txtmaso.Text);
			if(ph != null)
			{
				txtgiaban.Text = ph.GiaBan().ToString();
			}
		}

		private void btnsort_Click(object sender, EventArgs e)
		{
			ls.Sort();
			dgvDSDT.DataSource = null;
			dgvDSDT.DataSource = ls;
		}

		private void btnclose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
