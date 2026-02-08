using System;
namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Rahul", 2453, 500);
            try
            {
                c.Withdraw(450);
            }
            catch (BankException e)
            {
                Console.WriteLine("Transaction Failed");
                e.Inform();
            }
        }
    }
}
