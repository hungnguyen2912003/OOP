using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_NguyenKhacDuyHung
{
	internal class Shape
	{
		string name;
		public Shape(string id)
		{
			name = id;
		}
		public virtual double Chuvi()
		{
			return 0;
		}
		public virtual double Dientich()
		{
			return 0;
		}
		public void Xuat()
		{
			Console.WriteLine("{0,-25} {1,-15} {2,-15}", name, Chuvi(), Dientich());
		}
	}
	class Triangle : Shape
	{
		int a;
		int b; 
		int c;
		public Triangle(string name, int canha, int canhb, int canhc):base(name)
		{
			a = canha;
			b = canhb;
			c = canhc;
		}
		public void Nhap()
		{
			Console.Write("Nhập cạnh a: ");
			a = int.Parse(Console.ReadLine());
			Console.Write("Nhập cạnh b: ");
			b = int.Parse(Console.ReadLine());
			Console.Write("Nhập cạnh c: ");
			c = int.Parse(Console.ReadLine());
		}
		public override double Chuvi()
		{
			return a + b + c;
		}
		public override double Dientich()
		{
			float p = (a + b + c) / 2;
			return Math.Sqrt(p * (p - a) * (p * b) * (p - c));
		}
	}
	class Rectangle : Shape
	{
		int chieudai;
		int chieurong;
		public Rectangle(string name, int cd, int cr):base(name)
		{
			chieudai = cd;
			chieurong = cr;
		}
		public override double Chuvi()
		{
			return (chieudai + chieurong) * 2;	
		}
		public override double Dientich()
		{
			return (chieudai * chieurong);
		}
	}
}


