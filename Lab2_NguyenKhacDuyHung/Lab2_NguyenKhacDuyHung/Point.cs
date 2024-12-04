using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_NguyenKhacDuyHung
{
    public class Point
    {
        public int x;
        public int y;
        /*Thiết lập/khởi tạo không tham số gán tọa độ x=0, y=0*/
        public Point()
        {
            x = 0; y = 0;
        }
        /*Khởi tạo có tham số gán x, y bằng giá trị tham số truyền vào*/
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        /*In ra màn hình thông tin tọa độ điểm theo định dạng (x,y)*/
        public void Print()
        {
            Console.WriteLine($"({x},{y})");
        }
        /*Tính khoảng cách giữa 2 điểm.*/
        public float KhoangCach(Point p)
        {
            float d = (float)Math.Sqrt((p.x - x) * (p.x - x) + (p.y - y) * (p.y - y));
            return d;
        }
    }
}
