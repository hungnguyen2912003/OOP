using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_NguyenKhacDuyHung
{
	internal class User
	{
		string user_name;
		string password;
		public string UserName
		{
			get { return user_name; }
			set { user_name = value; }
		}
		public string Pwd
		{
			get { return password; }
			set { password = value; }
		}
		public User(string user = "", string pwd = "")
		{
			user_name = user;
			password = pwd;
		}
	}
}
