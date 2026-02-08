using System;
using System.Collections.Generic;
using System.Linq;
public class VehicleBO
{
    public List<Vehicle> FindVehicle(List<Vehicle> vehicleList, string type)
    {
        return vehicleList
               .Where(v => v.Type.Equals(type))
               .ToList();
    }
    public List<Vehicle> FindVehicle(List<Vehicle> vehicleList, DateTime parkedTime)
    {
        return vehicleList
               .Where(v => v.Ticket.ParkedTime == parkedTime)
               .ToList();
    }
}
