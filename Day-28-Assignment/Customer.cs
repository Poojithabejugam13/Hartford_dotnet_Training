using System;
namespace Bank
{
    class Customer
    {
        string name;
        int accno;
        int balance;
        public Customer(string n, int a, int b)
        {
            name = n;
            accno = a;
            balance = b;        }
        public void Withdraw(int amt)
        {
            if (balance - amt <= 100)
                throw new BankException(accno, balance);

            balance -= amt;
            Console.WriteLine("Withdrawal Successful");
        }
        public int GetBalance()
        {
            return balance;
        }
    }
}
