using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_NguyenKhacDuyHung
{
	abstract class Shape
	{
		protected string name;
		/*Phương thức không tham số*/
		public Shape()
		{
			name = "";
		}
		/*Phương thức có tham số*/
		public Shape(string name)
		{
			this.name = name;
		}
		/*Phương thức sao chép*/
		public Shape(Shape s)
		{
			s.name = name;
		}
		public abstract float dientich();
	}
	interface IPaint
	{
		float Price { get; set; }
		float Cost();	//Phuong thuc tinh chi phi ve
	}
	class Rectangle : Shape , IPaint , IComparable<Rectangle>
	{
		float chieudai;
		float chieurong;
		float price;
		public float Price { get => Price; set => Price = value; }
		public Rectangle(float d = 5, float r = 3, float p = 2, string n = "Rectangle") : base(n)
		{
			chieudai = d;
			chieurong = r;
			price = p;
		}
		public override float dientich()
		{
			return chieudai * chieurong;
		}
		public float Cost()
		{
			return price * dientich();
		}
		public void Xuat()
		{
			Console.WriteLine("{0,-20} {1,-20} {2,-20}", name, dientich(), Cost());
		}
		//Phương thức của Icomparable
		public int CompareTo(Rectangle r)
		{
			if (this.Cost() < r.Cost()) return 1;
			else if (this.Cost() == r.Cost()) return 0;
			else return -1;
		}
	}
	class ListHCN
	{
		List<Rectangle> ds;
		int n;
		public void Nhap()
		{
			Console.Write("Nhập số lượng hình: ");
			while(!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 10){
				Console.Write("Nhập lại số lượng hình chữ nhật: ");
			}
			//Khởi tạo List
			ds = new List<Rectangle>();
			for(int i = 0; i < n; i++)
			{
				Console.WriteLine("Nhập thông tin của hình {0}", i + 1);
				Console.Write("Nhập chiều dài: ");
				float d = float.Parse(Console.ReadLine());
				Console.Write("Nhập chiều rộng: ");
				float r = float.Parse(Console.ReadLine());
				Rectangle rec = new Rectangle(d, r);
				ds.Add(rec);
			}
		}
		//Dùng phương thức sort của list => Comparable
		public void SapXep()
		{
			ds.Sort();
		}
		//Xoá hcn có diện tĩch < x
		public void Del()
		{
			Console.Write("Nhập vào diện tích cần xoá: ");
			float x = float.Parse(Console.ReadLine());
			//c1: Tìm phần tử thảo mãn điều kiện => xoá
			//foreach(Rectangle rec in ds) 
			//{
			//	if(rec.dientich() < x)
			//	{
			//		ds.Remove(rec);
			//		break;
			//	}
			//}
			//c2: Tìm vị trí của phần tử thoả điều kiện rồi xoá
			for(int i = 0; i < ds.Count; i++)
			{
				if (ds[i].dientich() < x)
				{
					ds.RemoveAt(i);
					break;
				}
			}
		}
		public void Add()
		{
			Console.Write("Nhập vị trí thêm: ");
			int i = int.Parse(Console.ReadLine());
			//Tạo đối tượng cần thêm vào list
			Console.Write("Nhập chiều dài: ");
			float d = float.Parse(Console.ReadLine());
			Console.Write("Nhập chiều rộng: ");
			float r = float.Parse(Console.ReadLine());
			Rectangle rec = new Rectangle(d, r);
			if(i >= 0 && i < ds.Count)
			{
				ds.Insert(i, rec);
			}
			else if(i < 0)
			{
				ds.Insert(0, rec);
			}
			else
			{
				ds.Add(rec);
			}
		}
		//Tính tổng chi phí
		public float Sum_Cost()
		{
			float sum = 0;
			foreach(Rectangle rec in ds) 
			{
				sum += rec.Cost();
			}
			return sum;

			//Cách 2: Sử dụng Sum với toán tử Lamda
			//s = ds.Sum(rec => rec.Cost());
			//return s;
		}
		//Xuất danh sách
		public void Xuat()
		{
			foreach(Rectangle rec in ds)
			{
				rec.Xuat();
			}
		}
	}
}
