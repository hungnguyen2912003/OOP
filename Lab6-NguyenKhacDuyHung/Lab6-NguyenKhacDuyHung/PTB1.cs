using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_NguyenKhacDuyHung
{
	internal class PTB1
	{
		protected float b, c;//bx+c=0
							 //khoi tao
		public PTB1(float b = 0, float c = 0)
		{
			this.b = b; this.c = c;
		}
		//dung cho ung dung WF
		public string Giai_WF()
		{
			if (b == 0)
				if (c == 0)
					return "Phương trình vô số nghiệm!";
				else
					return "Phương trình vô nghiệm!";
			else
			{
				float x = -c / b;
				return "Phương trình có nghiệm x = " + x;
			}
		}
	}
	//
	class PTB2 : PTB1
	{
		float a;//ax^2+bx+c=0
		public PTB2(float a = 0, float b = 0, float c = 0) : base(b, c)
		{
			this.a = a;
		}
		//dung cho ung dung WF
		public new string Giai_WF()
		{
			if (a == 0)
				return base.Giai_WF();
			else
			{
				float del = b * b - (4 * a * c);
				if (del < 0)
					return "Phương trình vô nghiệm!";
				else if (del == 0)
				{
					float x = -b / (2 * a);
					return "Phương trình có nghiệm kép: x1 = x2 = " + x;
				}
				else
				{
					float x1 = (-b - (float)Math.Sqrt(del)) / (2 * a);
					float x2 = (-b + (float)Math.Sqrt(del)) / (2 * a);
					return "PT có 2 nghiệm: x1 = " + x1 + ", x2 = " + x2;
				}
			}
		}
	}

}
