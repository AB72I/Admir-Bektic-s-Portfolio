using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCompanyEmployees
{
    public class Company
    {
        private List<Employee> employees = null;
        private List<string> projects = null;

        public Company(string n)
        {
            Name = n;
            employees = new List<Employee>();
            projects = new List<string>();
            AddProject("Chess Management");
            AddProject("Squash Management");
            AddProject("Table Tennis Management");
        }

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void AddProject(string p)
        {
            projects.Add(p);
        }

        public List<string> GetProjects()
        {
            return projects;
        }

        public string Name { get; set; }

        public List<string> GetPTEmpNames()
        {
            List<string> ptNames = new List<string>();
            for (int i = 0; i < employees.Count; ++i)
            {
                if (employees[i].GetType() == typeof(PartTimeEmployee))
                {
                    ptNames.Add(employees[i].Name);
                }
            }
            return ptNames;
        }
        public Employee this[string n]
        {
            get
            {
                foreach (Employee e in employees)
                {
                    if (e.Name == n)
                        return e;
                }
                return null;
            }
        }
    }
}
