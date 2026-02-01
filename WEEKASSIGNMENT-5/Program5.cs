using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter your weight:");
        int weight = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (weight < 0 || weight > 120)
        {
            Console.WriteLine("Invalid Input");
        }
        else if (weight <= 48)
        {
            Console.WriteLine("light fly");
        }
        else if (weight <= 51)
        {
            Console.WriteLine("fly");
        }
        else if (weight <= 54)
        {
            Console.WriteLine("bantam");
        }
        else if (weight <= 57)
        {
            Console.WriteLine("feather");
        }
        else if (weight <= 60)
        {
            Console.WriteLine("light");
        }
        else if (weight <= 64)
        {
            Console.WriteLine("light welter");
        }
        else if (weight <= 69)
        {
            Console.WriteLine("welter");
        }
        else if (weight <= 75)
        {
            Console.WriteLine("light middle");
        }
        else if (weight <= 81)
        {
            Console.WriteLine("middle");
        }
        else if (weight <= 91)
        {
            Console.WriteLine("light heavy");
        }
        else
        {
            Console.WriteLine("heavy");
        }
    }
}
