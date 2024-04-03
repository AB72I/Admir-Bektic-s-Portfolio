using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCompanyEmployees
{
    public abstract class Employee
    {
        public Employee(string n, string p, double s)
        {
            Name = n;
            Project = p;
            Salary = s;
        }
        public string Name { get; set; }

        public string Project { get; set; }

        public double Salary { get; set; }

        public virtual string GetDisplayText() =>
            Name + ", " + Project;

    }
}
