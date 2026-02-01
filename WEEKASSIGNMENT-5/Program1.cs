namespace weeklyassignment5
{
    internal class Program
    {
            public static void Main()
            {
                int N = int.Parse(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    int term = i * (i + 1) * (i + 2);
                    Console.Write(term + " ");
                }
            }
        }

    }
