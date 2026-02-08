using System;
using System.Text.RegularExpressions;
namespace REQUIREMENT_3
{
    public class Program
    {
        static bool ValidateRegistrationNo(string registrationNo)
        {
            string pattern = @"^[A-Z]{2}\s\d{1,2}(\s[A-Z]{1,2})?\s\d{1,4}$";
            return Regex.IsMatch(registrationNo, pattern);
        }
        public static void Main()
        {
            Console.WriteLine("Enter the registration no. to be validated:");
            string regNo = Console.ReadLine();

            if (ValidateRegistrationNo(regNo))
                Console.WriteLine("Registration No. is valid");
            else
                Console.WriteLine("Registration No. is invalid");
            Console.ReadLine();
        }
    }

}
