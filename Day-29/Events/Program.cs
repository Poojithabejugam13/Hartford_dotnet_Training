using System.Numerics;
using System;
namespace Events
{
    class MeltdownEventArgs : EventArgs
    {
        private string message;
        public MeltdownEventArgs(string message)
        {

            this.message = message;
        }
        public string Message
        {
            get
            {
                return message;
            }
        }
    }
 
    class Reactor
    {
        private int temperature;
        public delegate void MeltdownHandler(
        object reactor, MeltdownEventArgs myMEA);
        public event MeltdownHandler OnMeltdown;
        public int Temperature
        {
            set
            {
                temperature = value;
                if (temperature > 1000)
                {
                    MeltdownEventArgs myMEA = new
                    MeltdownEventArgs("Reactor meltdown in progress!");
                    OnMeltdown(this, myMEA);
                }
            }
        }
    }
    class ReactorMonitor
    {
        public ReactorMonitor(Reactor myReactor)
        {
            myReactor.OnMeltdown +=
            new Reactor.MeltdownHandler(DisplayMessage);
        }
        public void DisplayMessage(object myReactor,
        MeltdownEventArgs myMEA)
        {
            Console.WriteLine(myMEA.Message);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Reactor myReactor = new Reactor();
            ReactorMonitor myReactorMonitor =
            new ReactorMonitor(myReactor);
            Console.WriteLine("Setting reactor temperature to 100 degrees Centigrade");
            myReactor.Temperature = 100;
            Console.WriteLine("Setting reactor temperature to 500 degrees Centigrade");
            myReactor.Temperature = 500;
            Console.WriteLine("Setting reactor temperature to 2000 degrees Centigrade");
            myReactor.Temperature = 2000;
        }
    }
}
