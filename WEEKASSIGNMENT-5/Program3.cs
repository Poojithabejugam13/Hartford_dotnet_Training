using System;
using SalaryCalculator;
namespace weekly_assignment5_q3
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Basic Salary: ");
                double basicSalary = double.Parse(Console.ReadLine());
                double netSalary = Salary.CalculateNetSalary(basicSalary);
                Console.WriteLine("\nEmployee Name: " + name);
                Console.WriteLine("Net Salary: " + netSalary);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
