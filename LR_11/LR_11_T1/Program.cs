using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text, res = "";
            text = Console.ReadLine();

            foreach (char c in text)
            {
                res += c + "?";
            }
            Console.WriteLine(res);
        }
    }
}
