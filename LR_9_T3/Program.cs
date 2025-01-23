using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        double x;
        do
        {
            Console.Write("Введіть значення x: ");
        } while (!double.TryParse(Console.ReadLine(), out x));

        double sum = 0;
        int i = 0;
        do
        {
            sum += Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Factorial(2 * i);
            i++;
        } while (i < 8);

        Console.WriteLine($"Сума S = cos(x) = {sum:F4}");
        if (Math.Abs(sum - Math.Cos(x)) < 0.0001)
            Console.WriteLine("Різниця між сумою та cos(x) менша за 0.0001.");
        else
            Console.WriteLine("Різниця між сумою та cos(x) більша за 0.0001.");

        Console.ReadLine();
    }

    static int Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}