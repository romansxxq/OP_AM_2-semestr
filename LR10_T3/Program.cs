using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR10_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.UTF8;
        repeat:
            int n;
            string S;
            S = Interaction.InputBox("Введіть натуральне число", "Введення", "36");
            while (!int.TryParse(S, out n) || n <= 0)
            {
                if (MessageBox.Show("Ви ввели не натуральне число." + Strings.Chr(13) + "Бажаєте повторити?", "Увага",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto repeat;
                else
                    return;
            }
            StringBuilder res = new StringBuilder();
            for (int i = 0; i <= n; i++)
            {
                if (i % 6 == 0)
                {
                    res.Append(i.ToString() + " ");
                }
            }
            if (MessageBox.Show($"Кратні 6: {res.ToString()}\nБажаєте повторити?", "Результат",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                goto repeat;
            else
                return;
            Console.ReadKey();
        }
    }
}
