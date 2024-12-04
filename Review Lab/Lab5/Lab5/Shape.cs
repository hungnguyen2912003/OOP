using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	abstract class Shape
	{
		public string name;

		public Shape()
		{
			name = "";
		}
		public Shape(string name)
		{
			this.name = name;
		}
		public abstract float Dientich();
	}

	interface IPaint
	{
		float Dongia { get; set; }
		float TinhChiPhi();
	}

	class Rectangle : Shape, IPaint, IComparable<Rectangle>
	{
		public float dai;
		public float rong;
		public float dongia;
		public float Dongia
		{
			get { return dongia; }
			set { dongia = value; }
		}
		public Rectangle():base()
		{
			dai = 0;
			rong = 0;
		}
		public Rectangle(float dai, float rong, float dongia = 2, string name = "Rectangle"):base(name)
		{
			this.dai = dai;
			this.rong = rong;
			this.dongia = dongia;
		}
		public override float Dientich()
		{
			return dai * rong;
		}

		public float TinhChiPhi() 
		{
			return dongia * Dientich();
		}
		public void Xuat()
		{
			Console.WriteLine($"Chiều dài: {dai}, Chiều rộng: {rong}, Diện tích: {Dientich()}, Chi phí: {TinhChiPhi()}");
		}
		public int CompareTo(Rectangle rec)
		{
			if (this.TinhChiPhi() < rec.TinhChiPhi()) return 1;
			else if (this.TinhChiPhi() == rec.TinhChiPhi()) { return 0; }
			else return -1;
		}
	}

	class ListShape
	{
		int n;
		List<Rectangle> ls;
		public void Nhap()
		{
			Console.Write("Nhập số lượng hình (2 <= n <= 10): ");
			while(!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 10)
			{
				Console.Write("Số lượng không đúng. Vui lòng nhập lại: ");
			}
			ls = new List<Rectangle>(n);
			for(int i  = 0; i < n; i++)
			{
				Console.WriteLine($"---Nhập hình chữ nhật thứ {i + 1}---");
				Console.Write("Nhập chiều dài: ");
				float d = float.Parse(Console.ReadLine());
				Console.Write("Nhập chiều rộng: ");
				float r = float.Parse(Console.ReadLine());
				Rectangle rec = new Rectangle(d, r);
				
				ls.Add(rec);
			}
		}
		public void Xuat()
		{
			ls.Sort();
			foreach(Rectangle rec in ls)
			{
				rec.Xuat();
			}
		}
		public void XoaHCN()
		{
			Console.Write("Nhập diện tích: ");
			float x = float.Parse(Console.ReadLine());
			for(int i =0; i < ls.Count; i++)
			{
				if (ls[i].Dientich() < x)
				{
					ls.RemoveAt(i);
					break;
				}
			}
		}

		public void ThemHCN()
		{
			Console.WriteLine("---Thêm hình chữ nhật---");
			Console.Write("Nhập chiều dài: ");
			float d = float.Parse(Console.ReadLine());
			Console.Write("Nhập chiều rộng: ");
			float r = float.Parse(Console.ReadLine());
			Rectangle rec = new Rectangle(d, r);
			Console.Write($"Nhập vị trí cần chèn (0 -> {n}): ");
			int i = int.Parse(Console.ReadLine());
			if (i >= 0 && i <= n)
				ls.Insert(i, rec);
			else if (i < 0)
				ls.Insert(0, rec);
			else
				ls.Add(rec);
		}

		public void TongChiPhi()
		{
			float sum = 0;
			foreach(Rectangle rec in ls)
			{
				sum += rec.TinhChiPhi();
			}
			Console.WriteLine($"Tổng chi phí vẽ của {n} hình chữ nhật = {sum}");
		}
	}
}
