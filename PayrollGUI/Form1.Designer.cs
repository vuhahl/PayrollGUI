namespace PayrollGUI
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1Heading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxssn = new System.Windows.Forms.TextBox();
            this.textBoxpayrate = new System.Windows.Forms.TextBox();
            this.textBoxhrswrked = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(175, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(145, 352);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 37);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1Heading
            // 
            this.label1Heading.AutoSize = true;
            this.label1Heading.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Heading.Location = new System.Drawing.Point(90, 50);
            this.label1Heading.Name = "label1Heading";
            this.label1Heading.Size = new System.Drawing.Size(233, 27);
            this.label1Heading.TabIndex = 2;
            this.label1Heading.Text = "Payroll Calculator";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.textBoxhrswrked);
            this.panel1.Controls.Add(this.textBoxpayrate);
            this.panel1.Controls.Add(this.textBoxssn);
            this.panel1.Controls.Add(this.textBoxname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label1Heading);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(63, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 445);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Social Security #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hourly Pay Rate in $: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "# of Hours Worked:";
            // 
            // textBoxname
            // 
            this.textBoxname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxname.Location = new System.Drawing.Point(208, 119);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(176, 22);
            this.textBoxname.TabIndex = 7;
            // 
            // textBoxssn
            // 
            this.textBoxssn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxssn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxssn.Location = new System.Drawing.Point(208, 173);
            this.textBoxssn.Name = "textBoxssn";
            this.textBoxssn.Size = new System.Drawing.Size(176, 22);
            this.textBoxssn.TabIndex = 8;
            // 
            // textBoxpayrate
            // 
            this.textBoxpayrate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxpayrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxpayrate.Location = new System.Drawing.Point(208, 233);
            this.textBoxpayrate.Name = "textBoxpayrate";
            this.textBoxpayrate.Size = new System.Drawing.Size(176, 22);
            this.textBoxpayrate.TabIndex = 9;
            // 
            // textBoxhrswrked
            // 
            this.textBoxhrswrked.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxhrswrked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxhrswrked.Location = new System.Drawing.Point(208, 293);
            this.textBoxhrswrked.Name = "textBoxhrswrked";
            this.textBoxhrswrked.Size = new System.Drawing.Size(176, 22);
            this.textBoxhrswrked.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 496);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1Heading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxhrswrked;
        private System.Windows.Forms.TextBox textBoxpayrate;
        private System.Windows.Forms.TextBox textBoxssn;
    }
}

