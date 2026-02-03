using System;
using System.Text;

namespace stringbuilder
{
    class StringBuilderr
    {
        static void Main()
        {
            string s1 = "Hello";
            string s2 = "World";

            string result = s1 + " " + s2;
            Console.WriteLine(result);
            Console.WriteLine(result.ToUpper());
            Console.WriteLine("Length = " + result.Length);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");

            Console.WriteLine(sb.ToString());
        }
    }

}
