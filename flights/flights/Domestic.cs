using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights
{
    public class Domestic:Flight
    {
        public bool food { get; set; }

        public Domestic(bool f, int c, DateTime dep, string des, List<string> p) :base(c, dep, des, p)
        {
            this.food = f;
        }

        public override string GetDisplayText()
        {
            string output = base.GetDisplayText();

            if (food)
            {
                output += " food";
            }
            else
            {
                output += " no food";
            }

            return output;
        }
    }
}
