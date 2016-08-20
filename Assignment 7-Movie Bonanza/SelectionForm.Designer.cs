namespace Assignment_7_Movie_Bonanza
{
    partial class SelectionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.movielistbox = new System.Windows.Forms.ListBox();
            this.costtextbox = new System.Windows.Forms.TextBox();
            this.titletextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.catagoryDropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.moviespictures = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviespictures)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.movielistbox);
            this.groupBox1.Controls.Add(this.costtextbox);
            this.groupBox1.Controls.Add(this.titletextbox);
            this.groupBox1.Controls.Add(this.moviespictures);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(328, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Selection";
            // 
            // movielistbox
            // 
            this.movielistbox.FormattingEnabled = true;
            this.movielistbox.ItemHeight = 25;
            this.movielistbox.Location = new System.Drawing.Point(201, 116);
            this.movielistbox.Name = "movielistbox";
            this.movielistbox.Size = new System.Drawing.Size(136, 154);
            this.movielistbox.Sorted = true;
            this.movielistbox.TabIndex = 6;
            this.movielistbox.SelectedIndexChanged += new System.EventHandler(this.movielistbox_SelectedIndexChanged);
            // 
            // costtextbox
            // 
            this.costtextbox.Location = new System.Drawing.Point(357, 194);
            this.costtextbox.Name = "costtextbox";
            this.costtextbox.ReadOnly = true;
            this.costtextbox.Size = new System.Drawing.Size(100, 30);
            this.costtextbox.TabIndex = 5;
            this.costtextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // titletextbox
            // 
            this.titletextbox.Location = new System.Drawing.Point(201, 54);
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.ReadOnly = true;
            this.titletextbox.Size = new System.Drawing.Size(228, 30);
            this.titletextbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITLE";
            // 
            // catagoryDropDown
            // 
            this.catagoryDropDown.BackColor = System.Drawing.Color.White;
            this.catagoryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagoryDropDown.FormattingEnabled = true;
            this.catagoryDropDown.Items.AddRange(new object[] {
            "Comedy",
            "Drama ",
            "Action ",
            "Sci-Fi ",
            "Horror ",
            "Thriller ",
            "Family ",
            "New Releases"});
            this.catagoryDropDown.Location = new System.Drawing.Point(67, 42);
            this.catagoryDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.catagoryDropDown.MaxDropDownItems = 6;
            this.catagoryDropDown.Name = "catagoryDropDown";
            this.catagoryDropDown.Size = new System.Drawing.Size(217, 33);
            this.catagoryDropDown.TabIndex = 2;
            this.catagoryDropDown.SelectedIndexChanged += new System.EventHandler(this.catagoryDropDown_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(703, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please Choose A Movie From The Categories Below That You Wish To Stream";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(681, 404);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(104, 36);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // moviespictures
            // 
            this.moviespictures.Location = new System.Drawing.Point(6, 73);
            this.moviespictures.Name = "moviespictures";
            this.moviespictures.Size = new System.Drawing.Size(120, 169);
            this.moviespictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moviespictures.TabIndex = 3;
            this.moviespictures.TabStop = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 452);
            this.ControlBox = false;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.catagoryDropDown);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectionForm";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviespictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costtextbox;
        private System.Windows.Forms.TextBox titletextbox;
        private System.Windows.Forms.PictureBox moviespictures;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox catagoryDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox movielistbox;
    }
}