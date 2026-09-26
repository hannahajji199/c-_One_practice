using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            String st_Name,  St_depart, St_sem, showinfo;
            st_Name=txtname.Text;
           int st_ID= int.Parse(txtstudentid.Text);
            St_depart=txtdepartment.Text;
            St_sem=txtsemester.Text;
            showinfo= st_Name + " "+ st_ID + " "+ St_depart+" "+ St_sem;
            lbloutput.Text= showinfo;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
