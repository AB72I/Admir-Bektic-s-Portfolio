using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation
{
    public class Tester
    {
        public string name { get; set; }
        public int attempts { get; set; }
        public double score { get; set; }


        public Tester()
        {
            this.name = "";
            this.attempts = 1;
            this.score = 1;
        }
    }
}
