using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter Vehicle 1 details:");
            string[] v1 = Console.ReadLine().Split(',');
            Ticket t1 = new Ticket(
                v1[4],
                DateTime.Parse(v1[5]),
                double.Parse(v1[6])
            );
            Vehicle vehicle1 = new Vehicle(
                v1[0],
                v1[1],
                v1[2],
                double.Parse(v1[3]),
                t1
            );
            Console.WriteLine("Enter Vehicle 2 details:");
            string[] v2 = Console.ReadLine().Split(',');
            Ticket t2 = new Ticket(
                v2[4],
                DateTime.Parse(v2[5]),
                double.Parse(v2[6])
            );
            Vehicle vehicle2 = new Vehicle(
                v2[0],
                v2[1],
                v2[2],
                double.Parse(v2[3]),
                t2
            );
            // Output
            Console.WriteLine();
            Console.WriteLine("Vehicle 1");
            Console.WriteLine(vehicle1);
            Console.WriteLine();
            Console.WriteLine("Vehicle 2");
            Console.WriteLine(vehicle2);
            Console.WriteLine();
            if (vehicle1.Equals(vehicle2))
                Console.WriteLine("Vehicle 1 is same as Vehicle 2");
            else
                Console.WriteLine("Vehicle 1 and Vehicle 2 are different");  
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);  
        }
        finally
        {
            Console.ReadLine();
        }
    }
}
