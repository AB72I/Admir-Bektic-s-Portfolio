using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation
{
    public class Words
    {
        public string american { set; get; }
        public string english { set; get; }

        public Words()
        {
            this.american = "";
            this.english = "";
        }
    }
}
