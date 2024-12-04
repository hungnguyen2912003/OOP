using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_NguyenKhacDuyHung
{
	internal class HocPhan
	{
		string mahp;
		string tenhp;
		int sotc;
		static int hocphi = 250;
		int sotc_th;
		public int SoTCTH
		{
			get { return sotc_th; }
			set { sotc_th = value; }
		}
		/*Phương thức không tham số*/
		public HocPhan()
		{
			mahp = "";
			tenhp = "";
			sotc = 0;
			sotc_th = 0;
		}
		/*Phương thức có tham số*/
		public HocPhan(string ma, string ten, int tc, int th)
		{
			mahp = ma;
			tenhp = ten;
			sotc = tc;
			sotc_th = th;
		}
		/*Nhập*/
		public void Nhap()
		{
			Console.Write("Nhập mã học phần: ");
			mahp = Console.ReadLine();
			Console.Write("Nhập tên học phần: ");
			tenhp = Console.ReadLine();
			Console.Write("Số tín chỉ: ");
			sotc = int.Parse(Console.ReadLine());
			Console.Write("Số tín chỉ thực hành: ");
			sotc_th = int.Parse(Console.ReadLine());
		}
		/*Tính tiền học phí*/
		public float TinhTien()
		{
			return sotc_th * hocphi * 1.5f + (sotc - sotc_th) * hocphi;
		}
		/*Xuất thông tin học phần (mã học phần, tên học phần, số tín chỉ, tiền học phí)*/
		public void Xuat()
		{
			Console.WriteLine("{0,-15} {1,-25} {2,-15} {3,-15}", "Mã học phần", "Tên học phần", "Số tín chỉ", "Tiền học phí");
			Console.WriteLine("{0,-15} {1,-25} {2,-15} {3,-15}", mahp, tenhp, sotc, TinhTien());
		}

		/*Toán tử*/

		public static float operator +(float s, HocPhan hp)
		{
			return s + hp.TinhTien();
		}
	}
	class HocPhiHoaDon
	{
		string mssv;
		string hoten;
		HocPhan[] ds;
		int n;
		/*Phương thức không tham số*/
		public HocPhiHoaDon()
		{
			mssv = "";
			hoten = "";
			ds = new HocPhan[0];
		}
		/*Phương thức có tham số*/
		public HocPhiHoaDon(string ms, string ht, HocPhan[] dshp)
		{
			mssv = ms;
			hoten = ht;
			ds = dshp;
		}
		public void Nhap()
		{
			Console.Write("Nhập mã số sinh viên: ");
			mssv = Console.ReadLine();
			Console.Write("Nhập tên sinh viên: ");
			hoten = Console.ReadLine();
			do
			{
				Console.Write("Nhập số lượng học phần đăng ký (2-9 học phần/học kỳ): ");
				n = int.Parse(Console.ReadLine());
			} while (n < 2 || n > 9);
			ds = new HocPhan[n];
			for(int i = 0; i < n; i++) 
			{
				Console.WriteLine("Nhập thông tin học phần thứ {0}", i + 1);
				HocPhan dshp = new HocPhan();
				dshp.Nhap();
				ds[i] = dshp;
			}
		}
		float TongTien()
		{
			float s = 0;
			foreach (HocPhan hp in ds)
			{
				s = s + hp.TinhTien();
			}
			return s;
		}
		/*Xuất*/
		public void Xuat()
		{
			Console.WriteLine("{0,-10} {1,-25}", "Mã số", "Họ tên");
			Console.WriteLine("{0,-10} {1,-25}", mssv, hoten);
			Console.WriteLine("Danh sách các học phần: ");
			foreach (HocPhan hp in ds)
				hp.Xuat();
			Console.WriteLine("Tổng học phí: {0}", TongTien());
		}
		/*Tính tổng tín chỉ thực hành*/
		public int TongTC_TH()
		{
			int s = 0;
			foreach(HocPhan hp in ds)
			{
				s += hp.SoTCTH;
			}
			return s;
		}
	}
}
