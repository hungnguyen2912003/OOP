using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_NguyenKhacDuyHung
{
	interface INews
	{
		string ID { get; set; }
		string Title { get; set; }
		string Author { get; set; }
		void Display();
	}
	class News : INews
	{
		public string ID { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public DateTime publicDate;
		protected string content;
		public List<float> avgRate { get; set; }
		public string Nd
		{
			get { return content; }
			set { content = value; }
		}
		public DateTime ngdang
		{
			get { return publicDate; }
			set { publicDate = value; }
		}
		/*Phương thức không tham số*/
		public News()
		{
			ID = "";
			Title = "";
			Author = "";
			publicDate = DateTime.Now;
			avgRate = new List<float>();
		}
		/*Phương thức có tham số*/
		public News(string id, string td, string tg, DateTime ngay, string nd)
		{
			this.ID = id;
			this.Title = td;
			this.Author = tg;
			this.publicDate = ngay;
			this.content = nd;
			avgRate = new List<float>();
		}
		public void Display()
		{
			Console.WriteLine("{0,-15} {1,-20} {2,-25} {3,-15} {4,-30}", ID, Title , Author , publicDate.ToString("dd/MM/yyyy") , content);
		}
		public float Cal_Avg()
		{
			float sum = 0;
			if (avgRate.Count == 0)
			{
				return 0;
			}
			else
			{
				for (int i = 0; i < avgRate.Count; i++)
				{
					sum += avgRate[i];
				}
				return sum / avgRate.Count;
			}
		}
	}
	class ListNews:News
	{
		int n;
		List<News> ls;
		public ListNews()
		{
			n = 0;
			ls = new List<News>(0);
		}
		public void Input()
		{
			Console.Write("Nhập số lượng tin tức trong danh sách: ");
			n = int.Parse(Console.ReadLine());
			ls = new List<News>(n);
			for(int i = 0; i < n; i++)
			{
				Console.WriteLine("Nhập tin tức thứ {0}: ", i + 1);
				Console.Write("Nhập mã tin tức: ");
				string id = Console.ReadLine();
				Console.Write("Nhập tiêu đề tin tức: ");
				string title = Console.ReadLine();
				Console.Write("Nhập tác giả tin tức: ");
				string author = Console.ReadLine();
				Console.Write("Nhập ngày đăng tin tức: ");
				DateTime ngay = DateTime.Parse(Console.ReadLine());
				Console.Write("Nhập nội dung tin tức: ");
				string nd = Console.ReadLine();
				Console.Write("Nhập số lượng người đánh giá: ");
				int ratenum = int.Parse(Console.ReadLine());
				News news = new News(id, title, author, ngay, nd);
				for (int j = 0; j < ratenum; j++)
				{
					Console.Write("Nhập điểm đánh giá của người dùng thứ {0}: ", j+1);
					float rate = float.Parse(Console.ReadLine());
					news.avgRate.Add(rate);
				}
				news.Cal_Avg();
				ls.Add(news);
			}
		}
		public void Output()
		{
			Console.WriteLine("Danh sách các tin tức");
			Console.WriteLine("{0,-15} {1,-20} {2,-25} {3,-15} {4,-30}", "Mã tin tức", "Tiêu đề", "Tác giả", "Ngày đăng", "Nội dung");
			foreach (News news in ls)
			{
				news.Display();
			}
		}
	
		public void DisplayAvgRate()
		{
			Console.WriteLine("Danh sách tin tức và điểm trung bình đánh giá");
			Console.WriteLine("{0,-15} {1,-20} {2,-25} {3,-15} {4,-30}", "Mã tin tức", "Tiêu đề", "Tác giả", "Ngày đăng", "Điểm đánh giá trung bình");
			foreach (News news in ls)
				Console.WriteLine("{0,-15} {1,-20} {2,-25} {3,-15} {4,-30}", news.ID, news.Title, news.Author, news.publicDate.ToString("dd/MM/yyyy"), news.Cal_Avg());
		}
	}
}
