using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab5_NguyenKhacDuyHung
{
	internal class Program
	{
		static void Bai5_1()
		{
			ListHCN ls = new ListHCN();
			ls.Nhap();
			Console.WriteLine("-------------Danh sách n hình chữ nhật---------------------");
			Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Tên hình", "Diện tích", "Chi phí");
			ls.Xuat();
			ls.SapXep();
			Console.WriteLine("-------------Danh sách sau khi sắp xếp giảm dần thêm chi phí vẽ--------------");
			Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Tên hình", "Diện tích", "Chi phí");
			ls.Xuat();
			ls.Del();
			Console.WriteLine("-------------Danh sách sau khi xoá hình chữ nhật đầu tiên trong danh sách có diện tích nhỏ hơn x-------------");
			Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Tên hình", "Diện tích", "Chi phí");
			ls.Xuat();
			ls.Add();
			Console.WriteLine("-------------Danh sách sau khi thêm một hình chữ nhật vào vị trí i-----------");
			Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Tên hình", "Diện tích", "Chi phí");
			ls.Xuat();
			Console.WriteLine($"Tổng chi phí vẽ của n hình chữ nhật: {ls.Sum_Cost()}");
		}
		static void Bai5_2() 
		{
			SinhVien sv = new SinhVien();
			sv.Nhap();
			sv.Xuat();
			if (sv.XetHB())
			{
				Console.WriteLine("Sinh viên đủ điều kiện xét học bổng");
			}
			else
			{
				Console.WriteLine("Sinh viên không đủ điều kiện xét học bổng");
			}
		}
		static void Bai5_3()
		{
			KhoaHoc hk = new KhoaHoc();
			hk.Nhap();
			hk.SapXep();
			Console.WriteLine("Danh sách học viên của khoá học đuợc sắp xếp giảm dần theo học phí");
			hk.Xuat();
			hk.Find();
			Console.WriteLine("Nhập thông tin học viên cần thêm");
			hk.Add();
			Console.WriteLine("Danh sách sau khi thêm học viên vào khoá học");
			hk.Xuat();
			hk.Del();
			Console.WriteLine("Danh sách sau khi xoá tất cả các học phí có tiền học phí là 0");
			hk.Xuat();
		}
		static void Bai5_4() 
		{
			ListNews ls = new ListNews();
			int choice;
			do
			{
				Console.WriteLine("MENU:");
				Console.WriteLine("1. Thêm tin tức");
				Console.WriteLine("2. Hiển thị danh sách tin tức");
				Console.WriteLine("3. Tính toán điểm đánh giá trung bình của từng tin tức");
				Console.WriteLine("4. Thoát");
				Console.Write("Nhập sự lựa chọn: ");
				choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
						ls.Input();
						break;
					case 2:
						ls.Output();
						break;
					case 3:
						ls.DisplayAvgRate();
						break;
					case 4:
						Console.WriteLine("Tạm biệt!");
						break;
					default:
						Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập lại!");
						break;
				}
			}while (choice != 4);
		}
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			Bai5_1();
			Console.ReadKey();
		}
	}
}
