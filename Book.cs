using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Book
    {
        private string maSach, tenSach;
        private int giaSach, giaGiam;
        public Book()
        {
            this.maSach = "N/a";
            this.tenSach = "N/a";
            this.giaSach = 0;
            this.giaGiam = 0;
        }
 

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set { if (value != "") { tenSach = value; } else { tenSach = "N/A"; } } }
        public int GiaSach { get => giaSach; set { if (value > 0) { giaSach = value; } else { Console.WriteLine("giá sách không hợp lệ"); giaSach = 0; } } }
        public int GiaGiam { get => giaGiam; set { if (value < 0 || value > giaSach) { Console.WriteLine("Gia giam khong hop le"); giaGiam = 0; } else { giaGiam = value; } }  }

        public Book(string masach, string tensach, int giasach, int giagiam)
        {
            this.maSach = masach;
            this.tenSach = tensach;
            this.giaSach = giasach;
            this.giaGiam = giagiam;
        }
        public void Input()
        {
            Console.WriteLine("Nhap thong tin sach !!!");
            Console.Write("Ma cuon sach: ");
            this.MaSach = Console.ReadLine();
            Console.Write("Ten cuon sach: ");
            this.TenSach = Console.ReadLine();
            Console.Write("Gia cuon sach: ");
            this.GiaSach = int.Parse(Console.ReadLine());
            Console.Write("Gia giam: ");
            this.GiaGiam = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("----Thông tin cuốn sách--- ");
            Console.WriteLine($"Mã cuốn sách: {this.maSach}");
            Console.WriteLine($"Tên cuốn sách: {this.tenSach}");
            Console.WriteLine($"Giá: {this.giaSach}");
            Console.WriteLine($"Giá giảm: {this.giaGiam}");
            Console.WriteLine($"Thành tiền: {this.giaSach - this.giaGiam}");

        }
    }
}
