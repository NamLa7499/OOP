using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Customer
    {
        private string maKhachHang;
        private int id;
        private string diaChi;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int Id { get => id; set => id = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public Customer()
        {
            MaKhachHang = "N/a";
            Id = 99999999;
            DiaChi = "N/a";
        }
    }
}
