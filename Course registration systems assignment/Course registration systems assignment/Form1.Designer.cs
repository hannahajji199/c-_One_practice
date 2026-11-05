namespace Course_registration_systems_assignment
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
            this.txtnumofcourse = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBoxregister = new System.Windows.Forms.ListBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtcprice = new System.Windows.Forms.TextBox();
            this.txtcoursename = new System.Windows.Forms.TextBox();
            this.lblcprice = new System.Windows.Forms.Label();
            this.lblcname = new System.Windows.Forms.Label();
            this.lblnumofcourse = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnumofcourse
            // 
            this.txtnumofcourse.Location = new System.Drawing.Point(273, 148);
            this.txtnumofcourse.Name = "txtnumofcourse";
            this.txtnumofcourse.Size = new System.Drawing.Size(231, 26);
            this.txtnumofcourse.TabIndex = 29;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(20, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(328, 29);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Scholarship student (20% dis)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1003, 508);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(144, 65);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(806, 510);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(144, 65);
            this.btnclear.TabIndex = 22;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(602, 516);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(146, 59);
            this.btncalculate.TabIndex = 21;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(602, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(512, 464);
            this.listBox1.TabIndex = 26;
            // 
            // listBoxregister
            // 
            this.listBoxregister.FormattingEnabled = true;
            this.listBoxregister.ItemHeight = 20;
            this.listBoxregister.Location = new System.Drawing.Point(43, 498);
            this.listBoxregister.Name = "listBoxregister";
            this.listBoxregister.Size = new System.Drawing.Size(495, 144);
            this.listBoxregister.TabIndex = 25;
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(301, 178);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(176, 41);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "&Remove Course ";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(59, 178);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(176, 41);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "&Add Course";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtcprice
            // 
            this.txtcprice.Location = new System.Drawing.Point(253, 123);
            this.txtcprice.Multiline = true;
            this.txtcprice.Name = "txtcprice";
            this.txtcprice.Size = new System.Drawing.Size(224, 26);
            this.txtcprice.TabIndex = 1;
            // 
            // txtcoursename
            // 
            this.txtcoursename.Location = new System.Drawing.Point(265, 63);
            this.txtcoursename.Name = "txtcoursename";
            this.txtcoursename.Size = new System.Drawing.Size(212, 26);
            this.txtcoursename.TabIndex = 0;
            // 
            // lblcprice
            // 
            this.lblcprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcprice.Location = new System.Drawing.Point(42, 129);
            this.lblcprice.Name = "lblcprice";
            this.lblcprice.Size = new System.Drawing.Size(202, 32);
            this.lblcprice.TabIndex = 1;
            this.lblcprice.Text = "Course Price : ";
            // 
            // lblcname
            // 
            this.lblcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcname.Location = new System.Drawing.Point(42, 62);
            this.lblcname.Name = "lblcname";
            this.lblcname.Size = new System.Drawing.Size(158, 35);
            this.lblcname.TabIndex = 0;
            this.lblcname.Text = "Course Name: ";
            // 
            // lblnumofcourse
            // 
            this.lblnumofcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumofcourse.Location = new System.Drawing.Point(25, 147);
            this.lblnumofcourse.Name = "lblnumofcourse";
            this.lblnumofcourse.Size = new System.Drawing.Size(215, 40);
            this.lblnumofcourse.TabIndex = 28;
            this.lblnumofcourse.Text = "Number_of_Course :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnremove);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txtcprice);
            this.groupBox1.Controls.Add(this.txtcoursename);
            this.groupBox1.Controls.Add(this.lblcprice);
            this.groupBox1.Controls.Add(this.lblcname);
            this.groupBox1.Location = new System.Drawing.Point(20, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 225);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(266, 107);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(231, 26);
            this.txtid.TabIndex = 19;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(266, 58);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(231, 26);
            this.txtage.TabIndex = 17;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(266, 7);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(231, 26);
            this.txtname.TabIndex = 15;
            // 
            // lblid
            // 
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(15, 107);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(134, 40);
            this.lblid.TabIndex = 20;
            this.lblid.Text = "Student_ID";
            // 
            // lblage
            // 
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(25, 57);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(152, 40);
            this.lblage.TabIndex = 18;
            this.lblage.Text = "Student_Age:";
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(15, 7);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(177, 29);
            this.lblname.TabIndex = 16;
            this.lblname.Text = "Student_name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 710);
            this.Controls.Add(this.txtnumofcourse);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBoxregister);
            this.Controls.Add(this.lblnumofcourse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumofcourse;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBoxregister;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtcprice;
        private System.Windows.Forms.TextBox txtcoursename;
        private System.Windows.Forms.Label lblcprice;
        private System.Windows.Forms.Label lblcname;
        private System.Windows.Forms.Label lblnumofcourse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
    }
}

