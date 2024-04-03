using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flights
{
    public partial class frmPassengerList : Form
    {
        private string name;

        public frmPassengerList(Flight fly, string n)
        {
            InitializeComponent();

            name = n;
            txtFlight.Text = name;

            for (int i = 0; i < fly.GetPassengerCount(); i++)
            {
                lstPassengerList.Items.Add(fly.GetPassengers()[i]);
            }
        }

        private void lstFlighList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void frmPassengerList_Load(object sender, EventArgs e)
        {

        }

        private void txtFlight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
