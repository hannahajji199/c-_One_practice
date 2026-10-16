namespace Airline_Ticket_Booking_System
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
            this.AirlineListBox = new System.Windows.Forms.ListBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.txtpassage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblnumberofticket = new System.Windows.Forms.Label();
            this.txttickets = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.txtnumofweight = new System.Windows.Forms.TextBox();
            this.checkinsurance = new System.Windows.Forms.CheckBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnbusiness = new System.Windows.Forms.RadioButton();
            this.rdnnormal = new System.Windows.Forms.RadioButton();
            this.rdnfirst = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AirlineListBox
            // 
            this.AirlineListBox.FormattingEnabled = true;
            this.AirlineListBox.ItemHeight = 20;
            this.AirlineListBox.Location = new System.Drawing.Point(832, 1);
            this.AirlineListBox.Name = "AirlineListBox";
            this.AirlineListBox.Size = new System.Drawing.Size(520, 664);
            this.AirlineListBox.TabIndex = 23;
            this.AirlineListBox.SelectedIndexChanged += new System.EventHandler(this.bookingListBox_SelectedIndexChanged);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(269, 604);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(159, 40);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(26, 604);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(159, 40);
            this.btncalculate.TabIndex = 17;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Cyan;
            this.groupBox3.Controls.Add(this.lblname);
            this.groupBox3.Controls.Add(this.lblage);
            this.groupBox3.Controls.Add(this.txtpassage);
            this.groupBox3.Controls.Add(this.txtname);
            this.groupBox3.Controls.Add(this.lblnumberofticket);
            this.groupBox3.Controls.Add(this.txttickets);
            this.groupBox3.Controls.Add(this.lblweight);
            this.groupBox3.Controls.Add(this.txtnumofweight);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 285);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal Information";
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(38, 57);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(226, 33);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Passenger Name :";
            // 
            // lblage
            // 
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(20, 120);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(206, 33);
            this.lblage.TabIndex = 9;
            this.lblage.Text = "Passenger Age :";
            // 
            // txtpassage
            // 
            this.txtpassage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassage.Location = new System.Drawing.Point(275, 120);
            this.txtpassage.Multiline = true;
            this.txtpassage.Name = "txtpassage";
            this.txtpassage.Size = new System.Drawing.Size(252, 33);
            this.txtpassage.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(275, 57);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 33);
            this.txtname.TabIndex = 0;
            // 
            // lblnumberofticket
            // 
            this.lblnumberofticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberofticket.Location = new System.Drawing.Point(27, 173);
            this.lblnumberofticket.Name = "lblnumberofticket";
            this.lblnumberofticket.Size = new System.Drawing.Size(237, 37);
            this.lblnumberofticket.TabIndex = 10;
            this.lblnumberofticket.Text = "Number Of Ticket :";
            // 
            // txttickets
            // 
            this.txttickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttickets.Location = new System.Drawing.Point(275, 173);
            this.txttickets.Multiline = true;
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(252, 33);
            this.txttickets.TabIndex = 2;
            // 
            // lblweight
            // 
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(0, 225);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(264, 40);
            this.lblweight.TabIndex = 11;
            this.lblweight.Text = "Baggage weight(kg) :";
            // 
            // txtnumofweight
            // 
            this.txtnumofweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumofweight.Location = new System.Drawing.Point(275, 225);
            this.txtnumofweight.Multiline = true;
            this.txtnumofweight.Name = "txtnumofweight";
            this.txtnumofweight.Size = new System.Drawing.Size(252, 33);
            this.txtnumofweight.TabIndex = 3;
            // 
            // checkinsurance
            // 
            this.checkinsurance.AutoSize = true;
            this.checkinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinsurance.Location = new System.Drawing.Point(25, 45);
            this.checkinsurance.Name = "checkinsurance";
            this.checkinsurance.Size = new System.Drawing.Size(468, 33);
            this.checkinsurance.TabIndex = 0;
            this.checkinsurance.Text = "Add Travel insurance ($25 per ticket)";
            this.checkinsurance.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(495, 604);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(159, 40);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "&Exit ";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkinsurance);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 102);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Addition Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnbusiness);
            this.groupBox1.Controls.Add(this.rdnnormal);
            this.groupBox1.Controls.Add(this.rdnfirst);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 113);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Travel Class";
            // 
            // rdnbusiness
            // 
            this.rdnbusiness.AutoSize = true;
            this.rdnbusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnbusiness.Location = new System.Drawing.Point(465, 42);
            this.rdnbusiness.Name = "rdnbusiness";
            this.rdnbusiness.Size = new System.Drawing.Size(247, 36);
            this.rdnbusiness.TabIndex = 2;
            this.rdnbusiness.TabStop = true;
            this.rdnbusiness.Text = "Business Class";
            this.rdnbusiness.UseVisualStyleBackColor = true;
            // 
            // rdnnormal
            // 
            this.rdnnormal.AutoSize = true;
            this.rdnnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnnormal.Location = new System.Drawing.Point(226, 42);
            this.rdnnormal.Name = "rdnnormal";
            this.rdnnormal.Size = new System.Drawing.Size(220, 36);
            this.rdnnormal.TabIndex = 1;
            this.rdnnormal.TabStop = true;
            this.rdnnormal.Text = "Normal Class";
            this.rdnnormal.UseVisualStyleBackColor = true;
            // 
            // rdnfirst
            // 
            this.rdnfirst.AutoSize = true;
            this.rdnfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnfirst.Location = new System.Drawing.Point(14, 42);
            this.rdnfirst.Name = "rdnfirst";
            this.rdnfirst.Size = new System.Drawing.Size(183, 36);
            this.rdnfirst.TabIndex = 0;
            this.rdnfirst.TabStop = true;
            this.rdnfirst.Text = "First Class";
            this.rdnfirst.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 697);
            this.Controls.Add(this.AirlineListBox);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AirlineListBox;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblnumberofticket;
        private System.Windows.Forms.TextBox txtnumofweight;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpassage;
        private System.Windows.Forms.CheckBox checkinsurance;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnbusiness;
        private System.Windows.Forms.RadioButton rdnnormal;
        private System.Windows.Forms.RadioButton rdnfirst;
    }
}

