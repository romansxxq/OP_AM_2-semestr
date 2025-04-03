using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR12_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rand = new Random();
            int a = 17, b = 80;
            int[] arr = new int[10];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(a,b + 1);
                sum += arr[i];
            }

            Console.WriteLine("╔═════════╦════════════╗");
            Console.WriteLine("║ Індекс  ║  Значення  ║");
            Console.WriteLine("╠═════════╬════════════╣");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("║ {0,7} | {1,10} ║", i, arr[i]);
            }
            Console.WriteLine("╚═════════╩════════════╝");
            Console.WriteLine("Сума елементів масиву: " + sum);
            Console.ReadKey();

        }
    }
}
