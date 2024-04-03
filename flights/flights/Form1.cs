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
    public partial class Form1 : Form
    {
        Airline airline;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            airline = new Airline("The Airline");
            txtName.Text = airline.name;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e) //after selecting flight type, see the list of flights
        {
            lstFlights.Items.Clear();
            List<Flight> flights = airline.GetFlights();

            for (int i = 0; i < flights.Count; i++)
            {
                if ((rdoDomestic.Checked && flights[i].GetType() == typeof(Domestic)) ||
                    rdoInternational.Checked && flights[i].GetType() == typeof(International))
                {
                    lstFlights.Items.Add(flights[i].GetDisplayText());
                }
            }
        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            List<Flight> flights = airline.GetFlights();

            if (txtPassenger.Text == "" || lstFlights.SelectedItem == null)
            {
                MessageBox.Show("enter a name and select a flight");
            }
            else
            {
                for (int i = 0; i < flights.Count; i++)
                {
                    if (flights[i].GetDisplayText() == lstFlights.SelectedItem.ToString())
                    {
                        flights[i].AddPassenger(txtPassenger.Text);
                    }
                }
            }
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            Flight fly = null;
            List<Flight> flights = airline.GetFlights();

            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].GetDisplayText() == lstFlights.SelectedItem.ToString())
                {
                    fly = flights[i];
                }
            }

            frmPassengerList passengerList = new frmPassengerList(fly,lstFlights.SelectedItem.ToString());
            passengerList.ShowDialog();
        }
    }
}
