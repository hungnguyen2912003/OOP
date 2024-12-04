using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tuan5_NguyenKhacDuyHung
{
    /*Định nghĩa lớp Point*/
    public class Point
    {
        /*Các thành phần dữ liệu: x, y tương ứng giá trị tọa độ theo trục hoành, tung trong không gian 2 chiều*/
        int x;
        int y;
        /*Phương thức thiết lập không tham số*/
        public Point()
        {
            x = 0;
            y = 0;
        }
        /*Phương thức thiết lập tham số*/
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        /*Phương thức thiết lập sao chép*/
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
        }
        /*Phương thức Set(int, int) gán giá trị x, y bằng 2 tham số truyền vào.*/
        public void Set(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        /*Phương thức in ra tọa độ theo định dạng (x,y)*/
        public void Print()
        {
            Console.WriteLine($"({x},{y})");
        }
        /*Tạo phương thức bao đóng thuộc tính*/
        public int y_change
        {
            get { return y; }
            set { y = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Tạo ra các đối tượng dùng phương thức thiết lập không tham số (p1), có tham số(p2), sao chép (p3).*/
            Point p1 = new Point();         /*Không tham số*/
            Point p2 = new Point(15,12);    /*Có tham số*/
            Point p3 = new Point(p1);       /*Sao chép*/
            /*Thay đổi giá trị của đối tượng p1 dùng phương thức Set(int,int)*/
            p1.Set(6,10);
            /*In ra màn hình tọa độ của p1, p2.*/
            Console.Write("p1 = ");
            p1.Print();                     /*Toạ độ p1*/
            Console.Write("p2 = ");
            p2.Print();                     /*Toạ độ p2*/
            /*Gán lại giá trị cho thành phần y của đối tượng p3 (dùng đóng gói thuộc tính)*/
            p3.y_change = 3;
            /*In ra màn hình tọa độ của p3.*/
            Console.Write("p3 = ");
            p3.Print();                     /*Toạ độ p3*/
            /*-----------------------------------------*/
            Console.ReadKey();
        }
    }
}
