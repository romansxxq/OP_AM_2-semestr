using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void BubbleSort()
        {
            int[]arr = { 2, 5, 0, 20 };
            for (int i = 0; i < arr.Length - 1; i++) {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }

            }
            
            for (int i = 0;i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();


        }

        public static void Main()
        {
            BubbleSort();
        }

    }
}
