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
        public Ticket(string ticketNo, DateTime parkedTime, double cost)
        {
            TicketNo = ticketNo;
            ParkedTime = parkedTime;
            Cost = cost;
        }

    }
