using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tuan7_NguyenKhacDuyHung
{
	internal class GiaoVien : CanBo
	{
		int sotiet;
		double thulao;
		public GiaoVien():base()
		{
			sotiet = 0; thulao = 0;
		}
		public new void Nhap()
		{
			base.Nhap();
			Console.Write("Nhập số tiết: ");
			sotiet = int.Parse(Console.ReadLine());
			Console.Write("Nhập thù lao 1 tiết: ");
			thulao = double.Parse(Console.ReadLine());
		}
		public double TienLuong()
		{
			return sotiet * thulao;
		}
	}
}
