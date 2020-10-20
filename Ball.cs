using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Ball
    {
        private Color color;
        private int soLanNem;
        private double kichThuoc;

        public int SoLanNem { get => soLanNem; set { if (value >= 0 ) { soLanNem = value; } else { soLanNem = 0; } } }
        public double KichThuoc { get => kichThuoc; set { if (value >= 0) { kichThuoc = value; } else { kichThuoc = 1; } } }
        internal Color Color { get => color; set => color = value; }
        public Ball()
        {
            this.color = new Color();
            this.SoLanNem = 0;
            this.kichThuoc = 1;
        }
        public Ball(Color cl, int slNem, double size)
        {
            this.color = cl;
            this.SoLanNem = slNem;
            this.kichThuoc = size;
        }
        public void Pop()
        {
            this.kichThuoc = 0;
        }
        public void Throw()
        {
            if (this.kichThuoc == 0)
            {
                Console.WriteLine("Bóng đã nổ");
                return;
            }
            else { this.soLanNem += 1; }
        }
        public void Input()
        {
            Console.Write("Nhập kích thước: ");
            this.kichThuoc = double.Parse(Console.ReadLine());
            Console.Write("Nhập số lần ném: ");
            this.soLanNem = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập màu trái bóng: ");
            Color a = new Color();
            a.Input();
            this.color = a;
        }
        public void Output()
        {
            Console.WriteLine($"kích thước: {kichThuoc}");
            Console.WriteLine($"Số lần ném : {soLanNem}");
            Console.WriteLine($"màu Grayscale: {color.Grayscale()}");
        }

    }
}
