using System;
using System.Globalization;
public class Vehicle
{
    private string _registrationNo;
    private string _name;
    private string _type;
    private double _weight;
    private Ticket _ticket;
    public string RegistrationNo
    {
        get { return _registrationNo; }
        set { _registrationNo = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }
    public double Weight
    {
        get { return _weight; }
        set { _weight = value; }
    }
    public Ticket Ticket
    {
        get { return _ticket; }
        set { _ticket = value; }
    }
    public Vehicle() { }
    public Vehicle(string _registrationNo, string _name, string _type,
                   double _weight, Ticket _ticket)
    {
        this._registrationNo = _registrationNo;
        this._name = _name;
        this._type = _type;
        this._weight = _weight;
        this._ticket = _ticket;
    }
    public static Vehicle CreateVehicle(string detail)
    {
        string[] data = detail.Split(',');

        string regNo = data[0];
        string name = data[1];
        string type = data[2];
        double weight = double.Parse(data[3]);
        string ticketNo = data[4];
        DateTime parkedTime = DateTime.ParseExact(
            data[5],
            "dd-MM-yyyy HH:mm:ss",
            null
        );
        double cost = double.Parse(data[6]);
        Ticket ticket = new Ticket(ticketNo, parkedTime, cost);
        return new Vehicle(regNo, name, type, weight, ticket);
    }
}
