using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights
{
    public class Flight
    {
        public int Code { get; set; }
        public DateTime Departure { get; set; }
        public string Destination { get; set; }
        private List<string> passengers = null;

        public Flight(int c, DateTime dep, string des, List<string> p)
        {
            Code = c;
            Departure = dep;
            Destination = des;
            this.passengers = p;
        }

        public virtual string GetDisplayText() =>
            Code + ", " + Destination + ", " + Departure;

        public void AddPassenger(string p)
        {
            passengers.Add(p);
        }

        public List<string> GetPassengers()
        {
            return passengers;
        }

        public int GetPassengerCount()
        {
            return passengers.Count;
        }
    }
}
