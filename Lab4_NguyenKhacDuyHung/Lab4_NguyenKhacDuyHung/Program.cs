using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4_NguyenKhacDuyHung
{
	internal class Program
	{
		static void BT4_1()
		{
			PTB1 pt1 = new PTB1();
			pt1.Nhap();
			pt1.Xuat();
			pt1.Giai();
			Console.WriteLine("Nhap vao he so  a,b,c cho PTB2:");
			float a = float.Parse(Console.ReadLine());
			float b = float.Parse(Console.ReadLine());
			float c = float.Parse(Console.ReadLine());
			PTB2 pt2 = new PTB2(a,b,c);
			pt2.Xuat();
			pt2.Giai();
		}
		static void BT4_2()
		{
			ListSmartPhone ds = new ListSmartPhone();
			ds.Input();
			Console.WriteLine("---------------------------------------------------------------------------------------------------");
			Console.WriteLine("Danh sách Smartphone");
			Console.WriteLine("{0,-15} {1,-20} {2,-15} {3,-20}	{4,-15}", "Mã số", "Nhãn hiệu", "Giá", "Năm sản xuất", "Dung lượng");
			ds.Print();
			Console.WriteLine("---------------------------------------------------------------------------------------------------");
			ds.Add();
			Console.WriteLine("Danh sách Smartphone sau khi thêm: ");
			Console.WriteLine("{0,-15} {1,-20} {2,-15} {3,-20}	{4,-15}", "Mã số", "Nhãn hiệu", "Giá", "Năm sản xuất", "Dung lượng");
			ds.Print();
			Console.WriteLine("---------------------------------------------------------------------------------------------------");
			ds.Delete();
			Console.WriteLine("Danh sách Smartphone sau khi xoá có năm bằng năm hiện tại ({0}): ", DateTime.Now.Year);
			Console.WriteLine("{0,-15} {1,-20} {2,-15} {3,-20}	{4,-15}", "Mã số", "Nhãn hiệu", "Giá", "Năm sản xuất", "Dung lượng");
			ds.Print();
			Console.WriteLine("---------------------------------------------------------------------------------------------------");
			ds.Sort();
			Console.WriteLine("Danh sách Smartphone sau khi sắp xếp giảm dần theo giá: ");
			Console.WriteLine("{0,-15} {1,-20} {2,-15} {3,-20}	{4,-15}", "Mã số", "Nhãn hiệu", "Giá", "Năm sản xuất", "Dung lượng");
			ds.Print();
		}
		static void BT4_3()
		{
			Shape[] ds;
			int n;
			do
			{
				Console.Write("Nhập số lượng hình (2 <= n <= 20): ");
				n = int.Parse(Console.ReadLine());
			} while (n < 2 || n > 20);
			ds = new Shape[n];
			int loaihinh;
			for(int i = 0; i < n; i++)
			{
				Console.Write("Nhập loại hình thứ {0} (1-Tam Giác; 2-Hình Chữ Nhật): ", i + 1);
				loaihinh = int.Parse(Console.ReadLine());
				if(loaihinh == 1)
				{
					Console.Write("Nhập tên tam giác: ");
					string name = Console.ReadLine();
					Console.Write("Nhập cạnh a: ");
					int a = int.Parse(Console.ReadLine());
					Console.Write("Nhập cạnh b: ");
					int b = int.Parse(Console.ReadLine());
					Console.Write("Nhập cạnh c: ");
					int c = int.Parse(Console.ReadLine());
					ds[i] = new Triangle(name, a, b, c);
				}
				else if(loaihinh == 2)
				{
					Console.Write("Nhập tên hình chữ nhật: ");
					string name = Console.ReadLine();
					Console.Write("Nhập chiều dài: ");
					int cd = int.Parse(Console.ReadLine());
					Console.Write("Nhập chiều rộng: ");
					int cr = int.Parse(Console.ReadLine());
					ds[i] = new Rectangle(name, cd, cr);
				}
			}
			Console.WriteLine("{0,-25} {1,-15} {2,-15}", "Tên hình", "Chu vi", "Diện tích");
			foreach(Shape p in ds)
			{
				p.Xuat();
			}
			double sum = 0;
			int count = 0;
			for(int i = 0; i<n; i++)
			{
				if (ds[i].GetType() == typeof(Rectangle))
				{
					sum += ds[i].Dientich();
					count++;
				}
			}
			if(count > 0)
			{
				double avg = sum / count;
				Console.WriteLine("Diện tích trung bình các hình chữ nhật: {0}", avg);
			}
			else
			{
				Console.WriteLine("Không có hình chữ nhật!");
			}
		}
		static void BT4_4()
		{
			string loai;
			Console.Write("Nhập loại đối tượng máy tính (Laptop hay Macbook): ");
			loai = Console.ReadLine();
			if(loai == "Laptop")
			{
				Maytinh mt = new Laptop();
				mt.Nhap();
				Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-25}", "Nhãn hiệu", "RAM", "Bộ nhớ", "Giá bán");
				mt.Xuat();
			}
			else if(loai == "Macbook")
			{
				Maytinh mt = new Macbook();
				mt.Nhap();
				Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-25}", "Nhãn hiệu", "RAM", "Bộ nhớ", "Giá bán");
				mt.Xuat();
			}
			else
			{
				Console.WriteLine("Loại máy tinh không hợp lệ!");
			}
			Maytinh[] ds;
			int n;
			do
			{
				Console.Write("Nhập số lượng máy tính (2 <= n <= 20): ");
				n = int.Parse(Console.ReadLine());
			} while (n < 2 || n > 30);
			string type;
			ds = new Maytinh[n];
			for(int i  = 0; i < n; i++)
			{
				Console.Write("Nhập loại máy tính thứ {0} (Laptop hay Macbook): ", i + 1);
				type = Console.ReadLine();
				if(type == "Laptop")
				{
					ds[i] = new Laptop();
					ds[i].Nhap();
				}
				else if(type == "Macbook")
				{
					ds[i] = new Macbook();
					ds[i].Nhap();
				}
				else
				{
					Console.WriteLine("Loại máy tính không hợp lệ!");
					i--;
				}
			}
			Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-25}", "Nhãn hiệu", "RAM", "Bộ nhớ", "Giá bán");
			foreach (Maytinh maytinh in ds)
			{
				maytinh.Xuat();
			}
			int countlt = 0;
			for(int i = 0; i < n; i++)
			{
				if (ds[i].GetType() == typeof(Laptop))
				{
					countlt++;
				}
			}
			Console.WriteLine($"Số lượng Laptop: {countlt}");
			int countmb = 0;
			for (int i = 0; i < n; i++)
			{
				if (ds[i].GetType() == typeof(Macbook))
				{
					countmb++;
				}
			}
			Console.WriteLine($"Số lượng Macbook: {countmb}");
		}
		static void BT4_5()
		{
			/*PTB2_4_5 p = new PTB2_4_5();
			p.Xuat();*/
			Console.WriteLine("KQ câu a: 3		5		7");
			/*PTB1_4_5 p = new PTB1_4_5();
			p.Xuat();*/
			Console.WriteLine("KQ câu b: 2		4");
			/*PTB1_4_5 p = new PTB1_4_5(1);
			p.Xuat();*/
			Console.WriteLine("KQ câu c: 1		4");
			/*PTB2_4_5 p = new PTB2_4_5(1);
			p.Xuat();*/
			Console.WriteLine("KQ câu d: 1		5		7");
			/*PTB2_4_5 p = new PTB2_4_5(1, 2);
			p.Xuat();*/
			Console.WriteLine("KQ câu e: 1		2		7");
		}
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			BT4_2();
			Console.ReadKey();
		}
	}
}
