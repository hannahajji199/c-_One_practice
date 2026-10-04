using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_nested_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //creating variables 
                double salary, years;

                // Assigning variables
                salary=double.Parse(txtsalary.Text);
                years = double.Parse(txtsalary.Text);

                // checking qualification using decsion structure 

                if (salary > 300) {

                    if (years >= 2)
                    {
                        lblresultoutput.Text = ("Qualify to loan");
                    }
                    else
                    {
                        lblresultoutput.Text = ("Sorry! ,we can't qualify loan with Experience");
                    }
                }
                else
                {
                    lblresultoutput.Text=("your salary isn't enough to take loan");
                }

            }
            catch (Exception ex) { }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsalary.Text = "";
            txtyear.Text = "";
            lblresultoutput.Text = string.Empty;
        }
    }
}
