using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Ngay10._4._2023_NguyenKhacDuyHung
{
	internal class DienThoai:IComparable<DienThoai>
	{
		string id;
		string name;
		int ram;
		int memory;
		float price;
		public DienThoai(string id, string name, int ram, int memory, float price)
		{
			this.id = id;
			this.name = name;
			this.ram = ram;
			this.memory = memory;
			this.price = price;
		}
		public float TinhTien()
		{
			float giatien = 0;
			if(name == "Iphone")
			{
				giatien = price + price * 0.1f;
			}
			else
			{
				giatien = price + price * 0.05f;
			}
			return giatien;
		}
		public void Xuat()
		{
			Console.WriteLine("{0,-15} {1,-25} {2,-15} {3,-15} {4,-20}",id, name, ram, memory, TinhTien());
		}
		public int CompareTo(DienThoai dt)
		{
			if (this.price > dt.price) return 1;
			else if (this.price == dt.price ) return 0;
			else return -1;
		}
	}
	class DS_Phone
	{
		List<DienThoai> phone;
		int n;
		public DS_Phone()
		{
			FileStream f = new FileStream("D:\\BT_Ngay10.4.2023-NguyenKhacDuyHung\\fileinfophone.txt", FileMode.Open, FileAccess.Read);
			StreamReader rd = new StreamReader(f);
			n = int.Parse(rd.ReadLine());
			phone = new List<DienThoai>(n);
			for(int i = 0; i < n; i++)
			{
				string maso = rd.ReadLine();
				string name = rd.ReadLine();
				int ram = int.Parse(rd.ReadLine());
				int memory = int.Parse(rd.ReadLine());
				float price = float.Parse(rd.ReadLine());
				DienThoai dt = new DienThoai(maso, name, ram, memory, price);
				phone.Add(dt);
			}
		}
		public void Xuat()
		{
			foreach(DienThoai dt in phone) 
			{
				dt.Xuat(); 
			}
		}
		public void SapXep()
		{
			phone.Sort();
		}
	}
}
