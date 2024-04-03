using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;

namespace ManageCompany
{
    class Company
    {
        private List<Employee> employees;
        public Company(string n, string a)
        {
            Name = n;
            Address = a;
            employees = new List<Employee>();
            LatestID = 0;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public static int LatestID { get; set; }

        public void SortEmployees()
        {
            employees.Sort();
        }
        public int NumEmployees
        {
            get
            {
                return employees.Count;
            }
        }

        public void AddEmployee(Employee e)
        {
            LatestID += 10;
            e.Id = LatestID;
            employees.Add(e);
        }

        public void AddEmployee(string name, DateTime date)
        {
            LatestID += 10;
            Employee emp = new Employee(name, date, LatestID);
            employees.Add(emp);
        }
        public void RemoveEmployee(Employee e)
        {
            employees.Remove(e);
        }

        public Employee LongestEmployee()
        {
            DateTime today = DateTime.Now;
            int mostDays = -1;
            Employee longestEmp = null;
            foreach (Employee emp in employees)
            {
                if (emp.DaysEmployed() > mostDays)
                {
                    mostDays = emp.DaysEmployed();
                    longestEmp = emp;
                }
            }
            return longestEmp;
        }

        public Employee this[int i]
        {
            get
            {
                if (i < 0 || i >= employees.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return employees[i];
            }
        }

        public Employee this[string name]
        {
            get
            {
                foreach (Employee e in employees)
                {
                    if (e.Name == name)
                    {
                        return e;
                    }
                }
                return null;
            }
        }
    }
}
