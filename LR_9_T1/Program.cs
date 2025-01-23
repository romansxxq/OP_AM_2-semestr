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
            // Варіант (а)
            double x, y, xStart, xEnd, step;

            Console.WriteLine("Введіть x початкове: ");
            xStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть x кінцеве: ");
            xEnd = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть крок: ");
            step = int.Parse(Console.ReadLine());
            Console.WriteLine("x                y");
            x = xStart;
            while (x <= xEnd)
            {
                y = (Math.Pow(x, 2) - 3) / (3 * Math.Log(x));
                Console.WriteLine("{0:F2}\t\t{1:F4}", x, y);
                x += step;
            }

            // Варіант (б)
            //Console.WriteLine("\nВаріант (б):");
            //xStart = 2.5;
            //dx = 1.5;
            //int n = 5; // кількість ітерацій
            //x = xStart;
            //int iteration = 0;
            //Console.WriteLine("x\t\tY");
            //while (iteration < n)
            //{
            //    double y = (Math.Pow(x, 2) - 3) / (3 * Math.Log(x));
            //    Console.WriteLine("{0:F2}\t\t{1:F4}", x, y);
            //    x += dx;
            //    iteration++;
            //}

            Console.ReadKey();
        }
    }
}
