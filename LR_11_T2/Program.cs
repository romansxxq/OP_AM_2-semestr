using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_11_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        repeat:
            string S;
            int count = 0;
            int sum = 0;
            for (int i = 1; i <= 12; i++) {
               
                S = Interaction.InputBox($"Введіть свою стипендію за {i} місяць", "Введення", "");

                if (string.IsNullOrEmpty(S)) {
                    break;
                }

                if (int.TryParse(S, out int stipend))
                {

                    if (stipend >= 50)
                    {
                        count++;
                        sum += stipend;
                    }
                    else
                    {
                        MessageBox.Show("Ви ввели стипендію менше 50 гривнів", "Введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i--;
                        sum -= stipend;
                    }
                }
                else
                {
                    MessageBox.Show("Введіть правильне значення", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    i--;
                }
            }
            if (count > 0)
            {
                DialogResult res = MessageBox.Show($"Кількість місяців зі стипендією понад 50 грн.: {count}\nЗагальна сума стипендії: {sum} грн.\nБажаєте повторити?", "Результат", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    goto repeat;
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show($"Стипендія відсутня", "Результат");
            }
        }
    }
}
