using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_NguyenKhacDuyHung
{
	internal class HocVien
	{
		string mahv;
		string hoten;
		string lophoc;
		int sotiet;
		int hocphi = 100;
		/*Phuơng thức không tham số*/
		public HocVien()
		{
			mahv = "";
			hoten = "";
			lophoc = "";
			sotiet = 0;
		}
		/*Phương thức có tham số*/
		public HocVien(string ms, string ht, string lh, int st)
		{
			mahv = ms;
			hoten = ht;
			lophoc = lh;
			sotiet = st;
		}
		/*Nhập*/
		public void Nhap()
		{
			Console.Write("Nhập mã học viên: ");
			mahv = Console.ReadLine();
			Console.Write("Nhập họ tên họ viên: ");
			hoten = Console.ReadLine();
			do
			{
				Console.Write("Nhập lớp học (A,B,C): ");
				lophoc = Console.ReadLine();
			}while (!(lophoc == "A" || lophoc == "B" || lophoc == "C"));
			Console.Write("Nhập số tiết: ");
			sotiet = int.Parse(Console.ReadLine());
		}
		public float TinhTien()
		{
			float tiengiam = 0;
			if (sotiet > 50)
				tiengiam = 0.1f;
			if (sotiet > 30 && sotiet <= 50)
				tiengiam = 0.07f;
			return sotiet * hocphi - tiengiam;
		}
		/*Xuất thông tin*/
		public void Xuat()
		{
			Console.WriteLine("{0,-25} {1,-20} {2,-10} {3,-15}", hoten, lophoc, sotiet, TinhTien());
		}
		/*Toán tử*/
		public static float operator+(HocVien hv, float s)
		{
			return hv.TinhTien() + s;
		}
	}
}
