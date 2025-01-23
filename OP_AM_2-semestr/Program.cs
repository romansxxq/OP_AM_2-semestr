using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_AM_2_semestr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Варіант а)

            double x, y, xStart, xEnd, step;
            Console.WriteLine("Введіть x початкове: ");
            xStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть x кінцеве: ");
            xEnd = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть крок: ");
            step = int.Parse(Console.ReadLine());
            x = step;
            while (x <= xEnd)
            {
                y = (Math.Pow(x, 3) - 3) / (3 * Math.Log(x));
                Console.WriteLine("{0:F2}\t\t{1:F4}", x, y);
                x += step;
            }
            Console.ReadLine();



            //Варіант б)

            //double x, y, xStart, xEnd, step;
            //Console.WriteLine("Введіть x початкове: ");
            //xStart = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введіть x кінцеве: ");
            //xEnd = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введіть крок: ");
            //step = int.Parse(Console.ReadLine());
            //x = step;
            //while (x >= xEnd)
            //{
            //    y = (Math.Pow(x, 3) - 3) / (3 * Math.Log(x));
            //    Console.WriteLine("{0:F2}\t\t{1:F4}", x, y);
            //    x += step;
            //}

        }
    }
}
