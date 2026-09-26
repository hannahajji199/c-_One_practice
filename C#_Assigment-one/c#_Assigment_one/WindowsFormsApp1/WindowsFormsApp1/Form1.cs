using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day, Month, dayNumber, year, showdate;
            day=textBox1.Text;
            Month=textBox2.Text;
            dayNumber=textBox3.Text;
            year=textBox4.Text;
             showdate= day + " "+ Month+" "+dayNumber + " " + year;
            lbldateoutput.Text = showdate;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbldayname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            lbldateoutput.Text = " ";

           

        }
    }
}
