namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepertment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(394, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Infromation ";
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(64, 106);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(459, 39);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Enter The Student Name ";
            // 
            // lblstudentid
            // 
            this.lblstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(63, 171);
            this.lblstudentid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(369, 50);
            this.lblstudentid.TabIndex = 2;
            this.lblstudentid.Text = "Enter The Student ID ";
            // 
            // lbldepertment
            // 
            this.lbldepertment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepertment.Location = new System.Drawing.Point(63, 235);
            this.lbldepertment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldepertment.Name = "lbldepertment";
            this.lbldepertment.Size = new System.Drawing.Size(417, 53);
            this.lbldepertment.TabIndex = 3;
            this.lbldepertment.Text = "Enter The department  ";
            // 
            // lblsemester
            // 
            this.lblsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.Location = new System.Drawing.Point(63, 306);
            this.lblsemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(417, 53);
            this.lblsemester.TabIndex = 4;
            this.lblsemester.Text = "Enter The semester";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(606, 106);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(308, 22);
            this.txtname.TabIndex = 5;
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.Color.Transparent;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(127, 405);
            this.lbloutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(1058, 52);
            this.lbloutput.TabIndex = 6;
            this.lbloutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(606, 182);
            this.txtstudentid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(308, 22);
            this.txtstudentid.TabIndex = 7;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(606, 246);
            this.txtdepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(308, 22);
            this.txtdepartment.TabIndex = 8;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(606, 316);
            this.txtsemester.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(308, 22);
            this.txtsemester.TabIndex = 9;
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.BackColor = System.Drawing.Color.Silver;
            this.btnshowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowinfo.Location = new System.Drawing.Point(246, 543);
            this.btnshowinfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(277, 43);
            this.btnshowinfo.TabIndex = 10;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = false;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Silver;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(597, 545);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(170, 39);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear ";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Silver;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(853, 543);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(156, 39);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 679);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepertment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Student Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepertment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

