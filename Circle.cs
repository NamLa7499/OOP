using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Circle
    {
        private double r;

        public double R { get => r; set { if (value < 0) { Console.WriteLine("bán kính không ổn!"); } else { r = value; } } }
        public Circle()
        {
            this.r = 1;
        }
        public Circle(double bankinh)
        {
            this.R = bankinh;
        }
        public double Chuvi()
        {
            return 2 * Math.PI * r;

        }
        public double Dientich()
        {
            return Math.PI * r * r;
        }
        public void Input()
        {
            Console.Write("Nhập bán kính hình tròn: ");
            this.R = double.Parse(Console.ReadLine());

        }
        public void Output()
        {
            Console.WriteLine($"bán kính : {this.r}");
            Console.WriteLine($"Chu Vi: {Chuvi()}");
            Console.WriteLine($"Diện tích: {Dientich()}");
        }
    }
}
