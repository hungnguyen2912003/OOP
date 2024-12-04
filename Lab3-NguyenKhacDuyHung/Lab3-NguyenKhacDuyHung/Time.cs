using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_NguyenKhacDuyHung
{
	internal class Time
	{
		int hour;
		int minute;
		int second;
		/*Phương thức không tham số*/
		public Time()
		{
			hour = 0;
			minute = 0;
			second = 0;
		}
		/*Phương thức có tham số*/
		public Time(int h, int m, int s)
		{
			hour = h;
			minute = m;
			second = s;
		}
		/*Tính và trả về mốc thời gian sau 1 giây*/
		public static Time operator ++(Time t)
		{
			t.second++;
			if (t.second >= 60)
			{
				t.second = 0;
				t.minute++;
				if (t.minute >= 60)
				{
					t.minute = 0;
					t.hour++;
					if (t.hour >= 24)
					{
						t.hour = 0;
					}
				}
			}
			return t;
		}
		/*Tính và trả về mốc thời gian trước 1 giây*/
		public static Time operator --(Time t)
		{
			t.second--;
			if (t.second < 0)
			{
				t.second = 59;
				t.minute--;
				if (t.minute < 0)
				{
					t.minute = 59;
					t.hour--;
					if (t.hour < 0)
					{
						t.hour = 23;
					}
				}
			}
			return t;
		}
		/*Tính và trả về mốc thời gian được công thêm s giây*/
		public static Time operator +(Time t, int s)
		{
			Time kq = new Time();
			kq.second = kq.second + s;
			if (kq.second >= 60)
			{
				kq.minute += kq.second / 60;
				kq.second %= 60;
			}
			if (kq.minute >= 60)
			{
				kq.hour += kq.minute / 60;
				kq.minute %= 60;
			}
			if (kq.hour >= 24)
			{
				kq.hour %= 24;
			}
			return kq;
		}
		/*Xuất*/
		public void Xuat()
		{
			Console.WriteLine($"{hour}:{minute}:{second}");
		}
	}
}
