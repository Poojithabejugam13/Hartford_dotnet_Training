using System;
using System.Collections.Generic;
public class parkedTimeComparer : IComparer<Vehicle>
{
    public int Compare(Vehicle v1, Vehicle v2)
    {
        return v1.Ticket.ParkedTime.CompareTo(v2.Ticket.ParkedTime);
    }
}
