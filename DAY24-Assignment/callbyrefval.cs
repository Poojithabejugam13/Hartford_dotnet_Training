namespace callbyfunctindifference
{
    using System;

    class Program
    {
        static void ChangeValue(int x)
        {
            x = 100;
        }

        static void ChangeReference(ref int x)
        {
            x = 100;
        }

        static void Main()
        {
            int num1 = 10;
            int num2 = 10;

            ChangeValue(num1);
            ChangeReference(ref num2);

            Console.WriteLine("After Call by Value: " + num1);
            Console.WriteLine("After Call by Reference: " + num2);
        }
    }
}