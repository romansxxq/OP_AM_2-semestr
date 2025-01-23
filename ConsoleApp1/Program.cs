using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int count = 0;
                double product = 1.0;
                int n = 1;
                while (count < 7)
                {
                    double value = Math.Tan(n);
                    if (value > 0)
                    {
                        product *= value;
                        count++;
                    }
                    n++;
                    Console.WriteLine("Добуток перших семи додатних елементів послідовності tan(n): " + product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталася помилка: " + ex.Message);
            }
        }
    }
}
