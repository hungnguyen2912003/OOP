using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tuan7_NguyenKhacDuyHung
{
	internal class NhanVienHanhChinh: CanBo
	{
		int songaycong;
		double luongthang;
		public NhanVienHanhChinh() : base()
		{
			songaycong = 0;
			luongthang = 0;
		}
		public new void Nhap()
		{
			base.Nhap();

			Console.Write("Nhập số ngày công: ");
			songaycong = int.Parse(Console.ReadLine());

			Console.Write("Nhập lương tháng: ");
			luongthang = double.Parse(Console.ReadLine());
		}
		public double TienLuong()
		{
			return songaycong * luongthang / 26;
		}
	}
}
