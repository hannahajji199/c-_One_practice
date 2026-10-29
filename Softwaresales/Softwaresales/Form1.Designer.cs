namespace Softwaresales
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
            this.lblnumpck = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtnumofpck = new System.Windows.Forms.TextBox();
            this.txtpriceperpck = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblnumpck
            // 
            this.lblnumpck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumpck.Location = new System.Drawing.Point(29, 57);
            this.lblnumpck.Name = "lblnumpck";
            this.lblnumpck.Size = new System.Drawing.Size(252, 39);
            this.lblnumpck.TabIndex = 0;
            this.lblnumpck.Text = "Number of packages : ";
            // 
            // lblprice
            // 
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(39, 140);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(210, 38);
            this.lblprice.TabIndex = 1;
            this.lblprice.Text = "Price per pck :";
            // 
            // txtnumofpck
            // 
            this.txtnumofpck.Location = new System.Drawing.Point(323, 58);
            this.txtnumofpck.Multiline = true;
            this.txtnumofpck.Name = "txtnumofpck";
            this.txtnumofpck.Size = new System.Drawing.Size(247, 38);
            this.txtnumofpck.TabIndex = 2;
            // 
            // txtpriceperpck
            // 
            this.txtpriceperpck.Location = new System.Drawing.Point(294, 141);
            this.txtpriceperpck.Multiline = true;
            this.txtpriceperpck.Name = "txtpriceperpck";
            this.txtpriceperpck.Size = new System.Drawing.Size(258, 37);
            this.txtpriceperpck.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "&calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(228, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "c&lear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(400, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 53);
            this.button3.TabIndex = 6;
            this.button3.Text = "&Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(600, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 524);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 568);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpriceperpck);
            this.Controls.Add(this.txtnumofpck);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblnumpck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumpck;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtnumofpck;
        private System.Windows.Forms.TextBox txtpriceperpck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

