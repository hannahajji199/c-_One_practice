namespace Example_nested_if
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
            this.lblyearexp = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lblresultoutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter salary : ";
            // 
            // lblyearexp
            // 
            this.lblyearexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyearexp.Location = new System.Drawing.Point(209, 172);
            this.lblyearexp.Name = "lblyearexp";
            this.lblyearexp.Size = new System.Drawing.Size(218, 55);
            this.lblyearexp.TabIndex = 1;
            this.lblyearexp.Text = "Enter year EXP : ";
            // 
            // lblresult
            // 
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(358, 306);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(211, 47);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "Decision result ";
            // 
            // txtsalary
            // 
            this.txtsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(562, 116);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(242, 30);
            this.txtsalary.TabIndex = 0;
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(562, 186);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(242, 30);
            this.txtyear.TabIndex = 1;
            // 
            // lblresultoutput
            // 
            this.lblresultoutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblresultoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultoutput.Location = new System.Drawing.Point(123, 381);
            this.lblresultoutput.Name = "lblresultoutput";
            this.lblresultoutput.Size = new System.Drawing.Size(661, 67);
            this.lblresultoutput.TabIndex = 2;
            this.lblresultoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "&check Qualification ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(382, 493);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(206, 59);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(618, 498);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(206, 48);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 683);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblresultoutput);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblyearexp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblyearexp;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lblresultoutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}

