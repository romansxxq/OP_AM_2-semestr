using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int n = 10; // Розмір масиву
        double a = 17, b = 80; // Межі діапазону
        double[] mas = new double[n];

        // Заповнюємо масив випадковими числами
        for (int i = 0; i < n; i++)
        {
            mas[i] = a + rnd.NextDouble() * (b - a);
            Console.WriteLine($"mas[{i}] = {mas[i]:F2}");
        }
    }
}
