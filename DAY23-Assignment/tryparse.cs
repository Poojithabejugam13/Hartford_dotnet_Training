//tryparse
using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter value {i}: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                sum += num;
            }
            else
            {
                Console.WriteLine("Invalid integer, skipped.");
            }
        }
        Console.WriteLine("Sum = " + sum);
    }
}
