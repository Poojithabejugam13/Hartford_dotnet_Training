using System;
public class Ticket
{
    private string _ticketNo;
    private DateTime _parkedTime;
    private double _cost;
    public string TicketNo
    {
        get { return _ticketNo; }
        set { _ticketNo = value; }
    }
    public DateTime ParkedTime
    {
        get { return _parkedTime; }
        set { _parkedTime = value; }
    }
    public double Cost
    {
        get { return _cost; }
        set { _cost = value; }
    }
    public Ticket() { }
    public Ticket(string _ticketNo, DateTime _parkedTime, double _cost)
    {
        this._ticketNo = _ticketNo;
        this._parkedTime = _parkedTime;
        this._cost = _cost;
    }
}
