using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_NguyenKhacDuyHung
{
	internal class MonHoc
	{
		string mamh;
		string tenmh;
		int dvht;
		float tlkt;
		float dkt;
		float tlgk;
		float dgk;
		float diemthi;
		public int SoTC
		{
			get { return dvht; } set { dvht = value; }
		}
		public float DiemThi
		{
			get { return diemthi; } set { diemthi = value;}
		}
		public MonHoc()
		{
			mamh = "";
			tenmh = "";
			dvht = 0;
			tlkt = 0;
			dkt = 0;
			tlgk = 0;
			dgk = 0;
			diemthi = 0;
		}
		public MonHoc(string mamh, string tenmh, int dvht, float tlkt, float dkt, float tlgk, float dgk, float diemthi)
		{
			this.mamh = mamh;
			this.tenmh = tenmh;
			this.dvht = dvht;
			this.tlkt = tlkt;
			this.dkt = dkt;
			this.tlgk = tlgk;
			this.dgk = dgk;
			this.diemthi = diemthi;
		}
		public void Nhap()
		{
			Console.Write("Nhập mã môn học: ");
			mamh = Console.ReadLine();
			Console.Write("Nhập tên môn học");
			tenmh = Console.ReadLine();
			Console.Write("Nhập số đơn vị học trình: ");
			dvht = int.Parse(Console.ReadLine());
			Console.Write("Nhập tỷ lệ kiểm tra: ");
			tlkt= float.Parse(Console.ReadLine());
			Console.Write("Nhập điểm kiểm tra: ");
			dkt = float.Parse(Console.ReadLine());
			Console.Write("Nhập tỷ lệ thi giữa kỳ: ");
			tlgk = float.Parse(Console.ReadLine());
			Console.Write("Nhập điểm thi giữa kỳ: ");
			dgk = float.Parse(Console.ReadLine()) ;
			Console.Write("Nhập điểm thi: ");
			diemthi = float.Parse(Console.ReadLine()) ;
		}
		public float TrungBinh()
		{
			return tlkt * dkt + tlgk * dgk + (1 - tlkt - tlgk) * diemthi;
		}
		public void Xuat()
		{
			Console.WriteLine("{0,-25} {1,-20} {2,-20} {3,-20} {4,-20}", tenmh, dkt, dgk, diemthi, TrungBinh());
		}
		/*Kiểm tra dữ liệu đọc từ file*/
		public void Xuat_File()
		{
			Console.WriteLine("{0,-15} {1,-30} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15} {7,-15}", mamh, tenmh, dvht, tlkt, dkt, tlgk, dgk, diemthi);
		}
	}
	class SinhVien:MonHoc
	{
		string id;
		string hoten;
		List<MonHoc> ls;
		public SinhVien():base()
		{
			id = "";
			hoten = "";
			ls = new List<MonHoc>(0);
		}
		void ReadFile()
		{
			FileStream f = new FileStream("D:\\MonHoc.txt", FileMode.Open, FileAccess.Read);
			StreamReader rd = new StreamReader(f);
			/*Lưu dữ liệu đọc ừng dòng từ File ra chương trình*/
			string line;
			while ((line = rd.ReadLine()) != null)
			{
				string[] item = line.Split(';');
				string id = item[0];
				string hoten = item[1];
				int dvht = int.Parse(item[2]);
				float tlkt = float.Parse(item[3]);
				float dkt = float.Parse(item[4]);
				float tlgk = float.Parse(item[5]);
				float dgk = float.Parse(item[6]);
				float dt = float.Parse(item[7]);
				MonHoc mh = new MonHoc(id, hoten, dvht, tlkt, dkt, tlgk, dgk, dt);
				ls.Add(mh);
			}
		}
		public new void Nhap()
		{
			Console.Write("Nhập mssv: ");
			id = Console.ReadLine();
			Console.Write("Nhập họ tên sinh viên: ");
			hoten = Console.ReadLine();
			/*Nhập danh sách môn học*/
			ls = new List<MonHoc>();
			/*Nhập danh sách môn học: đọc dữ liệu từ File*/
			ReadFile();
		}
		/*Tính điểm trung bình học kỳ*/
		public float TBHK()
		{
			float s = 0;
			int tc = 0;
			foreach(MonHoc mh in ls)
			{
				s = s + mh.TrungBinh() * mh.SoTC;
				tc = tc + mh.SoTC;
			}
			return s / tc;
		}
		/*Xem xét đủ điều kiện học bổng*/
		bool KiemTra()
		{
			foreach(MonHoc mh in ls)
			{
				if (mh.TrungBinh() < 5.5f || mh.DiemThi < 5.5)
					return false;
			}
			return true;
		}
		public bool XetHB()
		{
			if(TBHK() > 7 && KiemTra())
				return true;
			return false;
		}
		/*Xuất*/
		public new void Xuat()
		{
			Console.WriteLine("{0,-20} {1, -25}", "Mã số sinh viên", "Họ tên");
			Console.WriteLine("{0,-20} {1, -25}", id, hoten);
			Console.WriteLine("Danh sách các môn học");
			Console.WriteLine("{0,-15} {1,-30} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15} {7,-15}", "Mã môn học", "Tên môn học", "Số tín chỉ", "Tỉ lệ kiểm tra", "Điểm kiểm tra", "Tỉ lệ giữa kỳ", "Điểm giữa kỳ", "Điểm thi");
			foreach (MonHoc mh in ls)
			{
				mh.Xuat_File();
			}
			Console.WriteLine($"Trung bình học kỳ: {TBHK()}");
		}
	}
}
