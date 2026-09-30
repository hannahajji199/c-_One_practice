namespace Assigment3
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
            this.lblfoodone = new System.Windows.Forms.Label();
            this.txtfoodonename = new System.Windows.Forms.TextBox();
            this.lblpriceoffoodtwo = new System.Windows.Forms.Label();
            this.lblfoodtwo = new System.Windows.Forms.Label();
            this.priceoffoodtwo = new System.Windows.Forms.Label();
            this.txtpriceoffoodone = new System.Windows.Forms.TextBox();
            this.txtnameoffoodtwo = new System.Windows.Forms.TextBox();
            this.txtpriceoffoodtwo = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblsalestaxes = new System.Windows.Forms.Label();
            this.lblsalestax = new System.Windows.Forms.Label();
            this.lblslestips = new System.Windows.Forms.Label();
            this.lblsalestips = new System.Windows.Forms.Label();
            this.lbltotalamout = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfoodone
            // 
            this.lblfoodone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoodone.Location = new System.Drawing.Point(56, 58);
            this.lblfoodone.Name = "lblfoodone";
            this.lblfoodone.Size = new System.Drawing.Size(262, 38);
            this.lblfoodone.TabIndex = 0;
            this.lblfoodone.Text = "Enter Name food 1 :";
            // 
            // txtfoodonename
            // 
            this.txtfoodonename.Location = new System.Drawing.Point(388, 58);
            this.txtfoodonename.Name = "txtfoodonename";
            this.txtfoodonename.Size = new System.Drawing.Size(244, 26);
            this.txtfoodonename.TabIndex = 1;
            // 
            // lblpriceoffoodtwo
            // 
            this.lblpriceoffoodtwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpriceoffoodtwo.Location = new System.Drawing.Point(38, 122);
            this.lblpriceoffoodtwo.Name = "lblpriceoffoodtwo";
            this.lblpriceoffoodtwo.Size = new System.Drawing.Size(269, 38);
            this.lblpriceoffoodtwo.TabIndex = 2;
            this.lblpriceoffoodtwo.Text = "Enter price food 1 : ";
            // 
            // lblfoodtwo
            // 
            this.lblfoodtwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoodtwo.Location = new System.Drawing.Point(42, 193);
            this.lblfoodtwo.Name = "lblfoodtwo";
            this.lblfoodtwo.Size = new System.Drawing.Size(265, 40);
            this.lblfoodtwo.TabIndex = 3;
            this.lblfoodtwo.Text = "Enter Name food 2 : ";
            // 
            // priceoffoodtwo
            // 
            this.priceoffoodtwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceoffoodtwo.Location = new System.Drawing.Point(38, 262);
            this.priceoffoodtwo.Name = "priceoffoodtwo";
            this.priceoffoodtwo.Size = new System.Drawing.Size(290, 36);
            this.priceoffoodtwo.TabIndex = 4;
            this.priceoffoodtwo.Text = "Enter price of food 2 : ";
            // 
            // txtpriceoffoodone
            // 
            this.txtpriceoffoodone.Location = new System.Drawing.Point(376, 126);
            this.txtpriceoffoodone.Name = "txtpriceoffoodone";
            this.txtpriceoffoodone.Size = new System.Drawing.Size(244, 26);
            this.txtpriceoffoodone.TabIndex = 5;
            // 
            // txtnameoffoodtwo
            // 
            this.txtnameoffoodtwo.Location = new System.Drawing.Point(357, 197);
            this.txtnameoffoodtwo.Name = "txtnameoffoodtwo";
            this.txtnameoffoodtwo.Size = new System.Drawing.Size(244, 26);
            this.txtnameoffoodtwo.TabIndex = 6;
            // 
            // txtpriceoffoodtwo
            // 
            this.txtpriceoffoodtwo.Location = new System.Drawing.Point(343, 282);
            this.txtpriceoffoodtwo.Name = "txtpriceoffoodtwo";
            this.txtpriceoffoodtwo.Size = new System.Drawing.Size(244, 26);
            this.txtpriceoffoodtwo.TabIndex = 7;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(280, 330);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(352, 76);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "calculate the price";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblsalestaxes
            // 
            this.lblsalestaxes.BackColor = System.Drawing.Color.Silver;
            this.lblsalestaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalestaxes.Location = new System.Drawing.Point(383, 445);
            this.lblsalestaxes.Name = "lblsalestaxes";
            this.lblsalestaxes.Size = new System.Drawing.Size(413, 43);
            this.lblsalestaxes.TabIndex = 9;
            this.lblsalestaxes.Click += new System.EventHandler(this.lblsalestaxes_Click);
            // 
            // lblsalestax
            // 
            this.lblsalestax.BackColor = System.Drawing.Color.White;
            this.lblsalestax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalestax.Location = new System.Drawing.Point(17, 467);
            this.lblsalestax.Name = "lblsalestax";
            this.lblsalestax.Size = new System.Drawing.Size(196, 34);
            this.lblsalestax.TabIndex = 10;
            this.lblsalestax.Text = "sales tax: ";
            // 
            // lblslestips
            // 
            this.lblslestips.BackColor = System.Drawing.Color.White;
            this.lblslestips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslestips.Location = new System.Drawing.Point(12, 549);
            this.lblslestips.Name = "lblslestips";
            this.lblslestips.Size = new System.Drawing.Size(196, 34);
            this.lblslestips.TabIndex = 11;
            this.lblslestips.Text = "sales tips :  ";
            // 
            // lblsalestips
            // 
            this.lblsalestips.BackColor = System.Drawing.Color.Silver;
            this.lblsalestips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalestips.Location = new System.Drawing.Point(395, 527);
            this.lblsalestips.Name = "lblsalestips";
            this.lblsalestips.Size = new System.Drawing.Size(413, 41);
            this.lblsalestips.TabIndex = 12;
            // 
            // lbltotalamout
            // 
            this.lbltotalamout.BackColor = System.Drawing.Color.White;
            this.lbltotalamout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamout.Location = new System.Drawing.Point(12, 621);
            this.lbltotalamout.Name = "lbltotalamout";
            this.lbltotalamout.Size = new System.Drawing.Size(196, 34);
            this.lbltotalamout.TabIndex = 13;
            this.lbltotalamout.Text = "total amount : ";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.BackColor = System.Drawing.Color.Silver;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(395, 614);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(413, 41);
            this.lbltotalamount.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 685);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lbltotalamout);
            this.Controls.Add(this.lblsalestips);
            this.Controls.Add(this.lblslestips);
            this.Controls.Add(this.lblsalestax);
            this.Controls.Add(this.lblsalestaxes);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtpriceoffoodtwo);
            this.Controls.Add(this.txtnameoffoodtwo);
            this.Controls.Add(this.txtpriceoffoodone);
            this.Controls.Add(this.priceoffoodtwo);
            this.Controls.Add(this.lblfoodtwo);
            this.Controls.Add(this.lblpriceoffoodtwo);
            this.Controls.Add(this.txtfoodonename);
            this.Controls.Add(this.lblfoodone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfoodone;
        private System.Windows.Forms.TextBox txtfoodonename;
        private System.Windows.Forms.Label lblpriceoffoodtwo;
        private System.Windows.Forms.Label lblfoodtwo;
        private System.Windows.Forms.Label priceoffoodtwo;
        private System.Windows.Forms.TextBox txtpriceoffoodone;
        private System.Windows.Forms.TextBox txtnameoffoodtwo;
        private System.Windows.Forms.TextBox txtpriceoffoodtwo;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblsalestaxes;
        private System.Windows.Forms.Label lblsalestax;
        private System.Windows.Forms.Label lblslestips;
        private System.Windows.Forms.Label lblsalestips;
        private System.Windows.Forms.Label lbltotalamout;
        private System.Windows.Forms.Label lbltotalamount;
    }
}

