using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class Form1 : Form
    {
        int arrayIndex = 0;
        int maxver = 0;
        int minver = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //create array
        string[] arrID = new string[1000];
        string[] arrName = new string[1000];
        string[] arrScore = new string[1000];

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //get input data from texrbox
            string inputID = tbinputid.Text;
            string inputName = tbinputidname.Text;
            string inputScore = tbinputidscore.Text;
            
            // add data to array
            arrID[arrayIndex] = inputID;
            arrName[arrayIndex] = inputName;
            arrScore[arrayIndex] = inputScore;
            arrayIndex++;
            int x = int.Parse(inputScore);

            if (x > maxver)
            {
                maxver = x;
                textboxidmax.Text = inputID;
                textboxnamemax.Text = inputName;
                textboxscoremax.Text = inputScore;

            }
            if (x < maxver)
            {
                minver = x;
                textboxidmin.Text = inputID;
                textboxnamemin.Text = inputName;
                textboxscoremin.Text = inputScore;
                int h= int.Parse(inputScore);
                minver = h;

            }
            int sum = minver + maxver ;
            int sum2 = sum / 2;
            string sum3 = sum2.ToString();
            total.Text = sum3;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
