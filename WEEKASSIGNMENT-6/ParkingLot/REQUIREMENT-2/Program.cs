using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the name of the Parking Lot:");
        string name = Console.ReadLine() ?? "";
        ParkingLot parkingLot = new ParkingLot(name, new List<Vehicle>());
        while (true)
        {
            Console.WriteLine("1.Add Vehicle");
            Console.WriteLine("2.Delete Vehicle");
            Console.WriteLine("3.Display Vehicles");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your choice:");
            int choice = int.Parse(Console.ReadLine() ?? "0");
            switch (choice)
            {
                case 1:
                    string detail = Console.ReadLine() ?? "";
                    Vehicle vehicle = Vehicle.CreateVehicle(detail);
                    parkingLot.AddVehicleToParkingLot(vehicle);
                    Console.WriteLine("Vehicle successfully added");
                    break;
                case 2:
                    Console.WriteLine("Enter the registration number of the vehicle to be deleted:");
                    string regNo = Console.ReadLine() ?? "";
                    bool removed = parkingLot.RemoveVehicleFromParkingLot(regNo);
                    Console.WriteLine(removed?"Vehicle successfully deleted":"Vehicle not found in parkinglot");
                    break;
                case 3:
                    parkingLot.DisplayVehicles();
                    break;
                case 4:
                    return;
            }
        }
    }
}
