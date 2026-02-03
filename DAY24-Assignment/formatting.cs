//formatting
using System;

namespace formatting
{
    class Program
    {
        static void Main()
        {
            int marks = 456;
            int total = 500;
            double percentage = (marks * 100.0) / total;
            Console.WriteLine("Marks : {0}/{1}", marks, total);
            Console.WriteLine("Percentage : {0:F2}%", percentage);
            string name = "Ravi";
            int age = 22;
            double salary = 45000.5;

            string result = String.Format(
                "Name: {0}, Age: {1}, Salary: {2:F2}",
                name, age, salary
            );

            Console.WriteLine(result);
        }
    }

}
