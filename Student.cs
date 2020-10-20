using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Student
    {
        private string maSinhVien, tenSinhVien, diaChi;
        private int namSinh;

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string TenSinhVien { get => tenSinhVien; set { if (value == "") { Console.WriteLine("Tên không hợp lệ!"); tenSinhVien = "N/a"; } else { tenSinhVien = value; } } }
        public string DiaChi { get => diaChi; set { if (value == "") { Console.WriteLine("địa chỉ không hợp lệ");diaChi = "N/a"; } else { diaChi = value; } } }
        public int NamSinh { get => namSinh; set {
                if (value < 0) { Console.WriteLine("Năm sinh không hợp lệ (chuyển về 1999 )"); namSinh = 1999; } else { namSinh = value; } 
            }
            
        }
        public Student()
        {
            this.maSinhVien = "N/a";
            this.tenSinhVien = "N/a";
            this.diaChi = "N.a";
            this.namSinh = 1999;
        }
        public Student(string maSv, string tenSv, int namSinh, string diachi)
        {
            this.namSinh = namSinh;
            this.maSinhVien = maSv;
            this.tenSinhVien = tenSv;
            this.diaChi = diachi;
        }
        public void InPut()
        {
            Console.WriteLine("Nhập thông tin sinh viên !!!");
            Console.Write("Mã số sinh viên: ");
            this.MaSinhVien = Console.ReadLine();
            Console.Write("Ten sinh viên: ");
            this.TenSinhVien = Console.ReadLine();
            Console.Write("Năm sinh: ");
            this.NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Địa chỉ: ");
            this.DiaChi = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("---Thông tin sinh viên----");
            Console.WriteLine($"Tên sinh viên: {this.tenSinhVien}");
            Console.WriteLine($"Mã số sinh viên: {this.maSinhVien}");
            Console.WriteLine($"Năm sinh: {this.namSinh}");
            Console.WriteLine($"Địa chỉ: {this.diaChi}");
        }
    }
}
