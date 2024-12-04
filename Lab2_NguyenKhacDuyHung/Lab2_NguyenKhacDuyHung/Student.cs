using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_NguyenKhacDuyHung
{
    /*Định nghĩa lớp Student*/
    internal class Student
    {
        public int ID;
        public string Name;
        public DateTime birthday;
        public string Gtinh;
        /*Khởi tạo không tham số*/
        public Student()
        {
            ID = 63132095;
            Name = "Nguyễn Khắc Duy Hưng";
            birthday = new DateTime(2003,01,29);
            Gtinh = "Nam";
        }
        /*Khởi tạo có tham số*/
        public Student(int masv, string hoten, DateTime ngsinh, string gt)
        {
            ID = masv;
            Name = hoten;
            birthday = ngsinh;
            Gtinh = gt;
        }
        /*Khởi tạo sao chép*/
        public Student(Student student)
        {
            this.ID = student.ID;
            this.Name = student.Name;
            this.birthday = student.birthday;
            this.Gtinh = student.Gtinh;
        }
        /*Xuất thông tin*/
        public void Info()
        {
            Console.WriteLine($"MSSV: {ID}");
            Console.WriteLine($"Họ và tên: {Name}");
            Console.WriteLine($"Năm sinh: {birthday}");
            Console.WriteLine($"Giới tinh: {Gtinh}");
        }
    }
}
