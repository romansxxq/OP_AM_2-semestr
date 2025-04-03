using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Windows.Forms;

namespace LR12_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Random rand = new Random();
            double a=17,b=80;
            double sum = 0;
            double[] arr = new double[10];

            if (!inputDouble(ref a, "Введіть мін. значення: ","17") || !inputDouble(ref b, "Введіть макс. значення: ","80"))
                return;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = a + rand.NextDouble() * (b - a);
                sum += arr[i];
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("╔═════════╦════════════╗");
            sb.AppendLine("║ Індекс  ║  Значення  ║");
            sb.AppendLine("╠═════════╬════════════╣");

            for (int i = 0; i < arr.Length; i++)
            {
                sb.AppendLine($"║ {i,7}  | {arr[i],10:F2}  ║"); 
            }
            sb.AppendLine("╚═════════╩════════════╝");
            sb.AppendLine($"Сума елементів масиву: {sum:F2}");

            MessageBox.Show(sb.ToString(), "Результати", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static bool inputDouble(ref double num, string mes, string s)
        {
            string input = Interaction.InputBox(mes, "Введення",s);
            return double.TryParse(input, out num);
        }
    }
}
