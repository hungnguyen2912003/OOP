using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tuan7_NguyenKhacDuyHung
{
	internal class CanBo
	{
		string maso;
		string hoten;
		string gtinh;
		public string MaSo
		{
			get { return maso; }
			set { maso = value; }
		}
		public string Hoten
		{
			get {return hoten;}
			set { hoten = value; }
		}
		public CanBo()
		{
			maso = "";
			hoten = "";
			gtinh = "";
		}
		public void Nhap()
		{
			Console.Write("Nhập mã số: ");
			maso = Console.ReadLine();
			Console.Write("Nhập họ tên: ");
			hoten = Console.ReadLine();
			Console.Write("Nhập giới tính: ");
			gtinh = Console.ReadLine();
		}
	}
}
