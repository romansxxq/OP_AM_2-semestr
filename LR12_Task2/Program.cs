using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    internal class Program
    {
        static int[] ReadIntArr(int n) {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                bool IsValid = false;
                while (!IsValid)
                {
                    string s = Interaction.InputBox($"Введіть число для елемент {i + 1}:", "Введення", "0");
                    if (int.TryParse(s, out arr[i]))
                    {
                        IsValid = true;
                    }
                    else
                    {
                        MessageBox.Show("Некоректне число! Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return arr;
        }
        static int Res(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return (int)(2 * Math.Pow(sum, 2));
        }
        static void Main(string[] args)
        {
            int[] nums = ReadIntArr(7);
            int res = Res(nums);

            MessageBox.Show($"Подвоєний квадрат суми введених чисел дорівнює: {res}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
