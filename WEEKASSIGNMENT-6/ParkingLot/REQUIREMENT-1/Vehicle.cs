using System;
    class Vehicle
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
        public Vehicle(string registrationNo, string name, string type,
                       double weight, Ticket ticket)
        {
            RegistrationNo = registrationNo;
            Name = name;
            Type = type;
            Weight = weight;
            Ticket = ticket;
        }
        public override string ToString()
        {
            return "Registration No:" + _registrationNo + "\n" +
                   "Name:" + _name + "\n" +
                   "Type:" + _type + "\n" +
                   "Weight:" + _weight.ToString("0.0") + "\n" +
                   "Ticket No:" + _ticket.TicketNo;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Vehicle))
                return false;

            Vehicle other = (Vehicle)obj;

            return string.Equals(_registrationNo.ToLower(), other._registrationNo.ToLower())
                && string.Equals(_name.ToLower(), other._name.ToLower());
        }

        public override int GetHashCode()
        {
            return (_registrationNo.ToLower() + _name.ToLower()).GetHashCode();
        }
    }

