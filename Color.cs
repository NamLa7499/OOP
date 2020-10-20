using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Color
    {
        private int red, green, blue, alpha;

        public int Red { get => red; set { if (value >= 0 && value <= 255) { red = value; } else { red = 0; } } }
        public int Green { get => green; set { if (value >= 0 && value <= 255) { green = value; } else { green = 0; } } }
        public int Blue { get => blue; set { if (value >= 0 && value <= 255) { blue = value; } else { blue = 0; } } }
        public int Alpha { get => alpha; set { if (value >= 0 && value <= 255) { alpha = value; } else { alpha = 0; } } }

        public Color()
        { } 
        public Color(int red, int green, int blue, int alpha)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }
        public Color(Color color)
        {
            this.Red = color.Red;
            this.Green = color.Green;
            this.Blue = color.Blue;
            this.Alpha = color.Alpha;
        }
        public int Grayscale()
        {
            return ((red + green + blue) / 3);
        }
        public void Input()
        {
            Console.Write("Nhập giá trị Red: ");
            this.Red = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị Green: ");
            this.Green = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị Blue: ");
            this.Blue = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị Alpha: ");
            this.Alpha = int.Parse(Console.ReadLine());

        }


    }
}
