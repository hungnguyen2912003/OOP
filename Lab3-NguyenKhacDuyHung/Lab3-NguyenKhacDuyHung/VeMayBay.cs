using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_NguyenKhacDuyHung
{
	internal class VeMayBay
	{
		string mave, hoten, loaive;
		DateTime ngaymua, ngaykh;
		static int giasan = 500;
		public string LoaiVe { get { return loaive; } set { loaive = value; } }
		/*Phương thức không tham số*/
		public VeMayBay()
		{
			mave = "VN0234";
			hoten = "N.V.An";
			ngaymua = DateTime.Now;
			ngaykh = new DateTime(2023, 5, 1);
			loaive = "First";
		}
		/*Phương thức tham số*/
		public VeMayBay(string ma, string ht, string loai, DateTime mua, DateTime kh)
		{
			mave = ma;
			hoten = ht;
			ngaymua = mua;
			ngaykh = kh;
			loaive = loai;
		}
		/*Nhập*/
		public void Nhap()
		{
			Console.Write("Nhập mã vé: ");
			mave = Console.ReadLine();
			Console.Write("Nhập họ tên: ");
			hoten = Console.ReadLine();
			Console.Write("Nhập loại vé (First, Bussiness, ...): ");
			loaive = Console.ReadLine();
			Console.Write("Ngày mua: ");
			ngaymua = DateTime.Parse(Console.ReadLine());
			Console.Write("Ngày khởi hành: ");
			ngaykh = DateTime.Parse(Console.ReadLine());
		}
		/*Phương thức tính tiền vé*/
		public float TinhTien()
		{
			float gia = giasan;
			if (loaive == "First")
				gia = 3 * giasan;
			else if (loaive == "Bussiness")
				gia = 2 * giasan;
			else if (loaive == "Premium")
				gia = 1.5f * giasan;
			int t = (ngaykh - ngaymua).Days;    /*Số ngày*/
			return 0.5f / 100 * t * gia * 1.1f;
		}

		/*Xuất vé*/
		public void Xuat()
		{
			Console.WriteLine($"{mave}\t{hoten}\t{ngaykh.ToShortDateString()}\t{loaive}\t{TinhTien()}");
		}

		/*Toán tử*/
		public static float operator+( float s, VeMayBay ve)
		{
			return s + ve.TinhTien();
		}
		public static bool operator <(VeMayBay v1, VeMayBay v2)
		{ 
			return v1.TinhTien() < v2.TinhTien();
		}
		public static bool operator >(VeMayBay v1, VeMayBay v2)
		{
			return v1.TinhTien() > v2.TinhTien();
		}
	}
}
