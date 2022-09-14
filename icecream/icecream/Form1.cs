using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icecream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal vanilla = Convert.ToDecimal(txtVScoop.Text) * 2.50m;
            decimal chocolate = Convert.ToDecimal(txtCScoop.Text) * 3.50m;

            decimal total = vanilla + chocolate;

            txtTotalCost.Text = total.ToString("c");
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            decimal totalScoops = Convert.ToDecimal(txtVScoop.Text) + Convert.ToDecimal(txtCScoop.Text);
            decimal percent = Convert.ToDecimal(txtVScoop.Text) / totalScoops;

            txtPercent.Text = "$" + percent.ToString("p");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAverageCost.Clear();
            txtCScoop.Clear();
            txtPercent.Clear();
            txtTotalCost.Clear();
            txtVScoop.Clear();
        }

        private void btnAverage_Click_1(object sender, EventArgs e)
        {
            decimal vanilla = Convert.ToDecimal(txtVScoop.Text) * 2.50m;
            decimal chocolate = Convert.ToDecimal(txtCScoop.Text) * 3.50m;
            decimal totalScoops = Convert.ToDecimal(txtVScoop.Text) + Convert.ToDecimal(txtCScoop.Text);

            decimal total = vanilla + chocolate;
            decimal average = total / totalScoops;

            txtAverageCost.Text = "$" + average.ToString("n2");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
