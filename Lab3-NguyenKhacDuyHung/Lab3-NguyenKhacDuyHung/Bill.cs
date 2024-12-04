using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_NguyenKhacDuyHung
{
	internal class Bill
	{
		string name;
		byte num;
		public static float price = 10.5f;
		public Bill()
		{
			name = "Dell Latitude E7440";
			num = 1;
			price = 9.5f;
		}
		public Bill(string na, byte n, float p)
		{
			name = na;
			num = n;
			price = p;
		}
		public float Cal_Bill()
		{
			return num * price;
		}
		public void Print()
		{
			Console.Write($"{name}\t{num}\t{Cal_Bill()}");
		}
	}
}
