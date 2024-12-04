using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_NguyenKhacDuyHung
{
    internal class Time
    {
        int hour;
        int minute;
        int second;
        /*Time() phương thức khởi tạo không tham số, gán hour,
        minute, second bằng 0.*/
        public Time()
        {
            hour = 5;
            minute = 14;
            second = 59;
        }
        /*- Time(int h, int m, int s) phương thức khởi tạo có tham số, gán
hour bằng h, minute bằng m, second bằng s.*/
        public Time(int h, int m, int s) 
        {
            hour = h;
            minute = m;
            second = s;
        }
        /*Đóng gói thuộc tính Hour, Minute, Second*/
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public int Second
        {
            get { return second; }
            set { second = value;}
        }
        /*NextSecond() tính và trả về mốc thời gian sau 1 giây.*/
        public Time NextSecond()
        {
            second++;
            if(second == 60)
            {
                second = 0;
                minute++;
                if(minute == 60)
                { 
                    minute = 0;
                    hour++;
                    if (hour == 24)
                        hour = 0;
                }
            }
            return this;
        }
        /*PreviousSecond() tính và trả về mốc thời gian trước 1 giây.*/
        public Time PreviousSecond()
        {
            second--;
            if (second == -1)
            {
                second = 59;
                minute--;
                if (minute == -1)
                {
                    minute = 59;
                    hour--;
                    if (hour == -1)
                        hour = 23;
                }
            }
            return this;
        }
        /* Show() hiện ra màn hình thời gian theo định dạng h:m:s*/
        public void Show()
        {
            Console.WriteLine($"{hour}:{minute}:{second}");
        }
    }
}
