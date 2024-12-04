using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			ListXe xe = new ListXe();
			xe.Nhap();
			xe.Xuat();
			xe.ThemXe();
			xe.Xuat();
			xe.Xoa();
			xe.Xuat();
			Console.ReadKey();
		}
	}
}
