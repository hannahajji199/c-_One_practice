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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Open_and_Save_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            // open file while chosing the file you want to open

            StreamReader reader;
            DialogResult output;

            output = openFileDialog1.ShowDialog();

            if (output == DialogResult.OK)
            {
                // opening the file
                reader = File.OpenText(openFileDialog1.FileName);

                // processing the file
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }

                // closing the file
                reader.Close();
            }
            else if (output == DialogResult.Cancel)
            {
                MessageBox.Show("You have canceled the operation");
            }
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
           
        }

        private void saveas_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            DialogResult output;

            output = saveFileDialog1.ShowDialog();

            if (output == DialogResult.OK)
            {
                // Creating and opening the file
                writer = File.CreateText(saveFileDialog1.FileName);

                // Writing into the file
                writer.WriteLine(textBox1.Text);

                // Closing the file
                writer.Close();

                MessageBox.Show("File saved successfully");
            }
            else if (output == DialogResult.Cancel)
            {
                MessageBox.Show("You have canceled the operation");
            }
        }
    }
}
