using System;
namespace Day_29
{
    delegate void Print();
    class Money
    {
        protected uint note;
        protected uint coin;
        public Money(uint n, uint c)
        {
            note = n;
            coin = c;
        }
    }
    class Rupee : Money
    {
        public Rupee(uint rupees, uint paise) : base(rupees, paise) { }
        public void Display()
        {
            Console.WriteLine("Rs. {0}.{1}", note, coin);
        }
    }
    class Dollar : Money
    {
        public Dollar(uint dollar, uint cent) : base(dollar, cent) { }
        public void Info()
        {
            Console.WriteLine("${0}.{1}", note, coin);
        }
    }
    class Euro : Money
    {
        public Euro(uint euro, uint cent) : base(euro, cent) { }
        public void Show()
        {
            Console.WriteLine("Euro {0}.{1}", note, coin);
        }
    }
    class Test
    {
        static void Main()
        {
            Rupee m1 = new Rupee(1000, 55);
            Dollar m2 = new Dollar(100, 75);
            Euro m3 = new Euro(80, 40);
            Print[] p = new Print[3];
            p[0] = new Print(m1.Display);
            p[1] = new Print(m2.Info);
            p[2] = new Print(m3.Show);
            Write(p);
        }
        static void Write(Print[] p)
        {
            foreach (Print item in p)
            {
                item();
            }
        }
    }
}
