using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Translation
{
    public partial class Form1 : Form
    {
        int counter = 0;
        List<Words> translation = new List<Words>();
        static string path = @"C:\Users\ninja\source\repos\Translation\Translation\Translation.txt";
        StreamReader textinWords = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
        Words[] word = new Words[32];
        List<Tester> testers = new List<Tester>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e) //displays word in both languages for studying
        {
            txtAmerican.Clear();
            txtEnglish.Clear();
          

            txtAmerican.Text = translation[counter].american;
            txtEnglish.Text = translation[counter].english;

            if (counter == translation.Count - 1)
            {
                counter = 0;
            }
            else
            {
                counter++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\ninja\source\repos\Translation\Translation\Testers.txt";
            StreamReader textin = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
            Tester[] tester = new Tester[10];
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                tester[i] = new Tester();
            }

            while (textin.Peek() != -1)
            {
                string row = textin.ReadLine();
            
                if (row.Contains(','))
                {
                    string[] columns = row.Split(',');
                    if (count < tester.Length)
                    {
                        tester[count].attempts = Convert.ToInt32(columns[0]);
                        tester[count].score = Convert.ToDouble(columns[1]);
                        testers.Add(tester[count]);
                        count++;
                    }
                    
                }
                else
                {
                    if (count < tester.Length)
                        tester[count].name = row;
                }
            }

            for (int i = 0; i < testers.Count(); i++)
            {
                lstTesters.Items.Add(testers[i].name + ", "
                    + tester[i].attempts.ToString() + ", " + tester[i].score.ToString());
            }
            textin.Close();

           for (int i = 0; i < 32; i++)
            {
                word[i] = new Words();
            }

            count = 0;
            while (textinWords.Peek() != -1)
            {
                string row = textinWords.ReadLine();
                string[] columns = row.Split(',');
                word[count].american = columns[0];
                word[count].english = columns[1];
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                translation.Add(word[i]);
            }
            textinWords.Close();
        }

        private void btnTest_Click(object sender, EventArgs e) //opens up second form to begin test
        {
            Tester update = new Tester();
            List<Tester> testersList = new List<Tester>();

            for (int i = 0; i < lstTesters.Items.Count; i++)
            {
                Tester tester = new Tester();
                string[] columns = lstTesters.Items[i].ToString().Split(',');
                tester.name = columns[0];
                tester.attempts = Convert.ToInt32(columns[1]);
                tester.score = Convert.ToDouble(columns[2]);
                testersList.Add(tester);
            }

            frmTest test = new frmTest(testersList,translation);
            test.ShowDialog();
            update = (Tester)test.Tag;

            foreach (Tester t in testers)
            {
                if(t.name == update.name)
                {
                    t.score = Convert.ToDouble(update.score);
                    t.attempts = Convert.ToInt32(update.attempts);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) //closes the program and updates the score
        {
            string path = @"C:\Users\ninja\source\repos\Translation\Translation\Testers.txt";
            StreamWriter textOut = new StreamWriter(new FileStream(path, FileMode.Open, FileAccess.Write));

            for (int i = 0; i < testers.Count; i++)
            {
                textOut.WriteLine(testers[i].name);
                textOut.WriteLine(testers[i].attempts.ToString() + ","+ testers[i].score.ToString());
            }

            textOut.Close();
            Close();
        }
    }
}
