using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BT_Ngay10._4._2023_NguyenKhacDuyHung
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			DS_Phone ds = new DS_Phone();
			ds.SapXep();
			Console.WriteLine("\t\t\tDanh sách thông tin điện thoại từ FILE\n");
			Console.WriteLine("{0,-15} {1,-25} {2,-15} {3,-15} {4,-20}", "Mã số", "Tên điện thoại", "RAM", "Bộ nhớ", "Giá thành");
			ds.Xuat();
			Console.ReadKey();
		}
	}
}
