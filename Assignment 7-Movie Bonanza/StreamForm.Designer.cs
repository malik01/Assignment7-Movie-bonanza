namespace Assignment_7_Movie_Bonanza
{
    partial class StreamForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.GrandTotalText = new System.Windows.Forms.Label();
            this.ChosenMovieLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrandTotalText
            // 
            this.GrandTotalText.AutoSize = true;
            this.GrandTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalText.Location = new System.Drawing.Point(1, 9);
            this.GrandTotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrandTotalText.Name = "GrandTotalText";
            this.GrandTotalText.Size = new System.Drawing.Size(371, 24);
            this.GrandTotalText.TabIndex = 2;
            this.GrandTotalText.Text = "Your Credit Card will be charged [X dollars]";
            this.GrandTotalText.Click += new System.EventHandler(this.GrandTotalText_Click);
            // 
            // ChosenMovieLabel
            // 
            this.ChosenMovieLabel.AutoSize = true;
            this.ChosenMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChosenMovieLabel.Location = new System.Drawing.Point(43, 50);
            this.ChosenMovieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChosenMovieLabel.Name = "ChosenMovieLabel";
            this.ChosenMovieLabel.Size = new System.Drawing.Size(275, 18);
            this.ChosenMovieLabel.TabIndex = 3;
            this.ChosenMovieLabel.Text = "[Your Movie] will begin streaming shortly.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thank you for choosing Movie Bonanza!\r\nCopyright: Meer Zaheen Nazmul";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 189);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChosenMovieLabel);
            this.Controls.Add(this.GrandTotalText);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GrandTotalText;
        private System.Windows.Forms.Label ChosenMovieLabel;
        private System.Windows.Forms.Label label1;
    }
}