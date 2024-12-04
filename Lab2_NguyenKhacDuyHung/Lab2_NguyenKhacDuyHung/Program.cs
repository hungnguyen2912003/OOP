using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2_NguyenKhacDuyHung
{
    internal class Program
    {
        static void BT2_1()
        {
            /*Tạo một điểm dùng phương thức thiết lập không tham số*/
            Point p1 = new Point();
            Console.Write("p1 = ");
            p1.Print();
            /*Khởi tạo có tham số gán x, y bằng giá trị tham số truyền vào*/
            Console.Write("Nhap x cua mot diem: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap y cua mot diem: ");
            int b = int.Parse(Console.ReadLine());
            Point p2 = new Point(a, b);
            Console.Write("p2 = ");
            p2.Print();
            /*In ra khoảng cách 2 điểm*/
            Console.WriteLine($"Khoang cach giua 2 diem = {p1.KhoangCach(p2)}");
        }

        static void BT2_2()
        {
            /*Phương thức thiết lập không tham số*/
            Circle circle = new Circle();
            Console.WriteLine($"Chu vi hinh tron: {circle.GetPerimeter()}");
            Console.WriteLine($"Dien tich hinh tron: {circle.GetArea()}");
            /* Thay đổi giá trị của bán kính bằng một giá trị nhập vào.*/
            Console.Write("Nhap gia tri can thay doi ban kinh: ");
            float r = float.Parse( Console.ReadLine() );
            circle.SetRadius(r);
            Console.WriteLine($"Chu vi hinh tron: {circle.GetPerimeter()}");
            Console.WriteLine($"Dien tich hinh tron: {circle.GetArea()}");
            /*Tạo một đường trong bằng phương thức thiết lập có tham số.*/
            Console.Write("Nhap ban kinh: ");
            float a = float.Parse( Console.ReadLine() );
            Circle circle2 = new Circle(a);
            Console.WriteLine($"Chu vi hinh tron: {circle2.GetPerimeter()}");
            Console.WriteLine($"Dien tich hinh tron: {circle2.GetArea()}");
        }
        
        static void BT2_3()
        {
            /*Tạo đối tượng phương thức thiết lập*/
            String c = new String();
            /*TAhuwjc hiện phương thức chuyển động của đối tượng*/
            c.ChuyenDong();
        }

        static void BT2_4()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            /*Nhập thông tin sử dụng phương thức khởi tạo không tham số*/
            Adult a1 = new Adult();
            a1.Info();
            a1.Inc_Dec_W();
            /*Nhập thông tin sử dụng phương thức khởi tạo tham số*/
            Console.Write("Nhập họ tên: ");
            string ht = Console.ReadLine();
            Console.Write("Nhập cân nặng: ");
            float w = float.Parse( Console.ReadLine() );
            Console.Write("Nhập chiều cao (met): ");
            float h = float.Parse(Console.ReadLine());
            Adult a2 = new Adult(ht,w,h);
            a2.Info();
            a2.Inc_Dec_W();
            /*Nhập thông tin sử dụng phương thức khởi tạo sao chép*/
            Adult a3 = new Adult(a1);
            a3.Info();
            a3.Inc_Dec_W();
        }
        static void BT2_5()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            /*Nhập thông tin sử dụng phương thức khởi tạo không tham số*/
            Student s1 = new Student();
            s1.Info();
            /*Nhập thông tin sử dụng phương thức khởi tạo có tham số*/
            Console.Write("Nhập MSSV: ");
            int ms = int.Parse( Console.ReadLine() );
            Console.Write("Nhập họ và tên: ");
            string ht = Console.ReadLine() ;
            Console.Write("Nhập ngày, tháng, năm sinh (yy/mm/dd): ");
            DateTime ngsinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập giới tinh: ");
            string gt = Console.ReadLine() ;
            Student s2 = new Student(ms,ht,ngsinh,gt);
            s2.Info();
            /*Nhập thông tin sử dụng phương thức khởi tạo sao chép*/
            Student s3 = new Student(s1) ;
            s3.Info();
        }
        static void BT2_6()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            /*Tạo một đối tượng thời gian dùng phương thức thiết lập không tham số*/
            Time t1 = new Time();
            Console.WriteLine("Mốc thời gian ban đầu:");
            t1.Show();
            /*Tính mốc thời gian sau 1 giây và in ra màn hình*/
            Console.WriteLine("Mốc thời gian sau 1 giây:");
            t1.NextSecond();
            t1.Show();
            /*- Tạo một đối tượng thời gian dùng phương thức thiết lập có tham số.*/
            Console.Write("Nhập số giờ: ");
            int h = int.Parse( Console.ReadLine() );
            Console.Write("Nhập số phút: ");
            int m = int.Parse( Console.ReadLine() );
            Console.Write("Nhâp số giây: ");
            int s = int.Parse( Console.ReadLine() );
            Time t2 = new Time(h,m,s);
            Console.WriteLine("Mốc thời gian ban đầu:");
            t2.Show();
            /*Tính mốc thời gian trước 1 giây và in ra màn hình*/
            Console.WriteLine("Mốc thời gian trước 1 giây:");
            t2.PreviousSecond();
            t2.Show();
        }
        static void BT2_7()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Câu a");
            PhepToan pt = new PhepToan();
            pt.Xuat();
            Console.WriteLine("Kết quả câu a: 0+0=0 do không sử dụng phương thức pt.CapNhat() để nhập phép tính");
            Console.WriteLine("Câu b");
            PhepToan pt2 = new PhepToan();
            pt2.CapNhat();//giả sử nhập a=7, b=8, c=+ 
            pt2.Xuat();
            Console.WriteLine("Kết quả câu b: Đúng");
            Console.WriteLine("Câu c");
            PhepToan pt3 = new PhepToan(3, 6,'*');
            pt3.Xuat();
            Console.WriteLine("Kết quả câu c: Đúng");
            Console.WriteLine("Câu d");
            PhepToan pt4 = new PhepToan(3, 6,'*');
            pt4.CapNhat();//giả sử nhập a=7, b=8, c=+ 
            pt4.Xuat();
            Console.WriteLine("Kết quả câu d: KQ sẽ hiển thị theo dữ liệu được nhập từ pt4.CapNhat() chứ không theo dữ liệu được gán trên đối tượng");
        }
        static void Main(string[] args)
        {
            BT2_7();
            Console.ReadKey();
        }
    }
}
