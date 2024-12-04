using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1
{
	internal class Xe
	{
		public string dongxe;
		public byte sochongoi;
		public DateTime ngaysx;
		public static int giasan = 400;

		public void Nhap()
		{
			Console.Write("Nhập dòng xe: ");
			dongxe = Console.ReadLine();
			Console.Write("Nhập số chỗ ngồi: ");
			sochongoi = byte.Parse(Console.ReadLine());
			Console.Write("Nhập ngày sản xuất: ");
			ngaysx = DateTime.Parse(Console.ReadLine());
		}
		public float GiaBan()
		{
			if (DateTime.Now.Year - ngaysx.Year > 2)
				return 1.15f * giasan;
			else if (DateTime.Now.Year - ngaysx.Year > 1 && DateTime.Now.Year - ngaysx.Year <= 2)
				return 1.3f * giasan;
			return 1.5f * giasan;
		}
		public void Xuat()
		{
			Console.Write($"Dòng xe: {dongxe}, Số chỗ: {sochongoi}, Ngày sản xuất: {ngaysx}, Giá bán: {GiaBan()}, ");
		}
	}

	interface Phi
	{
		float PhiTruocBa { get; set; }
		float TinhTienPhiTruocBa();
	}

	class XeVinfast : Xe, Phi, IComparable<XeVinfast>
	{
		public string noidangky;
		public float PhiTruocBa { get; set; }
		public new void Nhap()
		{
			base.Nhap();
			Console.Write("Nhập nơi đăng ký: ");
			noidangky = Console.ReadLine();
		}
		public float TinhTienPhiTruocBa() 
		{
			return PhiTruocBa * GiaBan();
		}
		public float GiaLanBanh()
		{
			if (noidangky == "Hà nội")
				return GiaBan() + TinhTienPhiTruocBa() + 0.12f * GiaBan();
			return GiaBan() + TinhTienPhiTruocBa() + 0.1f * GiaBan();
		}
		public new void Xuat()
		{
			base.Xuat();
			Console.WriteLine($"Nơi đăng ký: {noidangky}, Giá lăn bánh: {GiaLanBanh()}");
		}
		public int CompareTo(XeVinfast xe)
		{
			if (this.GiaLanBanh() < xe.GiaLanBanh()) return 1;
			else if (this.GiaLanBanh() == xe.GiaLanBanh()) return 0;
			else return -1;
		}
	}

	class ListXe
	{
		int n;
		List<XeVinfast> ls;
		public void Nhap()
		{
			Console.Write("Nhập số lượng xe (0 < n < 20): ");
			if(!int.TryParse(Console.ReadLine(), out n))
			{
				Console.Write("Số lượng không hợp lệ! Vui lòng nhập lại: ");
			}
			ls = new List<XeVinfast>(n);
			for(int i = 0; i < n; i++)
			{
				Console.WriteLine($"---Nhập thông tin xe thứ {i + 1}---");
				XeVinfast xe = new XeVinfast();
				xe.Nhap();
				ls.Add(xe);
			}
		}
		public void Xuat()
		{
			ls.Sort();
			foreach(XeVinfast xe in ls)
			{
				xe.Xuat();
			}
		}
		public void ThemXe()
		{
			Console.WriteLine("---Nhập thông tin xe cần thêm---");
			XeVinfast xe = new XeVinfast();
			xe.Nhap();
			Console.Write($"Nhập vào vị trí p (0 -> {n}): ");
			int p = int.Parse(Console.ReadLine());
			if(p >= 0 && p <= n)
			{
				ls.Insert(p, xe);
			}
			else if(p < 0)
			{
				ls.Insert(0, xe);
			}
			else
			{
				ls.Add(xe);
			}
		}

		public void Xoa()
		{
			Console.Write("Nhập dòng xe cần xoá: ");
			string x = Console.ReadLine();
			for(int i = 0; i < ls.Count; i++) 
			{
				if (ls[i].dongxe == x)
				{
					ls.Remove(ls[i]);
				}
			}
		}
	}
}
