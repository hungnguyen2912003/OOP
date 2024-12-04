using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_NguyenKhacDuyHung
{
	interface IHocPhi
	{
		float HocPhi { get; set; }
		/*Phương thức tính tiền giảm học phí*/
		float TinhTienGiam();
	}
	class HocVien : IHocPhi, IComparable<HocVien>
	{
		string maso;
		string hoten;
		DateTime ngaysinh;
		string doituong;
		float hocphi;
		public string MaSo 
		{
			get { return maso; }
			set { maso = value; }
		}
		public float HocPhi
		{
			get { return hocphi; }
			set { hocphi = value; }
		}
		public HocVien()
		{
			maso = "";
			hoten = "";
			ngaysinh = DateTime.Now;
			doituong = "";
			hocphi = 0;
		}
		public HocVien(string maso, string hoten, DateTime ngaysinh, string doituong, float hp)
		{
			this.maso = maso;
			this.hoten = hoten;
			this.ngaysinh = ngaysinh;
			this.doituong = doituong;
			this.hocphi = hp;
		}
		public void Nhap()
		{
			Console.Write("Nhập mã số học viên: ");	
			maso = Console.ReadLine();
			Console.Write("Nhập họ tên học viên: ");
			hoten = Console.ReadLine();
			Console.Write("Nhập ngày sinh học viên: ");
			ngaysinh = DateTime.Parse(Console.ReadLine());
			Console.Write("Nhập đối tượng học viên: ");
			doituong = Console.ReadLine();
			Console.Write("Nhập học phí của học viên: ");
			hocphi = float.Parse(Console.ReadLine());
		}
		public float TinhTienGiam()
		{
			float tiengiam = 0;
			if (doituong == "Nghèo" || doituong == "Cận nghèo")
			{
				tiengiam = 85000;
			}
			if (doituong == "Khuyết tật")
			{
				tiengiam = 100000;
			}
			if (doituong == "Mồ côi")
			{
				tiengiam = 135000;
			}
			return tiengiam;
		}
		public float TinhTien()
		{
			if (hocphi == 0)
				return hocphi;
			return hocphi - TinhTienGiam();
		}
		public override string ToString()
		{
			return string.Format($"Mã số: {maso}, Họ tên: {hoten}, Ngày sinh: {ngaysinh.ToString("dd/MM/yyyy")}, Đối tượng: {doituong}, Tiền học phí: {hocphi}");
		}
		public int CompareTo(HocVien hv)
		{
			if (this.TinhTien() < hv.TinhTien()) return 1;
			else if (this.TinhTien() == hv.TinhTien()) return 0;
			else return -1;
		}
	}
	class KhoaHoc:HocVien
	{
		string tenkh;
		int sluong;
		List<HocVien> ls;
		public KhoaHoc()
		{
			tenkh = "";
			sluong = 0;
			ls = new List<HocVien>(0);
		}
		public KhoaHoc(string tenkh)
		{
			this.tenkh = tenkh;
		}
		void ReadFile()
		{
			FileStream f = new FileStream("D:\\HocVien.txt", FileMode.Open, FileAccess.Read);
			StreamReader rd = new StreamReader(f);
			string line;
			sluong = int.Parse(rd.ReadLine());
			Console.WriteLine($"Số lượng học viên: {sluong}");
			while ((line = rd.ReadLine()) != null) 
			{
				string[] item = line.Split(';');
				string maso = item[0];
				string hoten = item[1];
				DateTime ngsinh = DateTime.Parse(item[2]);
				string dt = item[3];
				float hp = float.Parse(item[4]);
				HocVien hv = new HocVien(maso,hoten,ngsinh,dt,hp);
				ls.Add(hv);
			}
		}
		public new void Nhap()
		{
			Console.Write("Nhập khoá học: ");
			tenkh = Console.ReadLine();
			ls = new List<HocVien>();
			ReadFile();
		}
		public void Xuat()
		{
			foreach(HocVien hv in ls)
			{
				Console.WriteLine(hv.ToString());
			}
		}
		public void SapXep()
		{
			ls.Sort();
		}
		/*Tìm học viên có mã số x trong khoá học*/
		public void Find()
		{
			string x;
			Console.Write("Nhập mã số x của học viên cần tìm: ");
			x = Console.ReadLine();
			bool flag = false;
			for(int i = 0; i < ls.Count; i++)
			{
				if (ls[i].MaSo == x)
				{
					Console.WriteLine(ls[i].ToString());
					flag = true;
					break;
				}
			}
			if(!flag)
			{
				Console.WriteLine("Không tìm thấy học viên có mã số {0}", x);
			}
		}
		/*Thêm 1 khoá học*/
		public void Add()
		{
			Console.Write("Nhập mã số học viên: ");
			string maso = Console.ReadLine();
			Console.Write("Nhập họ tên học viên: ");
			string hoten = Console.ReadLine();
			Console.Write("Nhập ngày sinh học viên: ");
			DateTime ngaysinh = DateTime.Parse(Console.ReadLine());
			Console.Write("Nhập đối tượng học viên: ");
			string doituong = Console.ReadLine();
			Console.Write("Nhập học phí của học viên: ");
			float hocphi = float.Parse(Console.ReadLine());
			HocVien hv = new HocVien(maso,hoten,ngaysinh,doituong,hocphi);
			ls.Add(hv);
		}
		/*Xoá tất cả các học viên có tiền học phí là 0*/
		public void Del()
		{
			ls.RemoveAll(hv => hv.HocPhi == 0);
		}
	}
}
