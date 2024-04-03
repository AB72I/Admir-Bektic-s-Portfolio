using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCompanyEmployees
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string n, string p, double s) : base(n, p, s)
        {
        }

        public override string GetDisplayText() =>
           base.GetDisplayText() + ", " + Salary + "/hour";

    }
}
