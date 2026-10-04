namespace payrollwith_overtime
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
            this.lblhours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblgrossby = new System.Windows.Forms.Label();
            this.txthoursworked = new System.Windows.Forms.TextBox();
            this.txtpayrate = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhours
            // 
            this.lblhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhours.Location = new System.Drawing.Point(40, 55);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(286, 65);
            this.lblhours.TabIndex = 0;
            this.lblhours.Text = "Enter Hours worked : ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter pay Rate :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 62);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bross by : ";
            // 
            // lblgrossby
            // 
            this.lblgrossby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgrossby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrossby.Location = new System.Drawing.Point(324, 282);
            this.lblgrossby.Name = "lblgrossby";
            this.lblgrossby.Size = new System.Drawing.Size(487, 71);
            this.lblgrossby.TabIndex = 3;
            this.lblgrossby.UseWaitCursor = true;
            // 
            // txthoursworked
            // 
            this.txthoursworked.Location = new System.Drawing.Point(445, 55);
            this.txthoursworked.Name = "txthoursworked";
            this.txthoursworked.Size = new System.Drawing.Size(287, 26);
            this.txthoursworked.TabIndex = 4;
            // 
            // txtpayrate
            // 
            this.txtpayrate.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtpayrate.Location = new System.Drawing.Point(435, 164);
            this.txtpayrate.Name = "txtpayrate";
            this.txtpayrate.Size = new System.Drawing.Size(297, 26);
            this.txtpayrate.TabIndex = 5;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(12, 488);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(274, 95);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "&Calculate &gross pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(352, 488);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(212, 82);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(626, 488);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(212, 82);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "c&lose";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(867, 609);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtpayrate);
            this.Controls.Add(this.txthoursworked);
            this.Controls.Add(this.lblgrossby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblhours);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblgrossby;
        private System.Windows.Forms.TextBox txthoursworked;
        private System.Windows.Forms.TextBox txtpayrate;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}

