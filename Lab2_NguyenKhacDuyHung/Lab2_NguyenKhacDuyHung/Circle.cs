using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_NguyenKhacDuyHung
{
    /*Định nghĩa lớp Circle*/
    internal class Circle
    {
        float radius;
        /*Phương thức khởi tạo không tham số, gán rad = 1*/
        public Circle()
        {
            radius = 1;
        }
        /*Phương thức khởi tạo có tham số, gán bán kính bằng r*/
        public Circle(float r)
        {
            radius = r;
        }
        /*Phương thức trả về giá trị bán kính đường tròn*/
        public float GetRadius()
        {
            return radius;
        }
        /*Phương thức gán giá trị bán kính đường tròn bằng 1 giá trị đưa vào*/
        public void SetRadius(float f)
        {
            radius = f;
        }
        /*Phương thức tính & trả về chu vi đường tròn*/
        public double GetPerimeter()
        {
            return 2 * 3.14 * radius;
        }
        /*Phương thức tính & trả về diện tích đường tròn*/
        public double GetArea()
        {
            return 3.14 * Math.Pow(radius,2);
        }
    }
}
