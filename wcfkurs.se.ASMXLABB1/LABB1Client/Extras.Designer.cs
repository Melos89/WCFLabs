﻿namespace LABB1Client
{
    partial class Extras
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
            this.StopMotionMoviesBox = new System.Windows.Forms.TextBox();
            this.StopMotionLabel = new System.Windows.Forms.Label();
            this.StopMotionMovieButton = new System.Windows.Forms.Button();
            this.StopMotionMovieTxtBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FruitTextBox = new System.Windows.Forms.TextBox();
            this.FruitButton = new System.Windows.Forms.Button();
            this.FruitResultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeadPeopleComboBox = new System.Windows.Forms.ComboBox();
            this.DeadPeopleResultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StopMotionMoviesBox
            // 
            this.StopMotionMoviesBox.Location = new System.Drawing.Point(1, 16);
            this.StopMotionMoviesBox.Name = "StopMotionMoviesBox";
            this.StopMotionMoviesBox.Size = new System.Drawing.Size(100, 20);
            this.StopMotionMoviesBox.TabIndex = 0;
            // 
            // StopMotionLabel
            // 
            this.StopMotionLabel.AutoSize = true;
            this.StopMotionLabel.Location = new System.Drawing.Point(-2, 0);
            this.StopMotionLabel.Name = "StopMotionLabel";
            this.StopMotionLabel.Size = new System.Drawing.Size(265, 13);
            this.StopMotionLabel.TabIndex = 1;
            this.StopMotionLabel.Text = "Provide a year between  1917 and 2015 to find movies";
            // 
            // StopMotionMovieButton
            // 
            this.StopMotionMovieButton.Location = new System.Drawing.Point(1, 42);
            this.StopMotionMovieButton.Name = "StopMotionMovieButton";
            this.StopMotionMovieButton.Size = new System.Drawing.Size(75, 23);
            this.StopMotionMovieButton.TabIndex = 2;
            this.StopMotionMovieButton.Text = "Find movie!";
            this.StopMotionMovieButton.UseVisualStyleBackColor = true;
            this.StopMotionMovieButton.Click += new System.EventHandler(this.StopMotionMovieButton_Click);
            // 
            // StopMotionMovieTxtBoxResult
            // 
            this.StopMotionMovieTxtBoxResult.Location = new System.Drawing.Point(153, 17);
            this.StopMotionMovieTxtBoxResult.Multiline = true;
            this.StopMotionMovieTxtBoxResult.Name = "StopMotionMovieTxtBoxResult";
            this.StopMotionMovieTxtBoxResult.ReadOnly = true;
            this.StopMotionMovieTxtBoxResult.Size = new System.Drawing.Size(383, 74);
            this.StopMotionMovieTxtBoxResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Print a letter to see fruit beginning with that letter!";
            // 
            // FruitTextBox
            // 
            this.FruitTextBox.Location = new System.Drawing.Point(13, 111);
            this.FruitTextBox.Name = "FruitTextBox";
            this.FruitTextBox.Size = new System.Drawing.Size(28, 20);
            this.FruitTextBox.TabIndex = 5;
            // 
            // FruitButton
            // 
            this.FruitButton.Location = new System.Drawing.Point(13, 138);
            this.FruitButton.Name = "FruitButton";
            this.FruitButton.Size = new System.Drawing.Size(75, 23);
            this.FruitButton.TabIndex = 6;
            this.FruitButton.Text = "Fruity";
            this.FruitButton.UseVisualStyleBackColor = true;
            this.FruitButton.Click += new System.EventHandler(this.FruitButton_Click);
            // 
            // FruitResultTextBox
            // 
            this.FruitResultTextBox.Location = new System.Drawing.Point(153, 110);
            this.FruitResultTextBox.Multiline = true;
            this.FruitResultTextBox.Name = "FruitResultTextBox";
            this.FruitResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FruitResultTextBox.Size = new System.Drawing.Size(383, 104);
            this.FruitResultTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Find out who died in what month the year 2006! ";
            // 
            // DeadPeopleComboBox
            // 
            this.DeadPeopleComboBox.FormattingEnabled = true;
            this.DeadPeopleComboBox.Items.AddRange(new object[] {
            "januari",
            "februari",
            "mars",
            "april",
            "maj",
            "juni",
            "juli",
            "augusti",
            "september",
            "oktober",
            "november",
            "december"});
            this.DeadPeopleComboBox.Location = new System.Drawing.Point(1, 233);
            this.DeadPeopleComboBox.Name = "DeadPeopleComboBox";
            this.DeadPeopleComboBox.Size = new System.Drawing.Size(121, 21);
            this.DeadPeopleComboBox.TabIndex = 9;
            this.DeadPeopleComboBox.SelectedIndexChanged += new System.EventHandler(this.DeadPeopleComboBox_SelectedIndexChanged);
            // 
            // DeadPeopleResultBox
            // 
            this.DeadPeopleResultBox.Location = new System.Drawing.Point(153, 233);
            this.DeadPeopleResultBox.Multiline = true;
            this.DeadPeopleResultBox.Name = "DeadPeopleResultBox";
            this.DeadPeopleResultBox.ReadOnly = true;
            this.DeadPeopleResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DeadPeopleResultBox.Size = new System.Drawing.Size(383, 64);
            this.DeadPeopleResultBox.TabIndex = 10;
            // 
            // Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 387);
            this.Controls.Add(this.DeadPeopleResultBox);
            this.Controls.Add(this.DeadPeopleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FruitResultTextBox);
            this.Controls.Add(this.FruitButton);
            this.Controls.Add(this.FruitTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopMotionMovieTxtBoxResult);
            this.Controls.Add(this.StopMotionMovieButton);
            this.Controls.Add(this.StopMotionLabel);
            this.Controls.Add(this.StopMotionMoviesBox);
            this.Name = "Extras";
            this.Text = "Extras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StopMotionMoviesBox;
        private System.Windows.Forms.Label StopMotionLabel;
        private System.Windows.Forms.Button StopMotionMovieButton;
        private System.Windows.Forms.TextBox StopMotionMovieTxtBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FruitTextBox;
        private System.Windows.Forms.Button FruitButton;
        private System.Windows.Forms.TextBox FruitResultTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DeadPeopleComboBox;
        private System.Windows.Forms.TextBox DeadPeopleResultBox;
    }
}