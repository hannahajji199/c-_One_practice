using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwaresales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  validation
            int numofpackeges = 0;
            double pricepackage = 0.0;
            if (int.TryParse(txtnumofpck.Text, out numofpackeges) & double.TryParse(txtpriceperpck.Text, out pricepackage))
            {

            }


            double price = 0;
           
          string discountrate="";
           double discount=0;


            if(numofpackeges >10 && numofpackeges <= 19)
            {
                discountrate = "20%";
                discount = 0.2;
              
               
            }
            if(numofpackeges >20 && numofpackeges <=49)
            {
                discountrate = "30%";
                discount = 0.3;
              

            }
            if(numofpackeges>50 && numofpackeges < 99)

            {
                discountrate = "40%";
                discount = 0.4;
                
            }
            if (numofpackeges >= 100)
            {
                discountrate = "50%";
                discount = 0.5;
               
            }
           
            double  subtotal = pricepackage * numofpackeges;
            double disamount = subtotal *discount ;
            double totalamount = subtotal - disamount;






            listBox1.Items.Add(" number of packeges : " + numofpackeges);
            listBox1.Items.Add("price per package : " + pricepackage);
            listBox1.Items.Add("subtotal (before discount )is :" +subtotal);
            listBox1.Items.Add("discount rate is :" + discountrate);
            listBox1.Items.Add("discount is : " + discount);
            listBox1.Items.Add("discount amount is : " + disamount);
            listBox1.Items.Add(" total amount is (after discount) :" + totalamount);
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnumofpck.Clear();
            txtpriceperpck.Clear();
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
