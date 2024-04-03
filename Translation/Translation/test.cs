using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translation
{
    public partial class frmTest : Form
    {
        List<Words> list = new List<Words>();
        int counter = 0;
        List<Words> test = new List<Words>();
        double correct = 0;
        List<Tester> testers = new List<Tester>();
        public frmTest(List<Tester> t, List<Words> w)
        {
            InitializeComponent();

            for (int i = 0; i < t.Count; i++)
            {
                lstNames.Items.Add(t[i].name);
            }

            list = w;
            testers = t;
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void txtAmerican_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e) //begins test by showing the word in american english
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int num = rand.Next(list.Count);
                test.Add(list[num]);
            }

            txtAmerican.Text = test[counter].american;
        }

        private void btnSubmit_Click(object sender, EventArgs e) //checks to see if answer is correct
        {
            for (int i = 0; i < 32; i++)
            {
                if (list[i].american == txtAmerican.Text)
                {
                    if (list[i].english == txtEnglish.Text)
                    {
                        MessageBox.Show("Yes");
                        correct++;
                    }
                    else
                    {
                        MessageBox.Show("No");
                    }
                }

                
            }

            counter++;
            if(counter < 10)
            {
                txtAmerican.Text = test[counter].american;
            }
            else
            {
                MessageBox.Show("The Test is over");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) //closes the test window and updates testers score
        {
            for (int i = 0; i < testers.Count; i++)
            {
                if (testers[i].name == lstNames.SelectedItem.ToString())
                {
                    testers[i].attempts += 1;
                    testers[i].score = correct * 10;
                    counter = i;
                    Tag = testers[counter];
                }
            }

            Close();
        }
    }
}
