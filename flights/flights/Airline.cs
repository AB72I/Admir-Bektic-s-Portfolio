using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights
{
    public class Airline
    {
        public string name { get; set; }
        private List<Flight> flights = new List<Flight>();

        public Airline(string n)
        {
            List<string> passengers = new List<string>();
            International Portugal = new International(true, 7, DateTime.Parse("12/1/2022"), "Portugal", passengers);
            International Argentina = new International(false, 10, DateTime.Parse("12/7/2022"), "Argentina", passengers);
            Domestic NewYork = new Domestic(false, 2, DateTime.Parse("12/8/2022"), "New York", passengers);
            Domestic SanFransico = new Domestic(true, 3, DateTime.Parse("12/2/2022"), "San Fransico", passengers);

            name = n;

            flights.Add(Portugal);
            flights.Add(Argentina);
            flights.Add(NewYork);
            flights.Add(SanFransico);
        }

        public List<Flight> GetFlights()
        {
            return flights;
        }
    }
}
