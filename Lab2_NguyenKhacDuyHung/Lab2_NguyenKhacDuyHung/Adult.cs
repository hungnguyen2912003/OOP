using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_NguyenKhacDuyHung
{
    internal class Adult
    {
        string FullName;
        float Weight;
        float Height;
        /*Khởi tạo không tham số*/
        public Adult()
        {
            FullName = "Nguyễn Khắc Duy Hưng";
            Weight = 72;
            Height = 1.69f;
        }
        /*Khởi tạo có tham số*/
        public Adult(string fn, float w, float h)
        {
            FullName = fn;
            Weight = w;
            Height = h;

        }
        /*Khởi tạo sao chép*/
        public Adult(Adult a)
        {
            FullName = a.FullName;
            Weight = a.Weight;
            Height = a.Height;
        }
        /*Hiển thị*/
        public void Info()
        {
            Console.WriteLine($"Họ và tên: {FullName}");
            Console.WriteLine($"Cân nặng: {Weight}");
            Console.WriteLine($"Chiều cao: {Height}");
            float bmi =Weight/(float)Math.Pow(Height,2);
            Console.WriteLine($"Chỉ số BMI: {bmi}");
            Console.Write("Tình trạng sức khoẻ: ");
            if (bmi < 18.5)
                Console.WriteLine("Thiếu cân");
            if (bmi >= 18.5 && bmi <= 25)
                Console.WriteLine("Bình thường (sức khoẻ tốt)");
            if (bmi > 25 && bmi < 30)
                Console.WriteLine("Thừa cân");
            if (bmi >= 30)
                Console.WriteLine("Béo phì");
        }
        /*Số cân tăng/giảm để chưa tốt thành tốt*/
        public void Inc_Dec_W()
        {
            float bmi = Weight / (float)Math.Pow(Height, 2);
            /*Cân nặng mới ứng với 2 mốc mới*/
            float w1, w2;
            if ( bmi < 18.5 )
            {
                w1 = 18.5f * Height * Height;
                w2 = 25 * Height * Height;
                Console.WriteLine($"Bạn cần tăng tối thiểu {w1 - Weight}kg và tối đa {w2 - Weight}kg");
            }
            else if (bmi > 25)
            {
                w1 = 25 * Height * Height;
                w2 = 18.5f * Height * Height;
                Console.WriteLine($"Bạn cần giảm tối thiểu {Math.Abs(w1 - Weight)}kg và tối đa {Math.Abs(w1 - Weight)}kg");
            }
        }
    }
}
