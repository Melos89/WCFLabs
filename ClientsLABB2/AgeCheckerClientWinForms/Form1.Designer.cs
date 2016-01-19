namespace AgeCheckerClientWinForms
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
            this.DateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AgeInDaysLabel = new System.Windows.Forms.Label();
            this.AgeInHoursLabel = new System.Windows.Forms.Label();
            this.AgeInYearsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(-1, 33);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(100, 20);
            this.DateBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provide your date of birth in a yyyy/mm/dd format";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click it!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgeInDaysLabel
            // 
            this.AgeInDaysLabel.AutoSize = true;
            this.AgeInDaysLabel.Location = new System.Drawing.Point(113, 64);
            this.AgeInDaysLabel.Name = "AgeInDaysLabel";
            this.AgeInDaysLabel.Size = new System.Drawing.Size(59, 13);
            this.AgeInDaysLabel.TabIndex = 3;
            this.AgeInDaysLabel.Text = "AgeInDays";
            this.AgeInDaysLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // AgeInHoursLabel
            // 
            this.AgeInHoursLabel.AutoSize = true;
            this.AgeInHoursLabel.Location = new System.Drawing.Point(113, 89);
            this.AgeInHoursLabel.Name = "AgeInHoursLabel";
            this.AgeInHoursLabel.Size = new System.Drawing.Size(63, 13);
            this.AgeInHoursLabel.TabIndex = 4;
            this.AgeInHoursLabel.Text = "AgeInHours";
            // 
            // AgeInYearsLabel
            // 
            this.AgeInYearsLabel.AutoSize = true;
            this.AgeInYearsLabel.Location = new System.Drawing.Point(114, 113);
            this.AgeInYearsLabel.Name = "AgeInYearsLabel";
            this.AgeInYearsLabel.Size = new System.Drawing.Size(62, 13);
            this.AgeInYearsLabel.TabIndex = 5;
            this.AgeInYearsLabel.Text = "AgeInYears";
            this.AgeInYearsLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AgeInYearsLabel);
            this.Controls.Add(this.AgeInHoursLabel);
            this.Controls.Add(this.AgeInDaysLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AgeInDaysLabel;
        private System.Windows.Forms.Label AgeInHoursLabel;
        private System.Windows.Forms.Label AgeInYearsLabel;
    }
}

