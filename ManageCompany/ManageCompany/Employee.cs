using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 < and > (for sorting) (try doing it first and see if there is a problem
                before defining < and >)
 == and != (may not be necessary)



    */


namespace Employees
{
    class Employee : IComparable<Employee>
    {
        public Employee()
        {
        }
        
        public Employee(string n, DateTime jc, int i)
        {
            Name = n;
            JoinedCompany = jc;
            Id = i;
        }

        public string Name { get; set; }
        public DateTime JoinedCompany { get; set; }

        public int DaysEmployed()
        {
            return (DateTime.Now - JoinedCompany).Days;
        }

        public int Id { get; set; }

        public bool LessThan(Employee e)
        {
            if (e == null)
            {
                return false;
            }
            else if (String.Compare(Name, e.Name) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator < (Employee e1, Employee e2)
        {
            if (Object.Equals(e1, null))
            {
                if (Object.Equals(e2, null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return (e1.LessThan(e2));
            }
        }

        /*
        public static bool operator > (Employee e1, Employee e2)
        {
            return !((e1 < e2) || (e1 == e2));
        }
        */
        // Alternative way to define
        public static bool operator > (Employee e1, Employee e2) => 
            !((e1 < e2) || (e1 == e2));

        public int CompareTo(Employee e) =>
            Name.CompareTo(e.Name);
            
    }
}
