using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Bai1_1()
        {
            Console.Write("Nhap ho ten cua sinh vien: ");
            string hoten = Console.ReadLine();
            Console.Write("Nhap ngay sinh cua sinh vien: ");
            DateTime ngsinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh cua sinh vien: ");
            bool gtinh = Convert.ToBoolean(Console.ReadLine());

            Console.Write("\n\tThong tin sinh vien la: \n");
            if (gtinh)
                Console.WriteLine($"{hoten}\t{ngsinh.ToShortDateString()}\tNam");
            else
                Console.WriteLine($"{hoten}\t{ngsinh.ToShortDateString()}\tNữ");
        }

        static void Bai1_2()
        {
            int a, b, c;
            Console.Write("Nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a <= b && b <= c)
                Console.WriteLine("Increasing");
            else if (a >= b && b >= c)
                Console.WriteLine("Decreasing");
            else
                Console.WriteLine("Neither increasing nor decreasing order");
        }

        static void Bai1_3()
        {
            int a, b;
            char c;
            Console.Write("Nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ki tu c (+,-,*,/): ");
            c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine($"{a} {c} {b} = {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"{a} {c} {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a} {c} {b} = {a * b}");
                    break;
                case '/':
                    Console.WriteLine($"{a} {c} {b} = {(float)a / b}");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
        
        static void Bai1_4()
        {
            int incorrect = 0;
            bool login_correct = false;
            while(incorrect<3 && !login_correct)
            {
                Console.Write("Vui long nhap mat khau: ");
                int mk = Convert.ToInt32(Console.ReadLine());

                if(mk == 123)
                {
                    Console.WriteLine("Dang nhap thanh cong!");
                    login_correct= true;
                }
                else
                {
                    Console.WriteLine("Mat khau khong hop le!");
                    incorrect++;
                }

                if(incorrect>=3)
                {
                    Console.WriteLine("Ban da nhap qua 3 lan. Dang nhap khong thanh cong!");
                }
            }
        }

    //Bai 1_5
        //Nhap vao mot mang so nguyen gom n phan tu, n thuoc [30,20]
        static int[] NhapMang()
        {
            int n;
            do
            {
                Console.Write("Nhap so luong phan tu: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (!(n >= 3 && n <= 20));
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }
        //In ra màn hình các số trong mảng theo thứ tự tăng dần (dùng hàm hoán đổi vị trí 2 phần tử khi sắp xếp thứ tự).
        static void HoanVi(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Increase(int[] a)
        {
            for(int i = 0; i < a.Length-1; i++)
            {
                if (a[i] > a[i+1])
                    HoanVi(ref a[i],ref a[i+1]);
            }
        }
        //Đếm và in ra số phần tử là số nguyên tố trong mảng (dùng hàm kiểm tra 1 số có là nguyên tố hay không?). 
        static bool checkSNT(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i<= Math.Sqrt(n); i++) {
                if(n%i == 0) return false;
            }
            return true;
        }
        static void CountSNT(int[] a)
        {
            int count = 0;
            for(int i = 0; i < a.Length; i++) 
            {
                if (checkSNT(a[i]))
                    count++;
            }
            Console.WriteLine("\nSo luong phan tu la so nguyen to trong mang la: {0}", count);
        }
        static void Bai1_5()
        {
            int[] a = NhapMang();
            Increase(a);
            Console.Write("Mang sau khi sap xep tang dan la: ");
            for(int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);
            CountSNT(a);
        }
        static void Bai1_6()
        {
            int nam;
            Console.Write("Nhap nam: ");
            nam = Convert.ToInt32(Console.ReadLine());
            if(nam%4==0 && nam % 100 != 0 || nam%400==0)
            {
                Console.WriteLine("Nam {0} la nam nhuan", nam);
            }
            else
            {
                Console.WriteLine("Nam {0} khong phai la nam nhuan", nam);
            }
        }

        static void Bai1_7()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("\t\t*******************************************************************\n");
            Console.Write("\t\t*                    TRÒ CHƠI KÉO, BÚA, BAO                       *\n");
            Console.Write("\t\t*                        Chọn 1 là Kéo                            *\n");
            Console.Write("\t\t*                        Chọn 2 là Búa                            *\n");
            Console.Write("\t\t*                        Chọn 3 là Bao                            *\n");
            Console.Write("\t\t*******************************************************************\n");
            Random rd = new Random();
            int bot;
            bool continuePLaying;
            do
            {   
                bot = rd.Next(1, 4);
                Console.Write("Mời bạn chọn: ");
                int player = Convert.ToInt32(Console.ReadLine());
                switch (player)
                {
                    case 1:
                        Console.WriteLine("Bạn đã chọn Kéo");
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn Búa");
                        break;
                    case 3:
                        Console.WriteLine("Bạn đã chọn Bao");
                        break;
                    default:
                        Console.WriteLine("Không hợp lệ! Mời bạn nhập lại");
                        break;
                }
                switch (bot)
                {
                    case 1:
                        Console.WriteLine("Máy đã chọn Kéo");
                        break;
                    case 2:
                        Console.WriteLine("Máy đã chọn Búa");
                        break;
                    case 3:
                        Console.WriteLine("Máy đã chọn Bao");
                        break;
                }
                Console.WriteLine("---Kết quả---");
                if (player == bot)
                    Console.WriteLine("-----HOÀ-----");
                else if (player == 1 && bot == 3 || player == 2 && bot == 1 || player == 3 && bot == 2)
                    Console.WriteLine("---BẠN THẮNG---");
                else
                    Console.WriteLine("---BẠN THUA---");
                Console.Write("Bạn có muốn chơi tiếp không? < 1 - Có | 2 - Không >: ");
                int choice = int.Parse(Console.ReadLine());
                continuePLaying = (choice == 1);
            } while (continuePLaying);
        }

        static void Bai1_8()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Cau a
            int a = 10, b = 15;
            Console.Write("Kết quả câu a: {1}, {0}\n", a, b);
            //Cau b
            Console.WriteLine($"Kết quả câu b: {1}, {0}", a, b);
            //Cau c
            //int c = Console.ReadLine();
            //Console.Write($"{c}");
            Console.WriteLine("Câu c: Lỗi Cannot implicitly convert type 'string' to 'int' do hàm Console.Readline() trả về một kiểu chuỗi 'string' còn c đang có kiểu là số nguyên 'int'. Cách fix: Dùng hàm chuyển đổi int.Parse()");
            //Cau d
            //int d = 10; bool chk;
            //if (chk)
                //Console.Write("{0}", d);
            //else
                //Console.Write("false");
            Console.WriteLine("Câu d: Lỗi Use of unassigned local variable 'chk' do biến chk chưa gán một giá trị nào. Cách fix: thêm giá trị vào biến chk = True hoặc False");
            //Cau e
            int e = 1;
            switch (e)
            {
                case 1:
                case 2:
                case 3: Console.Write("Kết quả câu e: {0}", e); break;
            }

        }
        static void Main(string[] args)
        {
            Bai1_8();
            Console.ReadKey();
        }
    }
}

