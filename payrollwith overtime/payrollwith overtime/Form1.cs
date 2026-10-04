using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payrollwith_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // creating vaiables
            double hours_worked, payrate, grosspay , Validation;

            // prevent exception data conversition using try parse method 
            if (double.TryParse(txthoursworked.Text, out Validation) & double.TryParse(txtpayrate.Text, out Validation))
             {
                // assigning variables 
                hours_worked=double.Parse(txtpayrate.Text);
                payrate=double.Parse(txtpayrate.Text);
                // checking validations user 
                if (hours_worked > 0 & payrate > 0) {
                    grosspay = hours_worked * payrate;
                    lblgrossby.Text = grosspay.ToString("c");
                 }
                else {
                    MessageBox.Show(" hours worked or payrate must be greater than 0  ");
                }

            }
            else
            {
                MessageBox.Show("txthours , txtpayrate only accepts double or int ");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthoursworked.Clear();
            txtpayrate.Text = ""; ;
            //lblgrossby.Text = "";
            lblgrossby.Text=string.Empty;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
     
        }
    }
}
