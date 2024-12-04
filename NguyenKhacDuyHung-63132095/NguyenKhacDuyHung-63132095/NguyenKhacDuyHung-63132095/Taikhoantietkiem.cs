using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenKhacDuyHung_63132095
{
    abstract class Taikhoantietkiem
    {
        public int sotk;
        public string hoten;
        public float sotiengui;

        public Taikhoantietkiem()
        {
            sotk = 0;
            hoten = "";
            sotiengui = 0;
        }

        public void Nhap()
        {
            Console.Write("Nhập số tài khoản: ");
            sotk = int.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên: ");
            hoten = Console.ReadLine();
            Console.Write("Nhập số tiền gửi: ");
            sotiengui = float.Parse(Console.ReadLine());
        }

        public abstract float Tientattoan();
        public void Xuat()
        {
            Console.WriteLine($"Số tài khoản: {sotk}\tHọ tên: {hoten}\tSố tiền gửi: {sotiengui}\tTiền tất toán: {Tientattoan()}");
        }
    }

    class TKtietkiemkhongkyhan : Taikhoantietkiem
    {
        public DateTime ngaygui;

        public TKtietkiemkhongkyhan()
        {
            ngaygui = DateTime.Now;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập ngày gửi: ");
            ngaygui = DateTime.Parse(Console.ReadLine());
        }
        public override float Tientattoan()
        {
            return sotiengui + sotiengui * 0.06f * (DateTime.Now - ngaygui).Days / 360;
        }
    }

    class TKtietkiemcokyhan : Taikhoantietkiem
    {
        public byte kyhan;

        public TKtietkiemcokyhan()
        {
            kyhan = 0;
        }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập kỳ hạn (theo tháng 1 -> 12): ");
            kyhan = byte.Parse(Console.ReadLine());
        }
        public override float Tientattoan()
        {
            if (kyhan < 6)
                return sotiengui + kyhan * sotiengui * 0.04f;
            else
                return sotiengui + kyhan * sotiengui * 0.05f;
        }
    }

    class ListTK
    {
        int n;
        List<Taikhoantietkiem> ls;
        public void Nhap()
        {
            Console.Write("Nhập số lượng tài khoản tiết kiệm (3 < n < 20): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 3 || n >= 20)
            {
                Console.Write("Số lượng không hợp lệ. Vui lòng nhập lại: ");
            }
            ls = new List<Taikhoantietkiem>(n);
            byte choose;
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Nhập loại tài khoản tiết kiệm (1 - TKTK không kỳ hạn; 2 - TKTK có kỳ hạn) cho tài khoản thứ {i + 1}: ");
                    if(byte.TryParse(Console.ReadLine(), out choose))
                    {
                        if(choose == 1 || choose == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Loại tài khoản {i + 1} không hợp lệ. Vui lòng nhập lại");
                        }
                    }
                }
                if(choose == 1)
                {
                    Console.WriteLine($"---Tài khoản {i + 1}: Tài khoản tiết kiệm không kỳ hạn---");
                    TKtietkiemkhongkyhan tk = new TKtietkiemkhongkyhan();
                    tk.Nhap();
                    ls.Add(tk);
                }
                if(choose == 2)
                {
                    Console.WriteLine($"---Tài khoản {i + 1}: Tài khoản tiết kiệm có kỳ hạn---");
                    TKtietkiemcokyhan tk = new TKtietkiemcokyhan();
                    tk.Nhap();
                    ls.Add(tk);
                }
            }
        }
        public void Xuat()
        {
            foreach(Taikhoantietkiem tk in ls)
            {
                tk.Xuat();
            }
        }
        public void DemSLTK()
        {
            int count = 0;
            for(int i = 0; i < ls.Count; i++)
            {
                if (ls[i].GetType() == typeof(TKtietkiemkhongkyhan))
                {
                    count++;
                }
            }
            Console.WriteLine($"Số lượng tài khoản tiết kiệm không kỳ hạn trong danh sách: {count}");
        }
        public void TBTien()
        {
            float sum = 0;
            foreach(Taikhoantietkiem tk in ls)
            {
                sum += tk.Tientattoan();
            }
            Console.WriteLine($"Trung bình tiền tất toán của {n} tài khoản tiết kiệm : {(float)sum / ls.Count}");
        }
    }
}
