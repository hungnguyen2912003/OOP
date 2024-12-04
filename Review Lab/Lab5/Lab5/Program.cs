using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	internal class Program
	{
		static void Bai1()
		{
			ListShape shape = new ListShape();
			shape.Nhap();
			shape.Xuat();
			shape.XoaHCN();
			shape.Xuat();
			shape.ThemHCN();
			shape.Xuat();
			shape.TongChiPhi();
		}
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			Bai1();
			Console.ReadKey();
		}
	}
}
