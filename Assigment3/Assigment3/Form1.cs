using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblsalestaxes_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // creating variables
                String food1, food2, calculatebtn;
                double price1, price2, subtotal, tips, totalanount, sales_text;
                //constant
                const double TAXES = 7;
                const double TIPS_percentage = 15;
                food1 = txtfoodonename.Text;
                price1 = double.Parse(txtpriceoffoodone.Text);
                food2 = txtfoodonename.Text;
                price2 = double.Parse(txtpriceoffoodtwo.Text);

                // process
                subtotal = price1 + price2;
                // calculating sales text perentage 
                sales_text = subtotal * (TAXES / 100);

                //  now calculating tips 
                tips = subtotal * (TIPS_percentage / 100);

                totalanount = subtotal + sales_text - tips;
           
            // displaying the result

            lblsalestaxes.Text=sales_text.ToString();
            lblsalestips.Text=tips.ToString(); 
            lbltotalamount.Text=totalanount.ToString();
            }
            catch {
                MessageBox.Show("don't put food box into taxes , don,t put price box into numeric ");
            }

        }
    }
}
