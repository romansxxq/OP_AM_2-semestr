using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        for (int num = 11; num <= 99; num += 2)
        {
            sum += num;
        }
        Console.WriteLine(sum);
    }
}
