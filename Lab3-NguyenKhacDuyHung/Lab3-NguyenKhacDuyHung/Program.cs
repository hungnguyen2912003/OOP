using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_NguyenKhacDuyHung
{ 
	internal class Program
	{
		static void BT3_1()
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			PhanSo ps1 = new PhanSo();
			Console.Write("Nhập tử số: ");
			int ts = int.Parse(Console.ReadLine());
			Console.Write("Nhập mẫu số: ");
			int ms = int.Parse(Console.ReadLine());
			PhanSo ps2 = new PhanSo(ts, ms);
			PhanSo ps3 = new PhanSo(ps2);
			PhanSo kq = new PhanSo();
			Console.WriteLine($"Hai phân số là: ");
			ps1.Xuatps();
			ps2.Xuatps();
			Console.WriteLine("Cộng, trừ, nhân chia hai phân số sử dụng phương thức lần lượt là: ");
			kq = ps1.Cong(ps2);
			kq = kq.Rutgon();
			kq.Xuatps();
			PhanSo kq2 = new PhanSo();
			kq2 = ps1.Tru(ps2);
			kq2 = kq2.Rutgon();
			kq2.Xuatps();
			PhanSo kq3 = new PhanSo();
			kq3 = ps1.Nhan(ps2);
			kq3 = kq3.Rutgon();
			kq3.Xuatps();
			PhanSo kq4 = new PhanSo();
			kq4 = ps1.Chia(ps2);
			kq4 = kq4.Rutgon();
			kq4.Xuatps();
			PhanSo cong = new PhanSo();
			Console.WriteLine("Cộng, trừ, nhân chia hai phân số sử dụng toán tử lần lượt là: ");
			cong = ps1+ps2;
			cong = cong.Rutgon();
			cong.Xuatps();
			PhanSo tru = new PhanSo();
			tru = ps1-ps2;
			tru = tru.Rutgon();
			tru.Xuatps();
			PhanSo nhan = new PhanSo();
			nhan = ps1*ps2;
			nhan = nhan.Rutgon();
			nhan.Xuatps();
			PhanSo chia = new PhanSo();
			chia = ps1.Chia(ps2);
			chia = chia.Rutgon();
			chia.Xuatps();
		}
		static void BT3_2()
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			VeMayBay[] ds;
			int n;
			do
			{
				Console.Write("Nhập số lượng vé máy bay: ");
				n = int.Parse(Console.ReadLine());
			} while (n < 2 || n > 20);
			ds = new VeMayBay[n];
			/*Nhập vào n vé*/
			for(int i = 0; i < n; i++)
			{
				Console.WriteLine("---Nhập thông tin của người thứ {0}---", i + 1);
				ds[i] = new VeMayBay();
				ds[i].Nhap();
			}
			/*In ra vé máy bay giảm dần*/
				/*Sắp xếp giảm dần*/
			for(int i = 0; i < n; i++)
				for(int j = i + 1; j < n; j++)
					if (ds[i] < ds[j])	/*Không sử dụng toán tử: ds[i].TinhTien() < ds[j].TinhTien()*/
					{
						VeMayBay temp = new VeMayBay();
						temp = ds[i];
						ds[i] = ds[j];
						ds[j] = temp;
					}
				/*In ra*/
			foreach (VeMayBay ve in ds)
				ve.Xuat();
			/*Tính tổng tiền vé*/
			float s = 0;
			foreach (VeMayBay ve in ds)
				s = s + ve;             /*Không sử dụng toán tử: s + ve.TinhTien();*/
			Console.WriteLine("Tiền vé trung bình: {0}", s/n);
			/*Đếm số lượng loại vé Bussiness*/
			int count = 0;
			foreach (VeMayBay ve in ds)
				if (ve.LoaiVe == "Bussiness")
					count++;
			Console.WriteLine("Số lượng loại vé Bussiness: {0}", count);
		}
		static void BT3_3()
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			HocPhiHoaDon hd = new HocPhiHoaDon();
			Console.WriteLine("-----Nhập 1 hoá đơn học phí-----");
			hd.Nhap();
			Console.WriteLine("-----Thông tin hoá đơn vừa nhập-----");
			hd.Xuat();
			Console.WriteLine("Tổng số tín chỉ thực hành: {0}", hd.TongTC_TH());
		}
		static void BT3_4()
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			Time t1 = new Time();
			++t1;
			t1.Xuat();
			Console.WriteLine("-----Nhập thời gian thứ 2-----");
			Console.Write("Nhập số giờ: ");
			int hour = int.Parse(Console.ReadLine());
			Console.Write("Nhập số phút: ");
			int minute = int.Parse(Console.ReadLine());
			Console.Write("Nhập số giây: ");
			int second = int.Parse(Console.ReadLine());
			Time t2 = new Time(hour, minute, second);
			--t2;
			t2.Xuat();
			Console.Write("Nhập số giây cần cộng thêm cho t1: ");
			int s = int.Parse(Console.ReadLine());
			Time kq = t1 + s;
			kq.Xuat();
		}
		static void BT3_5()
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			int n;
			do
			{
				Console.Write("Nhập số lượng học viên của một khoá (2<n<30): ");
				n = int.Parse(Console.ReadLine());
			} while (n < 2 || n > 30);
			HocVien[] dshv = new HocVien[n];
			for(int i = 0; i < n; i++)
			{
				Console.WriteLine("-----Nhập thông tin của học viên thứ {0}-----", i + 1);
				dshv[i] = new HocVien();
				dshv[i].Nhap();
			}
			Console.WriteLine("-----Thông tin các học viên-----");
			Console.WriteLine("{0,-25} {1,-20} {2,-10} {3,-15}", "Tên học viên", "Lớp học", "Số tiết", "Tiền học phí");
			foreach ( HocVien hv in dshv)
			{
				hv.Xuat();
			}
			float s = 0;
			foreach (HocVien hv in dshv)
				s = s + hv.TinhTien();
			Console.WriteLine("Tổng số tiền học phí của {0} học viên: {1}", n, s);
			
		}
		static void BT3_6()
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			/*
			Bill b = new Bill();
			Console.Write($"{b.Cal_Bill()}");
			*/
			Console.WriteLine("Câu a trả về kết quả 9.5 (Đúng)");
			/*
			Bill b = new Bill();
			Console.Write($"{b.price}");
			*/
			Console.WriteLine("Câu b lỗi do thuộc tính price đang là thuộc tính tĩnh nên không thể truy cập");
			/*
			Bill b = new Bill("Acer", 1, 7.5f);
			b.Print ();
			*/
			Console.WriteLine("Câu c trả về kết quả của Phương thức Print (Đúng như dữ liệu của phương thức có tham số)");
			/*
			Bill b1 = new Bill();
            Bill b2 = new Bill("Acer", 1, 7.5f);
            b1.Print ();
			*/
			Console.WriteLine("Câu d trả về kết quả của Phương thức Print (Đúng như dữ liệu của phương thức không tham số)");
		}
		static void Main(string[] args)
		{
			BT3_6();
			Console.ReadKey();
		}
	}
}
