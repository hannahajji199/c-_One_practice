using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bookingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int age =1, ticket=0 ;
            double weight = 0;
            if (int.TryParse(txtpassage.Text, out age) &&
                int.TryParse(txttickets.Text, out ticket) &&
                double.TryParse(txtnumofweight.Text, out weight))
            {

                if (age < 1 || age > 100)
                {
                    MessageBox.Show("passenger age must be between 1 and 100.");
                    return;

                }
                if (ticket < 1 || ticket > 5)
                {
                    MessageBox.Show("Number of ticket must be between 1 and 5.");
                    return;

                }
                if (weight < 0 || weight > 50)
                {
                    MessageBox.Show("Number of weight can't be negative also can't be greater than 50.");
                    return;

                }
            }else
            {
                MessageBox.Show("Please enter valid numeric values for age, number of tickets, and weight.");
                return;
            }
            string travelClass = "";
            double price  = 0;
            if (rdnfirst.Checked)

            {
                travelClass = "first class";
                price = 1000;
            }
           
            else if (rdnbusiness.Checked)
            {
                travelClass = "business";
                price = 750;
            }
            else if (rdnnormal.Checked)
            {
                travelClass = "normal";
                price = 500;
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }
            // Approving to book or disapprove the booking based on the reason 

            bool BookingApproved = true;
            string reason = "";
            if(age<12 && rdnfirst.Checked)
            {
                BookingApproved = false;
                reason = "You can't book a first class ticket because your age is less than 12";
            }


            if (!BookingApproved)
            {
               AirlineListBox.Items.Add("Booking Disapproved: ");
               AirlineListBox.Items.Add( "Reason :"+reason);
                return;
            }
            // calculating the basic cost of the ticket and discount 



            double basiccost = price * ticket;
            double discountpercentage = 0;
            if (ticket == 5)
            {
                discountpercentage+= 0.1;
            }else if(ticket >= 3)
            {
                discountpercentage += 0.05;
            }
            // making discount based on the age of the passenger
            if (age<12)
            {
                discountpercentage += 0.2;
            }else if(age>=60)
            {
                discountpercentage += 0.10;
            }
            double discountamount = basiccost * discountpercentage;

            // checking if check indurance checkbox
            double insurancecost = 0;
            if(checkinsurance.Checked)
            {
                insurancecost = 25 * ticket;
            }
            // calculating the total cost .
            double totalcost = basiccost - discountamount + insurancecost;

            // adding into listbix 

            
            AirlineListBox.Items.Add("Booking Approved: ");
            AirlineListBox.Items.Add("Guest Age: " + txtpassage.Text);
            AirlineListBox.Items.Add("Number of Ticket: " + txttickets.Text);
            AirlineListBox.Items.Add("Number of Weight: " + txtnumofweight.Text);
            AirlineListBox.Items.Add("Travel Class: " + travelClass);
            AirlineListBox.Items.Add("per ticket price :" + price.ToString("C"));
            AirlineListBox.Items.Add("number of tickets:" + ticket);
            AirlineListBox.Items.Add("basic cost: " + basiccost.ToString("C"));
            AirlineListBox.Items.Add("Discount (" + (discountpercentage * 100) + "%): -" + discountamount.ToString("C"));
            AirlineListBox.Items.Add("insurance :"+ insurancecost.ToString("C"));
            AirlineListBox.Items.Add("Total Cost: " + totalcost.ToString("C"));
            


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Empty the text boxes
            txtname.Clear();
            txtpassage.Clear();
            txttickets.Clear();
            txtnumofweight.Clear();

            // Uncheck the radio buttons
            rdnfirst.Checked = false;
            rdnnormal.Checked = false;
            rdnbusiness.Checked = false;

            // Uncheck the checkbox
            checkinsurance.Checked = false;

            // Empty the listbox
            AirlineListBox.Items.Clear();

            // Put the cursor in the first text box
            txtpassage.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
