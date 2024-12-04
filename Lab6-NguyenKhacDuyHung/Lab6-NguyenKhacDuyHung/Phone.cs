using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_NguyenKhacDuyHung
{
	internal class Phone:IComparable<Phone>
	{
		string maso;
		string nhanhieu;
		float gianhap;
		string pic;
		public string ID
		{
			get { return maso; }
			set { maso = value; }
		}
		public string Name
		{
			get { return nhanhieu; }
			set { nhanhieu = value; }
		}
		public float Price
		{
			get { return gianhap; }
			set { gianhap = value; }
		}
		public string Pic
		{
			get { return pic; }
			set { pic = value; }
		}
		public Phone(string i="", string n="", float price = 0, string p = "")
		{
			maso = i;
			nhanhieu = n;
			gianhap = price;
			pic = p;
		}

		public float GiaBan()
		{
			if (nhanhieu.CompareTo("Iphone") == 0)
				return 1.5f * Price;
			else
				return 1.3f * Price;
		}
		public int CompareTo(Phone p)
		{
			if (GiaBan() < p.GiaBan()) return 1;
			else if (GiaBan() == p.GiaBan()) return 0;
			else return -1;
		}
	}
}
