using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees;

namespace ManageCompany
{
    public partial class frmNewEmployee : Form
    {
        Employee newEmp = new Employee();

        public frmNewEmployee()
        {
            InitializeComponent();
        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e) //enters new employee data
        {
            newEmp.Name = txtName.Text;
            newEmp.JoinedCompany = DateTime.Parse(txtDateJoined.Text);
            Tag = newEmp;
            Close();
        }
    }
}
