namespace Movie_Rental_System
{
    partial class Movie_Reviews_Ratings
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Reviewlabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backspace)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(618, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Reviewlabel
            // 
            this.Reviewlabel.AutoSize = true;
            this.Reviewlabel.BackColor = System.Drawing.SystemColors.Control;
            this.Reviewlabel.Location = new System.Drawing.Point(285, 212);
            this.Reviewlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Reviewlabel.Name = "Reviewlabel";
            this.Reviewlabel.Size = new System.Drawing.Size(110, 17);
            this.Reviewlabel.TabIndex = 1;
            this.Reviewlabel.Text = "No Reviews Yet!";
            this.Reviewlabel.Click += new System.EventHandler(this.Reviewlabel_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(588, 2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(106, 32);
            this.LogOutButton.TabIndex = 31;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Backspace
            // 
            this.Backspace.Image = global::Movie_Rental_System.Properties.Resources.kisspng_computer_keyboard_backspace_computer_icons_symbol_space_button_5b2068932d8227_7224148515288505791864;
            this.Backspace.Location = new System.Drawing.Point(1, 2);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(63, 35);
            this.Backspace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Backspace.TabIndex = 30;
            this.Backspace.TabStop = false;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // Movie_Reviews_Ratings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 509);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Reviewlabel);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Movie_Reviews_Ratings";
            this.Text = "Movie_Reviews_Ratings";
            this.Load += new System.EventHandler(this.Movie_Reviews_Ratings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Reviewlabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.PictureBox Backspace;
    }
}
