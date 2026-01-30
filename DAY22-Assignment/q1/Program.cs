
using System;
namespace q1
{
    internal class Program
    {
        public static void swapNumbers()
        {
            int num1, num2, temp;
            Console.Write("\nEnter First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
        }
        public static float sumOfTwoNumbers(float a, float b)
        {
            return a + b;
        }
        public static void averageOfNumbers() {
            Console.WriteLine("\nenter first number");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("enter Second number");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("enter Third number");
            float c= float.Parse(Console.ReadLine());
            Console.WriteLine("enter Fourth number");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("Average is" + (a + b + c + d) / 4 );

        }
        public static void Age()
        {
            Console.WriteLine("\nenter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nYou look younger than {0} ", age);
        }
        public static void remove_char(string str, int n)
        {
            Console.Write("\nremoved char"+str.Remove(n, 1));  
       
        }
        public static void Main(string[] args)
        {
            swapNumbers();
            Console.WriteLine("\nenter first number to add");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("enter Second number to add");
            float y = float.Parse(Console.ReadLine());
            float a = sumOfTwoNumbers(x, y);
            Console.WriteLine("Sum is" + a);
            averageOfNumbers();
            Age();
            remove_char("w3resource", 2);
         
        }

    }
}

