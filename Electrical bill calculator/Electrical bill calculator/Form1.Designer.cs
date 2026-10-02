namespace Electrical_bill_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lbltotalbill = new System.Windows.Forms.Label();
            this.lbltaxamount = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.lblelectricity = new System.Windows.Forms.Label();
            this.lblusage = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.priceperunit = new System.Windows.Forms.Label();
            this.lblcurrentreading = new System.Windows.Forms.Label();
            this.lblpriceoffoodtwo = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.lblcustomername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.BackColor = System.Drawing.Color.Silver;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(576, 567);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(413, 43);
            this.lbltotalamount.TabIndex = 29;
            // 
            // lbltotalbill
            // 
            this.lbltotalbill.BackColor = System.Drawing.Color.White;
            this.lbltotalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbill.Location = new System.Drawing.Point(12, 568);
            this.lbltotalbill.Name = "lbltotalbill";
            this.lbltotalbill.Size = new System.Drawing.Size(463, 39);
            this.lbltotalbill.TabIndex = 28;
            this.lbltotalbill.Text = "total Bill (including $ 5 fixed charge )  : ";
            // 
            // lbltaxamount
            // 
            this.lbltaxamount.BackColor = System.Drawing.Color.Silver;
            this.lbltaxamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaxamount.Location = new System.Drawing.Point(576, 474);
            this.lbltaxamount.Name = "lbltaxamount";
            this.lbltaxamount.Size = new System.Drawing.Size(413, 43);
            this.lbltaxamount.TabIndex = 27;
            // 
            // lblamount
            // 
            this.lblamount.BackColor = System.Drawing.Color.White;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(24, 496);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(276, 32);
            this.lblamount.TabIndex = 26;
            this.lblamount.Text = "tax Amount (7%) :  ";
            // 
            // lblelectricity
            // 
            this.lblelectricity.BackColor = System.Drawing.Color.White;
            this.lblelectricity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelectricity.Location = new System.Drawing.Point(24, 414);
            this.lblelectricity.Name = "lblelectricity";
            this.lblelectricity.Size = new System.Drawing.Size(330, 36);
            this.lblelectricity.TabIndex = 25;
            this.lblelectricity.Text = "Electricity usage (units) : ";
            // 
            // lblusage
            // 
            this.lblusage.BackColor = System.Drawing.Color.Silver;
            this.lblusage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusage.Location = new System.Drawing.Point(576, 381);
            this.lblusage.Name = "lblusage";
            this.lblusage.Size = new System.Drawing.Size(413, 43);
            this.lblusage.TabIndex = 24;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(298, 302);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(352, 76);
            this.btncalculate.TabIndex = 23;
            this.btncalculate.Text = "calculate Bill ";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(692, 232);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(244, 26);
            this.txtunitprice.TabIndex = 22;
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(692, 154);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(244, 26);
            this.txtcurrent.TabIndex = 21;
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(692, 88);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(244, 26);
            this.txtprevious.TabIndex = 20;
            // 
            // priceperunit
            // 
            this.priceperunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceperunit.Location = new System.Drawing.Point(137, 222);
            this.priceperunit.Name = "priceperunit";
            this.priceperunit.Size = new System.Drawing.Size(290, 36);
            this.priceperunit.TabIndex = 19;
            this.priceperunit.Text = "Enter price per unit ($): ";
            // 
            // lblcurrentreading
            // 
            this.lblcurrentreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentreading.Location = new System.Drawing.Point(120, 150);
            this.lblcurrentreading.Name = "lblcurrentreading";
            this.lblcurrentreading.Size = new System.Drawing.Size(324, 40);
            this.lblcurrentreading.TabIndex = 18;
            this.lblcurrentreading.Text = "Enter current Reading  : ";
            // 
            // lblpriceoffoodtwo
            // 
            this.lblpriceoffoodtwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpriceoffoodtwo.Location = new System.Drawing.Point(108, 88);
            this.lblpriceoffoodtwo.Name = "lblpriceoffoodtwo";
            this.lblpriceoffoodtwo.Size = new System.Drawing.Size(348, 42);
            this.lblpriceoffoodtwo.TabIndex = 17;
            this.lblpriceoffoodtwo.Text = "Enter previous Reading  : ";
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(692, 31);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(244, 26);
            this.txtcustomer.TabIndex = 16;
            // 
            // lblcustomername
            // 
            this.lblcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomername.Location = new System.Drawing.Point(123, 27);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(318, 42);
            this.lblcustomername.TabIndex = 15;
            this.lblcustomername.Text = "Enter Customer Name  : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 703);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lbltotalbill);
            this.Controls.Add(this.lbltaxamount);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblelectricity);
            this.Controls.Add(this.lblusage);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtprevious);
            this.Controls.Add(this.priceperunit);
            this.Controls.Add(this.lblcurrentreading);
            this.Controls.Add(this.lblpriceoffoodtwo);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.lblcustomername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lbltotalbill;
        private System.Windows.Forms.Label lbltaxamount;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lblelectricity;
        private System.Windows.Forms.Label lblusage;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.Label priceperunit;
        private System.Windows.Forms.Label lblcurrentreading;
        private System.Windows.Forms.Label lblpriceoffoodtwo;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.Label lblcustomername;
    }
}

