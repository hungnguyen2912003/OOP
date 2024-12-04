using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenKhacDuyHung_63132095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ListTK tk = new ListTK();
            tk.Nhap();
            tk.Xuat();
            tk.DemSLTK();
            tk.TBTien();
            Console.ReadKey();
        }
    }
}
