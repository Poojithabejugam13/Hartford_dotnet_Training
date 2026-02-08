using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of vehicles:");
        int n = int.Parse(Console.ReadLine());
        List<Vehicle> vehicleList = new List<Vehicle>();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            vehicleList.Add(Vehicle.CreateVehicle(input));
        }
        Console.WriteLine("1.Sort by weight");
        Console.WriteLine("2.Sort by parked time");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {           
            vehicleList.Sort();
        }
        else if (choice == 2)
        {
            vehicleList.Sort(new parkedTimeComparer());
        }
        else
        {
            Console.WriteLine("Invalid Choice");
            return;
        }
        Console.Write("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n","Registration No", "Name", "Type", "Weight", "Ticket No");
        foreach (Vehicle v in vehicleList)
        {
            Console.WriteLine("{0,-15} {1,-10} {2,-12} {3,-7:F1} {4}",
                v.RegistrationNo,
                v.Name,
                v.Type,
                v.Weight,
                v.Ticket.TicketNo);
        }
        Console.ReadLine();
    }
}
