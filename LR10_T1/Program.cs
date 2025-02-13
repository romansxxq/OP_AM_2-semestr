using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y,start,step;
            Console.Write("Введи значення для x: ");
            start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введи крок: ");
            step = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи к-сть точок: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x\t\t y");
            for (int i = 1; i < n; i++)
            {
                x = start + i * step;
                y = (Math.Pow(x, 3) - 3) / (3 * Math.Log(x));
                Console.WriteLine("{0:F2}\t {1:F4}", x, y);
            }
            Console.ReadKey();
        }
    }
}
