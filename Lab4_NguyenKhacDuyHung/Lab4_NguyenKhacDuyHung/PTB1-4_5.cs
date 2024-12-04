using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_NguyenKhacDuyHung
{
	internal class PTB1_4_5
	{
		protected int a, b;
		public PTB1_4_5(int a1 = 2, int b1 = 4)
		{
			a = a1; b = b1;
		}
		public void Xuat()
		{
			Console.Write($"{a}\t{b}");
		}
	}
	class PTB2_4_5 : PTB1_4_5
	{
		int c;
		public PTB2_4_5(int a = 3, int b = 5, int c = 7) : base(a, b)
		{
			this.c = c;
		}
		public new void Xuat()
		{
			base.Xuat();
			Console.Write($"\t{c}");
		}
	}
}
