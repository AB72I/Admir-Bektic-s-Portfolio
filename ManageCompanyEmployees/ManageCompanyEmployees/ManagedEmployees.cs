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
    public partial class frmManagedEmployees : Form
    {
        List<string> managed;
        List<string> totalList;

        public frmManagedEmployees(string n, List<string> m, List<string> t)
        {

            InitializeComponent();
            txtName.Text = n;
            managed = m;
            for (int i=0; i < managed.Count; ++i)
            {
                lstManaged.Items.Add(managed[i]);
            }
            totalList = t;
            for (int i = 0; i < totalList.Count; ++i)
            {
                lstAllPTEmps.Items.Add(totalList[i]);
            }
        }

        private void frmManagedEmployees_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e) //puts part time employee name in the managed employee list
        {
            string name = lstAllPTEmps.SelectedItem.ToString();
            lstManaged.Items.Add(name);
            managed.Add(name);
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e) //remove employee from managed employees list
        {
            string name = lstManaged.SelectedItem.ToString();
            lstManaged.Items.Remove(name);
            managed.Remove(name);
        }

        private void btnUpdatesCompleted_Click(object sender, EventArgs e) //closes the employee management window
        {
            Tag = managed;
            Close();
        }
    }
}
