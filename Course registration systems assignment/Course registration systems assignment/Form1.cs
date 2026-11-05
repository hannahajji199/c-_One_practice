using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_registration_systems_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string coursename = txtcoursename.Text;
                if (string.IsNullOrEmpty(coursename))
                {
                    MessageBox.Show("Please enter a course name.");
                    return;
                }
                //validation price
                if (!double.TryParse(txtcprice.Text, out double courseprice) || courseprice < 0)
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }
                // max course
                if (listBox1.Items.Count >= 5)
                {
                    MessageBox.Show("you can't add more than 5 course");
                    return;
                }
                // checking if course already exists
                int i = 0;
                Boolean isduplicate = false;
                while (i < listBoxregister.Items.Count)
                {
                    int coursenumber = i + 1;
                    string item = listBoxregister.Items[i].ToString();
                    // making one line the CNO, Cname and Cprice
                    // the space giving only to look more beatiful
                    string courseName = (i + 1) + "           " + "                 " + coursename + "                 " + courseprice.ToString("f2");
                    if (item == courseName ) 
                    {
                        isduplicate = true;
                        break;
                    }
                    i++;

                }
                if (isduplicate==true)
                {
                    MessageBox.Show("This course already exists.");
                    return;
                }
                else
                {

                    listBoxregister.Items.Add((listBoxregister.Items.Count + 1) + ". " + coursename + " - " + courseprice.ToString("f2"));
                    MessageBox.Show("Course added successfully.");
                    txtnumofcourse.Text = listBoxregister.Items.Count.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listBoxregister.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course ");
            }
            else
            {
                try
                {
                    int item = listBoxregister.SelectedIndex;

                    listBoxregister.Items.RemoveAt(item);

                    txtnumofcourse.Text = listBoxregister.Items.Count.ToString();

                    MessageBox.Show("Course removed successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            try
            {
                // creating variables and assigning values some of them 
                int age;
                double courseprice, discountrate = 0, course_discount, basicfee = 0, scholarship_Dis = 0, finalfee;
                int coursecount = listBoxregister.Items.Count;
                if (!int.TryParse(txtage.Text, out age))
                {
                    MessageBox.Show("Please enter a valid age.");
                    return;
                }
                else if (age < 16 || age > 60)
                {
                    MessageBox.Show("Age must be between 16 and 60.");
                }
                else if (txtname.Text == "")
                {
                    MessageBox.Show("Please enter your name.");
                    return;
                }
                else if (txtid.Text == "")
                {
                    MessageBox.Show("Please enter your ID.");
                    return;
                }
                else if (coursecount == 0)
                {
                    MessageBox.Show("you have to register at least one course");
                    return;
                }
                int i = 0;
                while (i < listBoxregister.Items.Count)
                {
                    string item = listBoxregister.Items[i].ToString();
                    int indexposition = item.IndexOf("-");
                    if (indexposition != -1)
                    {
                        string pricetext = item.Substring(indexposition + 2);
                        if (double.TryParse(pricetext, out courseprice))
                        {
                            basicfee += courseprice;
                        }
                        else
                        {
                            MessageBox.Show("Invalid course price ." + pricetext);
                        }
                    }
                    i++;

                }
                // caltulating discount on number of courses
                if (coursecount == 2)
                {
                    discountrate = 0.05;
                }
                else if (coursecount == 3 | coursecount == 4)
                {
                    discountrate = 0.1;
                }
                else if (coursecount == 5)
                {
                    discountrate = 0.15;
                }
                course_discount = basicfee * discountrate;
                // calculating scholarship discount
                if (checkBox1.Checked)
                {
                    scholarship_Dis = basicfee * 0.2;
                }
                finalfee = basicfee - course_discount - scholarship_Dis;

                listBox1.Items.Add("Student Name: " + txtname.Text);
                listBox1.Items.Add("Student Age: " + age);
                listBox1.Items.Add("Student ID: " + txtid.Text);
                listBox1.Items.Add("Number of Courses: " + coursecount);
                listBox1.Items.Add("Basic Registration Fee: $" + basicfee.ToString("F2"));
                listBox1.Items.Add("Course Discount: $" + course_discount.ToString("F2"));
                listBox1.Items.Add("Scholarship Discount: $" + scholarship_Dis.ToString("F2"));
                listBox1.Items.Add("Final Registration Fee: $" + finalfee.ToString("F2"));
                listBox1.Items.Add("Registered successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtid.Clear();
            txtnumofcourse.Clear();
            txtcoursename.Clear();
            txtcprice.Clear();
            listBoxregister.Items.Clear();
            listBox1.Items.Clear();
            checkBox1.Checked = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
