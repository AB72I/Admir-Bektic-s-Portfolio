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
    public partial class frmNewEmployee : Form
    {
        private List<string> companyProjects;

        public frmNewEmployee(List<string> projects)
        {
            InitializeComponent();
            companyProjects = projects;
            for (int i = 0; i < projects.Count; ++i)
            {
                lstProjects.Items.Add(projects[i]);
            }
        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e) //adds employee data to the list
        {
            PartTimeEmployee ptEmp;
            FullTimeEmployee ftEmp;
            string name = txtName.Text;
            double salary = Convert.ToDouble(txtSalary.Text);
            string proj = lstProjects.SelectedItem.ToString();
            if (rdoPartTime.Checked == true)
            {
                ptEmp = new PartTimeEmployee(name, proj, salary);
                Tag = ptEmp;
            }
            else
            {
                ftEmp = new FullTimeEmployee(name, proj, salary);
                Tag = ftEmp;
            }
            Close();
        }

    }
}
    /*
        private void rdoPartTime_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    */
