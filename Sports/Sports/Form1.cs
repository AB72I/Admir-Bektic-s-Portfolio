using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports
{
    public partial class Form1 : Form
    {
        private string[] sports = new string[] { "Squash", "Table Tennis", "Football" };
        private int[] numParticipants = new int[] { 25, 30, 105 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string totalString = "";

            for (int i = 0; i < sports.Length; ++i)
            {
                totalString += sports[i] + ": " + numParticipants[i] + "\n"; 
            }

            MessageBox.Show("The Values Are\n\n" + totalString, "List");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] copySports = new string[sports.Length + 1];
            int[] copyPlayers = new int[numParticipants.Length + 1];

            try
            {
                if (Convert.ToInt32(txtPlayer.Text) >= 0)
                {
                    Array.Copy(sports, copySports, sports.Length);
                    Array.Copy(numParticipants, copyPlayers, numParticipants.Length);

                    if (txtSport.Text != "")
                    {
                        copySports[sports.Length] = txtSport.Text;
                        copyPlayers[numParticipants.Length] = Convert.ToInt32(txtPlayer.Text);

                        sports = copySports;
                        numParticipants = copyPlayers;
                    }
                    else
                    {
                        throw new Exception("name of sport not given");
                    }
                }
                else
                {
                    MessageBox.Show("there cannot be a negative number of participants");
                    txtPlayer.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.GetType().ToString());
                txtSport.Clear();
                txtPlayer.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] copySports = new string[sports.Length - 1];
            int[] copyPlayers = new int[numParticipants.Length - 1];

            try
            {
                if (txtSport.Text != "")
                {
                    for (int i = 0; i < sports.Length; ++i)
                    {
                        if (sports[i] == txtSport.Text)
                        {
                            for (int j = i; j < sports.Length - 1; ++j)
                            {
                                sports[j] = sports[j + 1];
                                numParticipants[j] = numParticipants[j + 1];
                            }

                            Array.Copy(sports, copySports, copySports.Length);
                            Array.Copy(numParticipants, copyPlayers, copyPlayers.Length);

                            sports = copySports;
                            numParticipants = copyPlayers;
                        }
                    }
                }
                else
                {
                    throw new Exception("name of sport not given");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.GetType().ToString());
                txtSport.Clear();
                txtPlayer.Clear();
            }
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            try
            {   
                if (txtSport.Text != "")
                {
                    for (int i = 0; i < sports.Length; ++i)
                    {
                        if (sports[i] == txtSport.Text)
                        {
                            txtPlayer.Text = numParticipants[i].ToString();
                        }
                    }
                }
                else
                {
                    throw new Exception("name of sport not given");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.GetType().ToString());
            }
        }

        private void btnHighest_Click(object sender, EventArgs e)
        {
            int highest = 0;
            string popular = "";

            for (int i = 0; i< numParticipants.Length; ++i)
            {
                if(numParticipants[i] > highest)
                {
                    highest = numParticipants[i];
                    popular = sports[i];
                }
            }

            MessageBox.Show("The Sport with the most players is:" + "\n" + popular + ": " + highest.ToString());
        }
    }
}
