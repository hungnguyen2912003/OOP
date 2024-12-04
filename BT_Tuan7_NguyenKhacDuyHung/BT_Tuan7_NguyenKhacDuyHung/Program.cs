using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tuan7_NguyenKhacDuyHung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
            int n;
			CanBo[] dscb;
			do
			{
				Console.Write("Nhập số lượng cán bộ nhân viên (5<=n<=30): ");
				n = int.Parse(Console.ReadLine());
			} while (n < 5 || n > 30);
            dscb = new CanBo[n];
			NhanVienHanhChinh[] dsnv = new NhanVienHanhChinh[n];
			GiaoVien[] dsgv = new GiaoVien[n];
			for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"-----Nhập thông tin cán bộ thứ {i + 1}-----");
                Console.Write("Nhập loại cán bộ (1 - Nhân viên hành chính, 2 - Giáo viên): ");
                int loai = int.Parse(Console.ReadLine());
				dscb[i] = new CanBo();
				if (loai == 1)
                {
					dsnv[i] = new NhanVienHanhChinh();
					dsnv[i].Nhap();
				}
                else if(loai == 2)
                {
					dsgv[i] = new GiaoVien();
					dsgv[i].Nhap();
				}
				else
				{
					Console.WriteLine("Không hợp lệ loại cán bộ");
					i--;
				}
			}
            Console.WriteLine("Bảng lương cán bộ nhân viên");
			Console.WriteLine("---------------------------");
			Console.WriteLine("{0,-10} {1,-25} {2,-15}", "Mã số", "Họ tên", "Lương");
			for(int i = 0; i < n; i++)
			{
				if(dsnv[i] != null )
					Console.WriteLine("{0,-10} {1,-25} {2,-15:N0}", dsnv[i].MaSo, dsnv[i].Hoten, dsnv[i].TienLuong());
				else if (dsgv[i] != null )
					Console.WriteLine("{0,-10} {1,-25} {2,-15:N0}", dsgv[i].MaSo, dsgv[i].Hoten, dsgv[i].TienLuong());
			}
			Console.ReadKey();
		}
    }
}
