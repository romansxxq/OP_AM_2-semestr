using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_9_T2
{
    class Program
    {
        static bool inputInt(ref int i, string povidom)
        {
            string s;
            s = i.ToString();
        povtor:
            s = Interaction.InputBox(povidom, "Введення", s);
            try
            {
                i = Convert.ToInt32(s);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("Ви ввели не ціле число." + Strings.Chr(13) + "Бажаєте повторити?", "Увага",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto povtor;
                else
                    return false;
            }
            return true;
        }


        static bool inputDouble(ref double x, string povidom)
        {
            string s;
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
            int n, i;
            double x, y, xp, dx;
            xp = 2.5;
            dx = 1.5;
            n = 5;
            if (!inputDouble(ref xp, "Введіть x початкове:"))
                return;
            if (!inputDouble(ref dx, "Введіть крок:"))
                return;
            if (!inputInt(ref n, "Введіть кількість точок:"))
                return;

            string rez = "x\t\ty\n";
            x = xp;
            i = 0;
            while (i < n)
            {
                y = (x + Math.Cos(2 * x)) / (3 * x);
                rez += x.ToString() + "\t" + y.ToString() + "\n";
                x += dx;
                i++;
            }
            MessageBox.Show(rez, "Результати табулювання");
        }
    }


}
