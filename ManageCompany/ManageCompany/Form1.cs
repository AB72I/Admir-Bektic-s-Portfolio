using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees;    // Note that this is now being included (existing class)

namespace ManageCompany
{
    public partial class frmManageCompany : Form
    {
        private Company company = new Company("Super IT Support", "Wales, UK");

        public frmManageCompany()
        {
            InitializeComponent();
        }

        private void frmManageCompany_Load(object sender, EventArgs e)
        {
            txtCompanyName.Text = company.Name + " ,   " + company.Address;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e) //opens employee window to add new employee
        {
            clearAll();

            Form newEmployee = new frmNewEmployee();

            newEmployee.ShowDialog();

            company.AddEmployee((Employee)newEmployee.Tag);

            for (int i = 0; i < company.NumEmployees; ++i)
            {
                lstEmployees.Items.Add(company[i].Name);
                lstID.Items.Add(company[i].Id);
                lstDays.Items.Add(company[i].DaysEmployed());
            }
        }

        private void btnListEmployees_Click(object sender, EventArgs e) //lists employees
        {
            lstEmployees.Items.Clear();
            lstID.Items.Clear();
            lstDays.Items.Clear();

            for (int i = 0; i < company.NumEmployees; ++i)
            {
                lstEmployees.Items.Add(company[i].Name);

                if (chbWithIDs.Checked)
                {
                    lstID.Items.Add(company[i].Id);
                }

                if (chbWithDays.Checked)
                {
                    lstDays.Items.Add(company[i].DaysEmployed());
                }
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            string nameEmp = txtEmployeeName.Text;

            Employee emp = company[nameEmp];

            if (emp == null)
            {
                MessageBox.Show("This Person is not an Employee");
            }
            else
            {
                company.RemoveEmployee(emp);
                MessageBox.Show(emp.Name + " has been removed", "Remove Employee");
            }

            txtEmployeeName.Clear();
        }

        private void btnSearchEmp_Click(object sender, EventArgs e) //searches name to see if they are an employee
        {
            clearAll();

            string nameEmp = txtEmployeeName.Text;
            Employee emp = company[nameEmp];

            if (emp == null)
            {
                MessageBox.Show("This Person is not an Employee");
            }
            else
            {
                lstEmployees.Items.Add(emp.Name);
                lstID.Items.Add(emp.Id);
                lstDays.Items.Add(emp.DaysEmployed());
            }

            txtEmployeeName.Clear();
        }

        private void btnSortEmployees_Click(object sender, EventArgs e) //sorts employees
        {
            clearAll();

            company.SortEmployees();

            for (int i = 0; i < company.NumEmployees; ++i)
            {
                lstEmployees.Items.Add(company[i].Name);
                lstID.Items.Add(company[i].Id);
                lstDays.Items.Add(company[i].DaysEmployed());
            }
        }

        private void btnLongestEmp_Click(object sender, EventArgs e) //see employee who has been in the company the longest
        {
            clearAll();
            Employee longestEmp = company.LongestEmployee();
            lstEmployees.Items.Add(longestEmp.Name);
            lstID.Items.Add(longestEmp.Id);
            lstDays.Items.Add(longestEmp.DaysEmployed());
        }

        private void btnTotalEmps_Click(object sender, EventArgs e) //total number of employees
        {
            txtTotalNumEmps.Text = company.NumEmployees.ToString();
        }


        private void clearAll()
        {
            lstEmployees.Items.Clear();
            lstDays.Items.Clear();
            lstID.Items.Clear();
            chbWithDays.Checked = false;
            chbWithIDs.Checked = false;
            txtTotalNumEmps.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e) //clears text
        {
            clearAll();
        }

        private void btnExit_Click(object sender, EventArgs e) //closes program
        {
            Close();
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

