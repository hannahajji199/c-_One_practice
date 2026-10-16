namespace Hotelroombooking
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblnumberofquest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtnumofquest = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnhight = new System.Windows.Forms.RadioButton();
            this.rdnnormal = new System.Windows.Forms.RadioButton();
            this.rdnstandard = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkbreakfast = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.bookingListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(69, 80);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(180, 40);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Quest Name :";
            // 
            // lblage
            // 
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(85, 143);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(153, 33);
            this.lblage.TabIndex = 9;
            this.lblage.Text = "Quest Age :";
            // 
            // lblnumberofquest
            // 
            this.lblnumberofquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberofquest.Location = new System.Drawing.Point(39, 200);
            this.lblnumberofquest.Name = "lblnumberofquest";
            this.lblnumberofquest.Size = new System.Drawing.Size(237, 37);
            this.lblnumberofquest.TabIndex = 10;
            this.lblnumberofquest.Text = "Number Of nights :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Number Of Quest :";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(287, 84);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 33);
            this.txtname.TabIndex = 0;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(287, 147);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(252, 33);
            this.txtage.TabIndex = 1;
            // 
            // txtnights
            // 
            this.txtnights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnights.Location = new System.Drawing.Point(287, 200);
            this.txtnights.Multiline = true;
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(252, 33);
            this.txtnights.TabIndex = 2;
            // 
            // txtnumofquest
            // 
            this.txtnumofquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumofquest.Location = new System.Drawing.Point(287, 252);
            this.txtnumofquest.Multiline = true;
            this.txtnumofquest.Name = "txtnumofquest";
            this.txtnumofquest.Size = new System.Drawing.Size(252, 33);
            this.txtnumofquest.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnhight);
            this.groupBox1.Controls.Add(this.rdnnormal);
            this.groupBox1.Controls.Add(this.rdnstandard);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Type";
            // 
            // rdnhight
            // 
            this.rdnhight.AutoSize = true;
            this.rdnhight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnhight.Location = new System.Drawing.Point(380, 42);
            this.rdnhight.Name = "rdnhight";
            this.rdnhight.Size = new System.Drawing.Size(111, 36);
            this.rdnhight.TabIndex = 2;
            this.rdnhight.TabStop = true;
            this.rdnhight.Text = "Hight";
            this.rdnhight.UseVisualStyleBackColor = true;
            this.rdnhight.CheckedChanged += new System.EventHandler(this.rdnhight_CheckedChanged);
            // 
            // rdnnormal
            // 
            this.rdnnormal.AutoSize = true;
            this.rdnnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnnormal.Location = new System.Drawing.Point(220, 42);
            this.rdnnormal.Name = "rdnnormal";
            this.rdnnormal.Size = new System.Drawing.Size(136, 36);
            this.rdnnormal.TabIndex = 1;
            this.rdnnormal.TabStop = true;
            this.rdnnormal.Text = "Normal";
            this.rdnnormal.UseVisualStyleBackColor = true;
            // 
            // rdnstandard
            // 
            this.rdnstandard.AutoSize = true;
            this.rdnstandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnstandard.Location = new System.Drawing.Point(14, 42);
            this.rdnstandard.Name = "rdnstandard";
            this.rdnstandard.Size = new System.Drawing.Size(163, 36);
            this.rdnstandard.TabIndex = 0;
            this.rdnstandard.TabStop = true;
            this.rdnstandard.Text = "Standard";
            this.rdnstandard.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkbreakfast);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 102);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Addition Options";
            // 
            // checkbreakfast
            // 
            this.checkbreakfast.AutoSize = true;
            this.checkbreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbreakfast.Location = new System.Drawing.Point(72, 46);
            this.checkbreakfast.Name = "checkbreakfast";
            this.checkbreakfast.Size = new System.Drawing.Size(374, 29);
            this.checkbreakfast.TabIndex = 0;
            this.checkbreakfast.Text = "BreakFast (10 Per Guest per night)";
            this.checkbreakfast.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblname);
            this.groupBox3.Controls.Add(this.lblage);
            this.groupBox3.Controls.Add(this.lblnumberofquest);
            this.groupBox3.Controls.Add(this.txtnumofquest);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtnights);
            this.groupBox3.Controls.Add(this.txtname);
            this.groupBox3.Controls.Add(this.txtage);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 309);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal Information";
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(10, 606);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(159, 40);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(253, 606);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(159, 40);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(479, 606);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(159, 40);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "&Exit ";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // bookingListBox
            // 
            this.bookingListBox.FormattingEnabled = true;
            this.bookingListBox.ItemHeight = 20;
            this.bookingListBox.Location = new System.Drawing.Point(710, 23);
            this.bookingListBox.Name = "bookingListBox";
            this.bookingListBox.Size = new System.Drawing.Size(571, 644);
            this.bookingListBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 679);
            this.Controls.Add(this.bookingListBox);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblnumberofquest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtnumofquest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnnormal;
        private System.Windows.Forms.RadioButton rdnstandard;
        private System.Windows.Forms.RadioButton rdnhight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkbreakfast;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox bookingListBox;
    }
}

