using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_NguyenKhacDuyHung
{
	internal class PhanSo
	{
		int tuso;
		int mauso;
		/*Phương thức không tham số*/
		public PhanSo()
		{
			tuso = 1;
			mauso = 2;
		}
		/*Phương thức tham số*/
		public PhanSo(int ts, int ms)
		{
			tuso = ts;
			mauso = ms;
		}
		/*Phương thức sao chép*/
		public PhanSo(PhanSo ps)
		{
			tuso = ps.tuso;
			mauso = ps.mauso;
		}
		/*Cộng hai phân số*/
		public PhanSo Cong(PhanSo ps)
		{
			PhanSo kq = new PhanSo();
			kq.tuso = this.tuso * ps.mauso + ps.tuso * this.mauso;
			kq.mauso = this.mauso * ps.mauso;
			return kq;
		}
		/*Trừ hai phân số*/
		public PhanSo Tru(PhanSo ps)
		{
			PhanSo kq = new PhanSo();
			kq.tuso = this.tuso * ps.mauso - ps.tuso * this.mauso;
			kq.mauso = this.mauso * ps.mauso;
			return kq;
		}
		/*Nhân hai phân số*/
		public PhanSo Nhan(PhanSo ps)
		{
			PhanSo kq = new PhanSo();
			kq.tuso = this.tuso *  ps.tuso;
			kq.mauso = this.mauso * ps.mauso;
			return kq;
		}
		/*Chia hai phân số*/
		public PhanSo Chia(PhanSo ps)
		{
			PhanSo kq = new PhanSo();
			kq.tuso = this.tuso * ps.mauso;
			kq.mauso = this.mauso * ps.tuso;
			return kq;
		}
		/*Rút gọn phân số*/

		//Toán tử cộng, trừ, nhân, chia

		public static PhanSo operator+(PhanSo ps1, PhanSo ps2)
		{
			PhanSo kq = new PhanSo();
			kq.tuso = ps1.tuso * ps2.mauso + ps2.tuso * ps1.mauso;
			kq.mauso = ps1.mauso * ps2.mauso;
			return kq;
		}

		public static PhanSo operator-(PhanSo ps1, PhanSo ps2)
		{
			PhanSo kq = new PhanSo();
			kq.tuso = ps1.tuso * ps2.mauso - ps2.tuso * ps1.mauso;
			kq.mauso = ps1.mauso * ps2.mauso;
			return kq;
		}
		public static PhanSo operator*(PhanSo ps1, PhanSo ps2)
		{
			PhanSo kq = new PhanSo();
			kq.tuso = ps1.tuso * ps2.tuso;
			kq.mauso = ps1.mauso * ps2.mauso;
			return kq;
		}
		public static PhanSo operator/(PhanSo ps1, PhanSo ps2)
		{
			PhanSo kq = new PhanSo();
			kq.tuso = ps1.tuso * ps2.mauso;
			kq.mauso = ps1.mauso * ps2.tuso;
			return kq;
		}

		int UCLN(int a, int b)
		{
			a = Math.Abs(a);
			b = Math.Abs(b);
			while (a != b) 
			{
				if (a > b)
					a = a - b;
				else
					b = b - a;
			}
			return a;
		}

		public PhanSo Rutgon()
		{
			int t = UCLN(tuso, mauso);
			tuso = tuso / t;
			mauso = mauso / t;
			return this;
		}

		/*Xuất phân số dạng tử số/mẫu số*/
		public void Xuatps()
		{
			Console.WriteLine($"{tuso}/{mauso}");
		}
	}
}
