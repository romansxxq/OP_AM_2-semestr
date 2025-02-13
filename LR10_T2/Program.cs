using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR10_T2
{
    class Program
    {
        static bool inputInt(ref int i, string povidom)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "";
        //s = i.ToString();
        repeat:
            s = i.ToString();
            s = Interaction.InputBox(povidom, "Введення", s);
            try
            {
                i = Convert.ToInt32(s);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не ціле число." + Strings.Chr(13) + "Бажаєте повторити?", "Увага",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto repeat;
                else
                    return false;
            }
            return true;
        }


        static bool inputDouble(ref double x, string povidom)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "";
            s = x.ToString();
        povtor:
            s = Interaction.InputBox(povidom, "Введення", s);
            try
            {
                x = Convert.ToDouble(s);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не число." + Strings.Chr(13) + "Бажаєте повторити?", "Увага",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto povtor;
                else
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            double x, y, start, step;
            int n;
            start = 2.5;
            step = 1.5;
            n = 5;
            if (!inputDouble(ref start, "Введи x початкове:"))
                return;
            if (!inputDouble(ref step, "Введи крок:"))
                return;
            if (!inputInt(ref n, "Введіть к-сть точок:"))
                return;

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
