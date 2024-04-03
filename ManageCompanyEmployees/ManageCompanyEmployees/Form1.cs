using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCompanyEmployees
{
    public partial class Form1 : Form
    {
        Company company;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e) //opens second window for adding employee
        {
                frmNewEmployee newEmployee = new frmNewEmployee(company.GetProjects());
                newEmployee.ShowDialog();
                Employee emp = (Employee)newEmployee.Tag;
                company.AddEmployee(emp);     
        }

        private void btnListEmployees_Click(object sender, EventArgs e) //displays part time or full time employees depending on what is selected
        {
            lsbEmpInfo.Items.Clear();
            List<Employee> emps = company.GetEmployees();
            for (int i = 0; i < emps.Count; ++i)
            {
                if ((rdoPartTime.Checked && (emps[i].GetType() == typeof(PartTimeEmployee))) ||
                    (rdoFullTime.Checked && (emps[i].GetType() == typeof(FullTimeEmployee))))
                {
                    lsbEmpInfo.Items.Add(emps[i].GetDisplayText());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            company = new Company("Welsh IT Company");
            txtCompanyName.Text = company.Name;
        }

        private void btnExit_Click(object sender, EventArgs e) //closes the application
        {
            Close();
        }

        private void btnUpdateEmps_Click(object sender, EventArgs e) //manages employees
        {
            string empInfo = lsbEmpInfo.SelectedItem.ToString();
            string empName = empInfo.Substring(0, empInfo.IndexOf(","));
            FullTimeEmployee emp = (FullTimeEmployee)company[empName];

            List<string> managedEmps = emp.GetManagedEmps();
            List<string> listPTEmpNames = company.GetPTEmpNames();

            frmManagedEmployees frmManage = new frmManagedEmployees(empName, emp.GetManagedEmps(), company.GetPTEmpNames());
            frmManage.ShowDialog();

            ((FullTimeEmployee)company[empName]).SetManagedEmps((List<string>)frmManage.Tag);
        }
    }
}
