using System;

class ElectricityBill
{
    static void Main()
    {
        Console.Write("Customer Id: ");
        string customerId = Console.ReadLine();
        Console.Write("Customer Name: ");
        string name = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phone = Console.ReadLine();
        Console.Write("Email Id: ");
        string email = Console.ReadLine();
        Console.Write("Connection Type (Industrial/Business/Domestic/Agricultural): ");
        string type = Console.ReadLine();
        Console.Write("Previous Reading: ");
        int previous = int.Parse(Console.ReadLine());
        Console.Write("Current Reading: ");
        int current = int.Parse(Console.ReadLine());
        int units = current - previous;
        double energyCharge = CalculateCharge(units);
        double meterRent = GetMeterRent(type);
        double totalAmount = energyCharge + meterRent;
        Console.WriteLine("\nElectricity Bill");
        Console.WriteLine("Customer Id:"+customerId);
        Console.WriteLine("Customer Name:"+name);
        Console.WriteLine("Address:"+address);
        Console.WriteLine("Phone Number:"+phone);
        Console.WriteLine("Email Id:"+email);
        Console.WriteLine("Connection Type:"+type);
        Console.WriteLine("Units Consumed:"+units);
        Console.WriteLine("Energy Charges:"+energyCharge);
        Console.WriteLine("Meter Rent:"+meterRent);
        Console.WriteLine("Total Amount:"+totalAmount);
    }
    static double CalculateCharge(int units)
    {
        double amount=0;
        if (units<=100)
            amount=units*1.5;
        else if(units<=250)
            amount=100*1.5+(units-100)*2.5;
        else if(units <= 550)
            amount=100*1.5+150*2.5+(units-250)*4.5;
        else
            amount=100*1.5+150*2.5+300*4.5+(units-550)*7.5;
        return amount;
    }

    static double GetMeterRent(string type)
    {
        if (type.Equals("Industrial", StringComparison.OrdinalIgnoreCase))
            return 2500;
        else if (type.Equals("Business", StringComparison.OrdinalIgnoreCase))
            return 1500;
        else if (type.Equals("Domestic", StringComparison.OrdinalIgnoreCase))
            return 1000;
        else
            return 0;
    }
}
