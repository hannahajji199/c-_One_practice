using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelroombooking
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void rdnhight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int age, nights, guests;

            // 1. Validate numbers with TryParse
            if (int.TryParse(txtage.Text, out age) &&
                int.TryParse(txtnights.Text, out nights) &&     
                int.TryParse(txtnumofquest.Text, out guests))
            {

                if (age < 18 || age > 90)
                {
                    MessageBox.Show("Guest age must be between 18 and 90.");
                    return;

                }
                if (nights < 1 || nights > 30)
                {
                    MessageBox.Show("Number of nights must be between 1 and 30.");
                    return;

                }
                if (guests < 1 || guests > 6)
                {
                    MessageBox.Show("Number of guests must be between 1 and 6.");
                    return;

                }


            }
            else {
                MessageBox.Show("Age, nights and guests must be numbers.");
                return;
            }

            // 2. Check the ranges  (CHANGE these numbers to match your rules)
            

            // 3. Room type and rate with switch
            string roomType = "";
            if (rdnstandard.Checked) roomType = "Standard";
            else if (rdnnormal.Checked) roomType = "Normal";
            else if (rdnhight.Checked) roomType = "High";

            double rate = 0;
            int maxGuests = 0;

            switch (roomType)
            {
                case "Standard":
                    rate = 50;     
                    maxGuests = 2;
                    break;
                case "Normal":
                    rate = 80;      
                    maxGuests = 4;  
                    break;
                case "High":
                    rate = 120;    
                    maxGuests = 6;  
                    break;
                default:
                    MessageBox.Show("Please select a room type.");
                    return;
            }

            // 4. Approve or reject by the guest limit

            string status = "APPROVED";
          


            if (int.Parse(txtnumofquest.Text) > maxGuests)
            {
                status = "REJECTED";
            }

            // 5. Calculate the cost
            double basicCost = rate * int.Parse(txtnights.Text);

            double stayDiscountPercent = 0;
            if (int.Parse(txtnights.Text) >= 10)
            {
                stayDiscountPercent = 0.12;
            }
            else if (int.Parse(txtnights.Text)   >= 5)
            {
                stayDiscountPercent = 0.05;
            }
            double stayDiscount = basicCost * stayDiscountPercent;

            double seniorDiscount = 0;
            if (age >= 60)
            {
                seniorDiscount = basicCost * 0.05;
            }

            double breakfastCost = 0;
            if (checkbreakfast.Checked)
            {
                breakfastCost = 10 * int.Parse(txtnumofquest.Text) * int.Parse(txtnights.Text);
            }

            double surcharge = 0;
            if (int.Parse(txtnumofquest.Text)    > 4)
            {
                surcharge = basicCost * 0.08;   
            }

            double finalCost = basicCost - stayDiscount - seniorDiscount
                               + breakfastCost + surcharge;

            // 6. Show the result in the ListBox
            if (int.Parse(txtage.Text) < 18 || int.Parse(txtage.Text) > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90."); return;
                bookingListBox.Items.Add("Guest age must be between 18 and 90.");
                bookingListBox.Items.Add("Booking Status: REJECTED");
               
            }
            else
            {
                bookingListBox.Items.Clear();
                bookingListBox.Items.Add("Guest Name: " + txtname.Text);
                bookingListBox.Items.Add("Guest Age: " + age);
                bookingListBox.Items.Add("Number of Guests: " + int.Parse(txtnumofquest.Text));
                bookingListBox.Items.Add("Number of Nights: " + int.Parse(txtnights.Text));
                bookingListBox.Items.Add("Room Type: " + roomType);
                bookingListBox.Items.Add("Rate Per Night: " + rate.ToString("c"));
                bookingListBox.Items.Add("Basic Room Cost: " + basicCost.ToString("c"));
                bookingListBox.Items.Add("Stay Discount: " + stayDiscount.ToString("c"));
                bookingListBox.Items.Add("Senior Discount: " + seniorDiscount.ToString("c"));
                bookingListBox.Items.Add("Breakfast Cost: " + breakfastCost.ToString("c"));
                bookingListBox.Items.Add("Service Surcharge: " + surcharge.ToString("c"));
                bookingListBox.Items.Add("Final Cost: " + finalCost.ToString("c"));
                bookingListBox.Items.Add("Booking Status: " + status);
            }
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtnights.Clear();
            txtnumofquest.Clear();
            rdnstandard.Checked = false;
            rdnnormal.Checked = false;
            rdnhight.Checked = false;
            checkbreakfast.Checked = false;
            bookingListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {


            txtname.Clear();
            txtage.Clear();
            txtnights.Clear();
            txtnumofquest.Clear();
            rdnstandard.Checked = false;
            rdnnormal.Checked = false;
            rdnhight.Checked = false;
            checkbreakfast.Checked = false;
            bookingListBox.Items.Clear();
            txtname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

