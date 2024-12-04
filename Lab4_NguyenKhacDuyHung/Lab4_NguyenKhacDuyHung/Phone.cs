using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_NguyenKhacDuyHung
{
	internal class Phone
	{
		public string id, name;
		public float cost;
		public int year;
		public int Year { get => year; set => year = value; }
		// khoi tao 
		public Phone()
		{
			id = "ip"; name = "iphone13";
			cost = 17.5f;
			year = 2023;
		}
		public Phone(string id, string name, float price, int year)
		{
			this.id = id;
			this.name = name;
			this.cost = price;
			this.year = year;
		}
		//nhap

		public void Input()
		{
			Console.Write("Nhập mã số: ");
			id = Console.ReadLine();
			Console.Write("Nhập nhãn hiệu: ");
			name = Console.ReadLine();
			Console.Write("Nhập giá: ");
			cost = Convert.ToSingle(Console.ReadLine());
			Console.Write("Nhập năm sản xuất: ");
			year = int.Parse(Console.ReadLine());
		}
		// Xuat
		public void Print()
		{
			Console.Write("{0,-15} {1,-20} {2,-15} {3,-20}	", id, name, cost, year);
		}
		//Tính thuế
		public float Tax()
		{
			if (name == "Iphone")
				return cost * 0.1f;
			else
				return cost * 0.05f;
		}
	}
	//Khởi tạo lớp SmartPhone
	class SmartPhone : Phone
	{
		short mem;
		//Khởi tạo
		public SmartPhone() : base()
		{
			mem = 256;
		}
		public SmartPhone(string i, string n, float p, int y, short mem) : base(i, n, p, y)
		{
			this.mem = mem;
		}
		//Nhập
		public new void Input()
		{
			base.Input();
			Console.Write("Nhập dung lượng bộ nhớ: ");
			mem = short.Parse(Console.ReadLine());
		}
		//Xuất
		public new void Print()
		{
			base.Print();
			Console.WriteLine("{0,-15}", mem);
		}
		//Tính giá bán
		public float price()
		{
			float p = 0;
			if (mem >= 128)
				p = cost + 20 / 100 * cost + Tax();
			else if (mem > 16)
				p = cost + 10 / 100 * cost + Tax();
			else
				p = cost + 5 / 100 * cost + Tax();
			return p;
		}
	}
	class ListSmartPhone
	{
		SmartPhone[] ls;
		int n;
		// su dung khoi tao khong tham so mac dinh
		public ListSmartPhone()
		{
			n = 0;
			ls = new SmartPhone[0];
		}
		// nhap
		public void Input()
		{
			while (true)
			{
				Console.Write("Nhập số lượng smartphone (2 <= n <= 30): ");
				if (int.TryParse(Console.ReadLine(), out n))
				{
					if (n >= 2 && n <= 30)
					{
						break;
					}
				}
				Console.WriteLine("Bạn đã nhập sai số lượng smartphone, vui lòng nhập lại!");
			}
			//Khởi tạo mảng
			ls = new SmartPhone[n+1];
			//Nhập vào các phần tử
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Nhập thông tin Smartphone thứ {0}", i + 1);
				ls[i] = new SmartPhone();
				ls[i].Input();
			}
		}
		//Thêm vào 1 smartphone
		public void Add()
		{
			{
				Console.WriteLine("Nhập vào đối tượng cần thêm: ");
				SmartPhone s = new SmartPhone();
				s.Input();
				Console.Write("Nhập vào vị trí cần chèn (1 -> {0}): ", n);
				int p = int.Parse(Console.ReadLine());
				if (p >= 0 && p <= n)
				{
					ls[n] = new SmartPhone();
					for (int i = n; i >= p; i--)
					{
						ls[i] = ls[i - 1];
					}
					ls[p] = s;
					n++;
				}
				else
					Console.WriteLine("Vị trí không hợp lệ!");
			}
		}
		//Xoá 1 Smartphone
		public void Delete()
		{
			for (int i = 0; i < n; i++)
				if (ls[i].Year == DateTime.Now.Year)
				{
					for (int j = i; j < n - 1; j++)
					{
						ls[j] = ls[j + 1];
					}
					n--;
					break;
				}
		}
		public void Sort()
		{
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					if (ls[i].cost < ls[j].cost)
					{
						SmartPhone temp = new SmartPhone();
						temp = ls[i];
						ls[i] = ls[j];
						ls[j] = temp;
					}
				}
			}
		}
		public void Print()
		{
			for(int i = 0; i < n; i++){
				ls[i].Print();
			}
		}
	}
}
