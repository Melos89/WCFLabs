namespace LABB1Client
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
            this.StopMotionMovieResultLabel = new System.Windows.Forms.Label();
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
            // StopMotionMovieResultLabel
            // 
            this.StopMotionMovieResultLabel.AutoSize = true;
            this.StopMotionMovieResultLabel.Location = new System.Drawing.Point(128, 19);
            this.StopMotionMovieResultLabel.Name = "StopMotionMovieResultLabel";
            this.StopMotionMovieResultLabel.Size = new System.Drawing.Size(40, 13);
            this.StopMotionMovieResultLabel.TabIndex = 3;
            this.StopMotionMovieResultLabel.Text = "Result:";
            // 
            // Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 387);
            this.Controls.Add(this.StopMotionMovieResultLabel);
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
        private System.Windows.Forms.Label StopMotionMovieResultLabel;
    }
}