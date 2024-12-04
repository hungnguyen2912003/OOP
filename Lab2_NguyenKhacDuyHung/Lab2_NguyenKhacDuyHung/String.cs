using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_NguyenKhacDuyHung
{
    internal class String
    {
        string s;
        /*Vị trí xuất hiện chuỗi*/
        int x, y;
        /*Khởi tạo không tham số*/
        public String()
        {
            s = "Hello World";
            x = 10; y = 15;
            /*Màu nền*/
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            /*Màu chữ*/
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        /*Khởi tạo có tham số*/
        public String(string s, int x, int y, int bg, int fg)
        {
            this.s = s;
            this.x = x;
            this.y = y;
            Console.BackgroundColor = (ConsoleColor)bg;
            Console.ForegroundColor = (ConsoleColor)fg;
        }
        /*Hiển thị*/
        public void HienThi()
        {
            /*Xoá màn hình*/
            Console.Clear();
            /*Hiển thị chuỗi ở vị trí x, y*/
            Console.CursorLeft = x;
            Console.CursorTop = y;
            /*Ẩn trỏ chuột*/
            Console.CursorVisible = false;
            /*In chuỗi ra màn hình*/
            Console.WriteLine(s);
        }
        /*Di chuyển chuỗi*/
        public void ChuyenDong()
        {
            HienThi();
            while (true)
            {
                ConsoleKeyInfo phim = Console.ReadKey(true);
                if (phim.Key == ConsoleKey.Escape)
                    break;
                if (phim.Key == ConsoleKey.LeftArrow)
                    x--;
                if (phim.Key == ConsoleKey.RightArrow)
                    x++;
                if (phim.Key == ConsoleKey.UpArrow)
                    y--;
                if (phim.Key == ConsoleKey.DownArrow)
                    y++;
                /*Xử lý biên*/
                int Width = Console.WindowWidth;
                int Height = Console.WindowHeight;
                switch (phim.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (x > 0) x--;
                        else x = Width - 1;
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < Width - s.Length) x++;
                        else x = 0;
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 0) y++;
                        else y = Height -1;
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < Height - 1) y++;
                        else y = 0;
                        break;
                }
                /*Hiển thị ở vị trí mới*/
                HienThi();
            }
        }
    }
}
