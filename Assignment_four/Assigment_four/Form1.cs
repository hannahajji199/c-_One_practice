using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_four
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


      
            int calories, fatgrams;

           // checking to checkboxes
            if (!int.TryParse(txtcol.Text, out calories) ||
                !int.TryParse(txtfat.Text, out fatgrams))
            {
                MessageBox.Show("Please enter numeric values.");
                return;
            }

            // 2. that isn't not less 0
            if (calories < 0 || fatgrams < 0)
            {
                MessageBox.Show("Calories and fat grams cannot be less than 0.");
                return;
            }

        
            int caloriesFromFat = fatgrams * 9;

          
            if (caloriesFromFat > calories)
            {
                MessageBox.Show("Either the calories or the fat grams were incorrectly entered.");
                return;
            }

        
            if (calories == 0)
            {
                MessageBox.Show("Total calories must be greater than 0.");
                return;
            }
            double percentage = (double)caloriesFromFat / calories * 100;

        
            listBox1.Items.Clear();
            listBox1.Items.Add("Calories from fat: " + caloriesFromFat);
            listBox1.Items.Add("Percentage of calories from fat: " + percentage.ToString("F0") + "%");
            


          
                if (percentage < 30) { 
                    checklowfat.Checked = true;
                    listBox1.Items.Add("This is a low-fat food.");
            }
            else
                listBox1.Items.Add("This is NOT a low-fat food.");
                    }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcol.Clear();
            txtfat.Clear();
            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    