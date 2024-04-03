using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights
{
    public class International : Flight
    {
        public bool visa { get; set; }

        public International(bool v, int c, DateTime dep, string des, List<string> p) : base(c,dep,des,p)
        {
            this.visa = v;
        }

        public override string GetDisplayText()
        {
            string output = base.GetDisplayText();

            if (visa)
            {
                output += " visa";
            }
            else
            {
                output += " no visa";
            }

            return output;
        }
    }
}
