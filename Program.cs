using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //cau 1
            //Account a = new Account();
            //Console.WriteLine(a.MaTk);
            //Console.WriteLine(a.SoTien);
            //a.Input();
            //a.Output();
            //cau 2
            //Book b = new Book("as", "b", 1, 1);
            //Console.WriteLine(b.TenSach);
            //b.TenSach = "";
            //Console.WriteLine(b.TenSach);
            //b.Input();
            //b.Output();
            //câu 3
            //Student nam = new Student();
            //nam.InPut();
            //nam.Output();
            //câu 4

            //Circle c = new Circle();
            //c.Output();
            //c.Input();
            //c.Output();
            //câu 5
            //Console.Write("Nhập số hình tròn muốn tạo: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //Circle[] Hinhtrons = new Circle[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Nhập bán kính hình tròn thứ {i + 1}:  ");
            //    Hinhtrons[i] = new Circle(int.Parse(Console.ReadLine()));
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Hình tròn thứ {i + 1}");
            //    Hinhtrons[i].Output();
            //}
            //double max = Hinhtrons[0].Dientich();
            //for (int i = 1; i < n; i++)
            //{
            //    max = Math.Max(max, Hinhtrons[i].Dientich());
            //}
            //Console.WriteLine($"Diện tích lớn nhất: {max}");
            //Câu 6
            //Color hi = new Color(123,122,222,100);
            //Console.WriteLine(hi.Grayscale());
            //Câu 7
            Console.Write("Nhập số bóng: ");
            int.TryParse(Console.ReadLine(), out int n);
            Ball[] ball = new Ball[n];
            for (int i = 0; i < n; i++)
            {
                ball[i] = new Ball();
            }
            Console.WriteLine("Nhập quả bóng 0: ");
            ball[0].Input();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Quả bóng thứ {i}");
                ball[i].Output();
            }

            ball[0].Throw();
            ball[1].Throw();
            ball[0].Pop();
            ball[0].Throw();
            ball[0].Throw();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Kích thước bóng {i} : {ball[i].KichThuoc}");
                Console.WriteLine($"Số lần ném bóng {i}: {ball[i].SoLanNem}");
            }



        }
      
    }
}
