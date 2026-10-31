using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assignment_five
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            // creatimg file 
            StreamWriter lines;
            lines = File.CreateText("reading.doc");
            lines.WriteLine( "other functios of reading include : ");
            lines.WriteLine("ReadLines().");
            lines.WriteLine("ReadAllLines().");
            lines.WriteLine("ReadBlock().");
            // closing the read line 
            lines.Close();

        }

        private void btnread_Click(object sender, EventArgs e)
        {
            

            // Open and read the file
            string[] allLines = File.ReadAllLines("reading.doc");

            // Process the file
            foreach (string line in allLines)
            {
                listBox1.Items.Add(line);
            }

           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] allLines = File.ReadAllLines("reading.doc");

            foreach (string line in allLines)
            {
                listBox1.Items.Add(line);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            // Open the file
            StreamReader Input_file = File.OpenText("reading.doc");

            // Process the file - Read the file in blocks
            char[] buffer = new char[5];
            int count;

            while ((count = Input_file.ReadBlock(buffer, 0, 5)) > 0)
            {
                listBox1.Items.Add(new string(buffer, 0, count));
            }

            // Close the file
            Input_file.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
   
            listBox1.Items.Clear();
            foreach (string line in File.ReadLines("reading.doc"))
            {
            listBox1.Items.Add(line);
            }
}
        

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btndeleteitems_Click(object sender, EventArgs e)
        {
            if (File.Exists("reading.doc"))
            {
                File.WriteAllText("reading.doc", "");   // file stays, but it is empty
                listBox1.Items.Clear();
                MessageBox.Show("All items from the rading.doc was deleted");
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }
        }

        private void btndeletefile_Click(object sender, EventArgs e)
        {
            if (File.Exists("reading.doc"))
            {
                File.Delete("reading.doc");
                listBox1.Items.Clear();
                MessageBox.Show("the reading.doc file was deleted successfuly"); 
            }
            else
            {
                MessageBox.Show("the file doesn't exist");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
