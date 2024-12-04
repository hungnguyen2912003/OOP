using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_NguyenKhacDuyHung
{
	abstract class Maytinh
	{
		public string id;
		public int ram;
		public int memory;
		public float price;
		/*Khởi tạo không tham số*/
		public Maytinh()
		{
			id = "";
			ram = 0;
			memory = 0;
			price = 0;
		}
		/*Khởi tạo có tham số*/
		public Maytinh(string id, int ram, int memory, float price)
		{
			this.id = id;
			this.ram = ram;
			this.memory = memory;
			this.price = price;
		}
		public virtual void Nhap()
		{
			Console.Write("Nhập nhãn hiệu: ");
			id = Console.ReadLine();
			Console.Write("Nhập RAM (GB): ");
			ram = int.Parse(Console.ReadLine());
			Console.Write("Nhập bộ nhớ (GB): ");
			memory = int.Parse(Console.ReadLine());
			Console.Write("Nhập giá: ");
			price = float.Parse(Console.ReadLine());
		}
		public abstract double GiaBan();
		public void Xuat()
		{
			Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-25}", id, ram, memory, (int)GiaBan());
		}
	}
	/*Lớp Laptop*/
	class Laptop : Maytinh
	{
		float weight;
		public Laptop():base()
		{
			weight = 0;
		}
		public Laptop(string id, int ram, int memory, float price, float weight) : base(id, ram, memory, price)
		{
			this.weight = weight;
		}
		public override void Nhap()
		{
			base.Nhap();
			Console.Write("Nhập trọng lượng: ");
			weight = float.Parse(Console.ReadLine());	
		}
		public override double GiaBan()
		{
			double giaban = 0;
			if (weight >= 2)
			{
				giaban = price + price * 0.15f;
			}
			else if (weight < 2)
			{
				return price + price * 0.2f;
			}
			return giaban;
		}
	}
	/*Lớp Macbook*/
	class Macbook : Maytinh
	{
		string Loai;
		public Macbook():base()
		{
			Loai = "";
		}
		public Macbook(string id, int ram, int mem, float gia, string type) : base(id, ram, mem, gia)
		{
			Loai = type;
		}
		public override void Nhap()
		{
			base.Nhap();
			Console.Write("Nhập loại Macbook (MacBook Air, MacBook Pro 13 inch, MacBook Pro 16 inch): ");
			Loai = Console.ReadLine();
		}
		public override double GiaBan()
		{
			double giaban = 0;
			if(Loai == "MacBook Air")
			{
				giaban = price + price * 0.5f;
			}
			if(Loai == "MacBook Pro 13 inch")
			{
				giaban = price + price * 0.8f;
			}
			if(Loai == "MacBook Pro 16 inch")
			{
				giaban = 2 * price;
			}
			return giaban;
		}
	}
}
