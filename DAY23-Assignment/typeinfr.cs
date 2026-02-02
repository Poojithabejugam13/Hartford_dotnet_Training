//typeinference
using System;

class Program
{
    static void Main()
    {
        var number = 100;
        var name = "CSharp";
        var price = 99.99;

        Console.WriteLine(number.GetType());
        Console.WriteLine(name.GetType());
        Console.WriteLine(price.GetType());
    }
}
