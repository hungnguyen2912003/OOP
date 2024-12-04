using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_NguyenKhacDuyHung
{
	internal class PTB1
	{
		protected float b, c;
		public PTB1()
		{
			b = 0;
			c = 0;
		}
		public PTB1(float b, float c)
		{
			this.b = b;
			this.c = c;
		}
		public void Nhap()
		{
			Console.Write("Nhập hệ số b, c (bx + c = 0): ");
			b = float.Parse(Console.ReadLine());
			c = float.Parse(Console.ReadLine());
		}
		public void Xuat()
		{
			Console.WriteLine($"{b}x + {c} = 0");
		}
		public void Giai()
		{
			if (b == 0)
			{


				if (c == 0)
					Console.WriteLine("Phương trình vô số nghiệm!");
				else Console.WriteLine("Phương trình vô nghiệm!");
			}
			else
			{
				float x = -c / b;
				Console.WriteLine($"Phương trình có nghiệm x={x}");
			}
		}

	}
	//
	class PTB2 : PTB1
	{// ax^2+bx+c=0
		float a;
		// khoi tao
		public PTB2() : base()
		{
			a = 0;
		}
		public PTB2(float a, float b, float c) : base(b, c)
		{
			this.a = a;
		}
		// nhap dung co che dinh nghia lai
		public new void Nhap()
		{
			Console.Write("Nhập hệ số a ( ax^2 + bx + c = 0): ");
			a = Convert.ToSingle(Console.ReadLine());
			base.Nhap();
		}
		//xuat
		public new void Xuat()
		{
			Console.Write($"{a}x^2+");
			base.Xuat();
		}
		//giai
		public new void Giai()
		{
			if (a == 0)// bx+c=0
				base.Giai();
			else //ax^2+bx+c=0
			{
				float del = b * b - 4 * a * c;
				if (del < 0)
					Console.WriteLine("Phương trình vô nghiệm!");
				else if (del == 0)
				{
					float x = -b/(2 * a);
					Console.WriteLine($"Phương trình có nghiệm kép x1 = x2 = {x}");

				}
				else
				{
					float x1=(float) (-b - Math.Sqrt(del))/(2 * a);
					float x2 = (float)(-b + Math.Sqrt(del)) / (2 * a);
					Console.Write("Phương trình có 2 nghiệm!");
				}
			}
		}
	}
}

