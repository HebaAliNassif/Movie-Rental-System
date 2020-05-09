namespace Movie_Rental_System
{
    partial class Insert_Movie
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.PlotLabel = new System.Windows.Forms.Label();
            this.TitletextBox = new System.Windows.Forms.TextBox();
            this.PlottextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.GenrecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReleasedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.Durationlabel = new System.Windows.Forms.Label();
            this.DurationtextBox = new System.Windows.Forms.TextBox();
            this.TrailerLabel = new System.Windows.Forms.Label();
            this.TrailertextBox = new System.Windows.Forms.TextBox();
            this.Minuteslabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.PictureBox();
            this.MoviepictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Backspace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.TitleLabel.Location = new System.Drawing.Point(37, 51);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(40, 17);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.GenreLabel.Location = new System.Drawing.Point(446, 385);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(53, 17);
            this.GenreLabel.TabIndex = 5;
            this.GenreLabel.Text = "Genre";
            this.GenreLabel.Click += new System.EventHandler(this.GenreLabel_Click);
            // 
            // PlotLabel
            // 
            this.PlotLabel.AutoSize = true;
            this.PlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.PlotLabel.Location = new System.Drawing.Point(40, 103);
            this.PlotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlotLabel.Name = "PlotLabel";
            this.PlotLabel.Size = new System.Drawing.Size(36, 17);
            this.PlotLabel.TabIndex = 14;
            this.PlotLabel.Text = "Plot";
            // 
            // TitletextBox
            // 
            this.TitletextBox.Location = new System.Drawing.Point(83, 51);
            this.TitletextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitletextBox.Name = "TitletextBox";
            this.TitletextBox.Size = new System.Drawing.Size(226, 22);
            this.TitletextBox.TabIndex = 16;
            this.TitletextBox.TextChanged += new System.EventHandler(this.TitletextBox_TextChanged);
            // 
            // PlottextBox
            // 
            this.PlottextBox.Location = new System.Drawing.Point(83, 101);
            this.PlottextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlottextBox.Multiline = true;
            this.PlottextBox.Name = "PlottextBox";
            this.PlottextBox.Size = new System.Drawing.Size(320, 203);
            this.PlottextBox.TabIndex = 20;
            this.PlottextBox.TextChanged += new System.EventHandler(this.PlottextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(310, 502);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 30);
            this.AddButton.TabIndex = 23;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(509, 307);
            this.ChooseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(158, 29);
            this.ChooseButton.TabIndex = 24;
            this.ChooseButton.Text = "Browse...";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // GenrecomboBox
            // 
            this.GenrecomboBox.FormattingEnabled = true;
            this.GenrecomboBox.Items.AddRange(new object[] {
            "Horror",
            "Comedy",
            "Romance",
            "Action",
            "Adventure",
            "Documentary",
            "Science-Fiction",
            "Drama ",
            "Animation",
            "Crime",
            "Musical",
            "War",
            "Fantasy",
            "Biography",
            "Disaster"});
            this.GenrecomboBox.Location = new System.Drawing.Point(524, 381);
            this.GenrecomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenrecomboBox.Name = "GenrecomboBox";
            this.GenrecomboBox.Size = new System.Drawing.Size(156, 24);
            this.GenrecomboBox.TabIndex = 27;
            this.GenrecomboBox.SelectedIndexChanged += new System.EventHandler(this.GenrecomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(40, 385);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Release Date";
            // 
            // ReleasedateTimePicker
            // 
            this.ReleasedateTimePicker.Location = new System.Drawing.Point(153, 382);
            this.ReleasedateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReleasedateTimePicker.Name = "ReleasedateTimePicker";
            this.ReleasedateTimePicker.Size = new System.Drawing.Size(247, 22);
            this.ReleasedateTimePicker.TabIndex = 30;
            this.ReleasedateTimePicker.Value = new System.DateTime(2019, 12, 20, 0, 0, 0, 0);
            this.ReleasedateTimePicker.ValueChanged += new System.EventHandler(this.ReleasedateTimePicker_ValueChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.PriceLabel.Location = new System.Drawing.Point(40, 431);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(45, 17);
            this.PriceLabel.TabIndex = 31;
            this.PriceLabel.Text = "Price";
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(93, 430);
            this.PricetextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PricetextBox.MaxLength = 3;
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(105, 22);
            this.PricetextBox.TabIndex = 32;
            this.PricetextBox.TextChanged += new System.EventHandler(this.PricetextBox_TextChanged);
            this.PricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PricetextBox_KeyPress);
            // 
            // Durationlabel
            // 
            this.Durationlabel.AutoSize = true;
            this.Durationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Durationlabel.ForeColor = System.Drawing.Color.Chocolate;
            this.Durationlabel.Location = new System.Drawing.Point(446, 433);
            this.Durationlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Durationlabel.Name = "Durationlabel";
            this.Durationlabel.Size = new System.Drawing.Size(70, 17);
            this.Durationlabel.TabIndex = 33;
            this.Durationlabel.Text = "Duration";
            // 
            // DurationtextBox
            // 
            this.DurationtextBox.Location = new System.Drawing.Point(524, 430);
            this.DurationtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DurationtextBox.MaxLength = 3;
            this.DurationtextBox.Name = "DurationtextBox";
            this.DurationtextBox.Size = new System.Drawing.Size(80, 22);
            this.DurationtextBox.TabIndex = 34;
            this.DurationtextBox.TextChanged += new System.EventHandler(this.DurationtextBox_TextChanged);
            this.DurationtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DurationtextBox_KeyPress);
            // 
            // TrailerLabel
            // 
            this.TrailerLabel.AutoSize = true;
            this.TrailerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrailerLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.TrailerLabel.Location = new System.Drawing.Point(37, 340);
            this.TrailerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrailerLabel.Name = "TrailerLabel";
            this.TrailerLabel.Size = new System.Drawing.Size(56, 17);
            this.TrailerLabel.TabIndex = 35;
            this.TrailerLabel.Text = "Trailer";
            this.TrailerLabel.Click += new System.EventHandler(this.TrailerLabel_Click);
            // 
            // TrailertextBox
            // 
            this.TrailertextBox.Location = new System.Drawing.Point(92, 338);
            this.TrailertextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrailertextBox.Name = "TrailertextBox";
            this.TrailertextBox.Size = new System.Drawing.Size(250, 22);
            this.TrailertextBox.TabIndex = 36;
            this.TrailertextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Minuteslabel
            // 
            this.Minuteslabel.AutoSize = true;
            this.Minuteslabel.Location = new System.Drawing.Point(609, 433);
            this.Minuteslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Minuteslabel.Name = "Minuteslabel";
            this.Minuteslabel.Size = new System.Drawing.Size(57, 17);
            this.Minuteslabel.TabIndex = 37;
            this.Minuteslabel.Text = "minutes";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(651, 4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(106, 32);
            this.LogOutButton.TabIndex = 39;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Backspace
            // 
            this.Backspace.Image = global::Movie_Rental_System.Properties.Resources.kisspng_computer_keyboard_backspace_computer_icons_symbol_space_button_5b2068932d8227_7224148515288505791864;
            this.Backspace.Location = new System.Drawing.Point(12, 1);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(63, 35);
            this.Backspace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Backspace.TabIndex = 38;
            this.Backspace.TabStop = false;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // MoviepictureBox
            // 
            this.MoviepictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoviepictureBox.Location = new System.Drawing.Point(496, 51);
            this.MoviepictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.MoviepictureBox.Name = "MoviepictureBox";
            this.MoviepictureBox.Size = new System.Drawing.Size(184, 232);
            this.MoviepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviepictureBox.TabIndex = 15;
            this.MoviepictureBox.TabStop = false;
            this.MoviepictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Insert_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(758, 545);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Minuteslabel);
            this.Controls.Add(this.TrailertextBox);
            this.Controls.Add(this.TrailerLabel);
            this.Controls.Add(this.DurationtextBox);
            this.Controls.Add(this.Durationlabel);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ReleasedateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenrecomboBox);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PlottextBox);
            this.Controls.Add(this.TitletextBox);
            this.Controls.Add(this.MoviepictureBox);
            this.Controls.Add(this.PlotLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Insert_Movie";
            this.Text = "Insert_Movie";
            this.Load += new System.EventHandler(this.Insert_Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Backspace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviepictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label PlotLabel;
        private System.Windows.Forms.PictureBox MoviepictureBox;
        private System.Windows.Forms.TextBox TitletextBox;
        private System.Windows.Forms.TextBox PlottextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.ComboBox GenrecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ReleasedateTimePicker;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Label Durationlabel;
        private System.Windows.Forms.TextBox DurationtextBox;
        private System.Windows.Forms.Label TrailerLabel;
        private System.Windows.Forms.TextBox TrailertextBox;
        private System.Windows.Forms.Label Minuteslabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.PictureBox Backspace;
    }
}
