using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCompanyEmployees
{
    public class FullTimeEmployee : Employee
    {
        private List<string> managedEmployees;

        public FullTimeEmployee(string n, string p, double s) : base(n, p, s)
        {
            managedEmployees = new List<string>();
        }
        
        public List<string> GetManagedEmps()
        {
            return managedEmployees;
        }

        public void SetManagedEmps(List<string> m)
        {
            managedEmployees = m;
        }
        
       // public List<string> ManagedEmps() { get; set; }

        public void AddEmployee(string n)
        {
            managedEmployees.Add(n);
        }

        public void RemoveEmployee(string n)
        {
            managedEmployees.Remove(n);
        }

        public override string GetDisplayText()
        {
            string output = "";
            output += base.GetDisplayText() + ", " + Salary + "/year";
            for (int i = 0; i < managedEmployees.Count; ++i)
            {
                output += ", " + managedEmployees[i];
            }
            return output;
        }
    }
}
