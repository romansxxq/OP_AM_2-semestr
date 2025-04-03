using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Windows.Forms;

namespace LR_11_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = UTF8Encoding.UTF8;
        repeat:
            string inputN = Interaction.InputBox("Введіть натуральне число N:", "Введення", "50");
            if (!int.TryParse(inputN, out int N) || N <= 0)
            {
                MessageBox.Show("Введіть коректне натуральне число N.", "Помилка");
                return;
            }

            string inputM = Interaction.InputBox("Введіть натуральне число M:", "Введення", "25");
            if (!int.TryParse(inputM, out int M) || M <= 0)
            {
                MessageBox.Show("Введіть коректне натуральне число M.", "Помилка");
                return;
            }

            string result = "Числа, які відповідають умовам:";
            bool found = false;

            for (int i = 1; i < N; i++)
            {
                int sumOfDigits = 0;
                int num = i;

                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num /= 10;
                }

                if (sumOfDigits * sumOfDigits == M)
                {
                    result += " " + i;
                    found = true;
                }
            }

            if (!found)
            {
                result += " таких чисел немає.";
            }

            DialogResult res = MessageBox.Show(result + "\nБажаєте повторити?", "Результат", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                goto repeat;
            }
        }
    }
}
