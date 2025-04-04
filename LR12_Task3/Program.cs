//using Microsoft.VisualBasic;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace LR12_Task3
//{
//    internal class Program
//    {
//        static List<int> FindPositions(int[] arr, int target)
//        {
//            List<int> pos = new List<int>();
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] == target)
//                    pos.Add(i);
//            }
//            return pos;
//        }
//        static bool inputInt(ref int num, string mes, string s)
//        {
//            string input = Interaction.InputBox(mes, "Введення", s);
//            return int.TryParse(input, out num);
//        }
//        static void ShowMessage(string message, string title, MessageBoxIcon icon)
//        {
//            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
//        }
//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 5, 5, 10, 9, 30 };
//            int target = 0;

//            if (inputInt(ref target, "Введіть число для пошуку:", "5"))
//            {
//                List<int> pos = FindPositions(arr, target);

//                if (pos.Count > 0)
//                    MessageBox.Show($"Число {target} знайдено на позиціях: {string.Join(", ", pos)}", "Результати", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                else
//                    MessageBox.Show($"Число {target} не знайдено в масиві.", "Результати", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            }
//            else
//                MessageBox.Show($"Число {target} не знайдено в масиві.", "Результати", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//    }
//}
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR12_Task3
{
    internal class Program
    {
        static List<int> FindPositions(int[] arr, int target)
        {
            List<int> pos = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    pos.Add(i);
            }
            return pos;
        }

        static bool inputInt(ref int num, string mes, string s)
        {
            string input = Interaction.InputBox(mes, "Введення", s);
            return int.TryParse(input, out num);
        }

        static void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 5, 10, 9, 30, 5 };
            int target = 0;

            bool isValidInput = inputInt(ref target, "Введіть число для пошуку:", "5");

            ShowMessage(isValidInput && target != 0
                ? (FindPositions(arr, target).Count > 0
                    ? $"Число {target} знайдено на позиціях: {string.Join(", ", FindPositions(arr, target))}"
                    : $"Число {target} не знайдено в масиві.")
                : "Невірний ввід. Будь ласка, введіть правильне ціле число.",
                "Результати",
                isValidInput && target != 0 ? (FindPositions(arr, target).Count > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Warning) : MessageBoxIcon.Error);
        }
    }
}
