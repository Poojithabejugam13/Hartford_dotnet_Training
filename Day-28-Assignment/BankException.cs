using System;
namespace Bank
{
    class BankException : Exception
    {
        int acc;
        int bal;
        public BankException(int a, int b)
        {
            acc = a;
            bal = b;
        }
        public void Inform()
        {
            Console.WriteLine("Account Number:"+acc +"\nBalance left:"+bal);
        }
    }
}
