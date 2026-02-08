using System;
using System.Collections.Generic;
public class ParkingLot
{
    private string _name = default!;
    private List<Vehicle> _vehicleList;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public List<Vehicle> VehicleList
    {
        get { return _vehicleList; }
        set { _vehicleList = value; }
    }
    public ParkingLot()
    {
        _vehicleList = new List<Vehicle>();
    }
    public ParkingLot(string _name, List<Vehicle> _vehicleList)
    {
        this._name = _name;
        this._vehicleList = new List<Vehicle>(); 
    }
    public void AddVehicleToParkingLot(Vehicle vehicle)
    {
        _vehicleList.Add(vehicle);
    }
    public bool RemoveVehicleFromParkingLot(string registrationNo)
    {
        foreach (Vehicle v in _vehicleList)
        {
            if (v.RegistrationNo.Equals(registrationNo))
            {
                _vehicleList.Remove(v);
                return true;
            }
        }
        return false;
    }
    public void DisplayVehicles()
    {
        if (_vehicleList.Count == 0)
        {
            Console.WriteLine("No vehicles to show");
            return;
        }
        Console.WriteLine("Vehicles in " + _name);
        Console.Write("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n","Registration No", "Name", "Type", "Weight", "Ticket No");
        foreach (Vehicle v in _vehicleList)
        {
            Console.WriteLine("{0,-15} {1,-10} {2,-12} {3,-7:F1} {4}",
                v.RegistrationNo,
                v.Name,
                v.Type,
                v.Weight,
                v.Ticket.TicketNo
            );
        }
    }
}
