using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Account
    {

        private string maTk;

        private int soTien;

        public string MaTk { get => maTk; set => maTk = value; }
        public int SoTien { get => soTien; set { if (value > 0) { soTien = value; } else { Console.WriteLine("Nhap sai so tien!!!"); soTien = 0; } } }
        public Account()
        {
            this.maTk = "N/A";
            this.soTien = 0;
        }

        public void Input()
        {
            Console.Write("Nhap ma tai khoan: ");
            this.MaTk = Console.ReadLine();
            Console.Write("Nhap so tien: ");
            this.SoTien = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Thong tin tai khoan:");
            Console.WriteLine($"Ma tai khoan: {this.MaTk}");
            Console.WriteLine($"So tien: {this.soTien}");
        }
    }
}
