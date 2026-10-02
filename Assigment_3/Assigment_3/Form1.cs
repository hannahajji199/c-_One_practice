using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try { 
                //declaring varible
                string food1, food2;
                double price1, price2, sales, subtoal, tips, total;
                //constant varibles
                const double sales_price = 7;
                const double tip_price = 15;
                //storing date
                food1 = (txtnameoffoodone.Text);
                food2 = (txtnameoffoodtwo.Text);
                price1 = double.Parse(txtpriceoffoodone.Text);
                price2 = double.Parse(txtpriceoffootwo.Text);
                //calculate subtotal first
                subtoal = price1 + price2;

                //now calculate sales tax
                sales = subtoal * (sales_price / 100);

                // now calculate tips
                tips = subtoal * (tip_price / 100);

                //now calculate the total amount
                total = subtoal + sales - tips;

                //display
                lbltext.Text = sales.ToString("f2");
                lbltipsamount.Text = tips.ToString("f2");
                lbltotalamount.Text = total.ToString("f2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("please Enter only TEXT in the in the food name box and Enter only numbers in the price boxes");
            }



        }
    }
}
