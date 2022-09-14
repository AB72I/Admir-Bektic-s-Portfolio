using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_and_multiplication
{
    public partial class frmAddMultiply : Form
    {
        public frmAddMultiply()
        {
            InitializeComponent();
        }

        private void frmAddMultiply_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblValueB_Click(object sender, EventArgs e)
        {

        }

        private void btnResult1_Click(object sender, EventArgs e)
        {
            int product = Convert.ToInt32(txtValueB.Text) * Convert.ToInt32(txtValueC.Text);
            int total = Convert.ToInt32(txtValueA.Text);
            txtAddMultiply.Text = (total + product).ToString();
        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(txtValueA.Text) + Convert.ToInt32(txtValueB.Text);
            int total = Convert.ToInt32(txtValueC.Text);
            txtMultiplyAdd.Text = (total * sum).ToString();
        }
    }
}
