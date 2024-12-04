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
	public partial class Form4 : Form
	{
		List<User> ls;
		int n;
		public Form4()
		{
			InitializeComponent();
		}
		/*Đọc file*/
		void ReadFile()
		{
			try
			{
				FileStream f = new FileStream("D:\\Info\\User.txt", FileMode.Open, FileAccess.Read);
				StreamReader rd = new StreamReader(f);
				string line;
				while((line = rd.ReadLine()) != null)
				{
					string[] item = line.Split(';');
					string u = item[0];
					string n = item[1];
					User user = new User(u,n);
					ls.Add(user);
				}
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		private void Form4_Load(object sender, EventArgs e)
		{
			ls = new List<User>();
			ReadFile();
		}

		private void btnlogin_Click(object sender, EventArgs e)
		{
			User u1 = ls.Find(s => s.UserName == txtusername.Text);
			User u2 = ls.Find(s => s.Pwd == txtpwd.Text);
			/*Thoả username*/
			if (u1 != null)
			{
				/*Thoả password*/
				if (u2 != null)
				{
					MessageBox.Show("Logged in successfully!");
					Close();
				}
				/*Không thoả password*/
				else
				{
					if (MessageBox.Show("Invalid password!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
					{
						txtpwd.Clear();
						txtpwd.Focus();
					}
					else
					{
						Application.Exit();
					}
				}
			}
			/*Không thoả username*/
			else
			{
				if (MessageBox.Show("Invalid username!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					txtusername.Clear();
					txtusername.Focus();
				}
				else
				{
					Application.Exit();
				}
			}
		}
	}
}
