using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrical_bill_calculator
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
            
            try
            {
                // creating variables
                string customerName;
                double previousReading, currentReading, pricePerUnit;
                double usage, baseCost, tax, totalBill;

                // constants
                const double TAX_PERCENTAGE = 7;
                const double FIXED_CHARGE = 5;

                // getting input
                customerName = txtcustomer.Text;
                previousReading = double.Parse(txtprevious.Text);
                currentReading = double.Parse(txtcurrent.Text);
                pricePerUnit = double.Parse(txtunitprice.Text);

                // process
                usage = currentReading - previousReading;
                baseCost = usage * pricePerUnit;
                tax = baseCost * (TAX_PERCENTAGE / 100);
                totalBill = baseCost + tax + FIXED_CHARGE;

                // displaying the result
                lblusage.Text = usage.ToString();
                lbltaxamount.Text = tax.ToString("c", new CultureInfo("en-US"));
                lbltotalamount.Text = totalBill.ToString("c" , new CultureInfo ("en-US"));
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter  text in the customer name and valid numbers in the reading and price boxes.");
            }
        }
    }
    }

