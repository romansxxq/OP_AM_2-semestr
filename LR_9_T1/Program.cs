using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_9_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double x, y, xStart, xEnd, step;
            Console.WriteLine("Введіть x початкове: ");
            xStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть x кінцеве: ");
            xEnd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть крок: ");
            step = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x                y");
            x = xStart;
            while (x <= xEnd)
            {
                y = (Math.Pow(x, 2) - 3) / (3 * Math.Log(x));
                Console.WriteLine("{0:F2}\t\t{1:F4}", x, y);
                x += step;
            }
            Console.ReadKey();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LR9
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double x, y, xp, xk, dx;
//            Console.Write("Введіть x початкове: ");
//            xp = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Введіть x кінцеве: ");
//            xk = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Введіть крок: ");
//            dx = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("x\t\t y");
//            x = xp;
//            while (x <= xk)
//            {
//                y = (1.9 * x - Math.Log(3 * x)) / (3 * x + 1);
//                Console.WriteLine("{0:F2}\t {1:F4}", x, y);
//                x += dx;
//            }
//            Console.ReadKey();
//        }
//    }
//}
