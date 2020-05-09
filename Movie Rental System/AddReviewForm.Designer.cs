namespace Movie_Rental_System
{
    partial class AddReviewForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.NumericUpDown();
            this.ReviewtextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backspace)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Review";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rating";
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(156, 231);
            this.Rating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(124, 22);
            this.Rating.TabIndex = 2;
            // 
            // ReviewtextBox
            // 
            this.ReviewtextBox.Location = new System.Drawing.Point(156, 66);
            this.ReviewtextBox.Multiline = true;
            this.ReviewtextBox.Name = "ReviewtextBox";
            this.ReviewtextBox.Size = new System.Drawing.Size(339, 143);
            this.ReviewtextBox.TabIndex = 3;
            this.ReviewtextBox.TextChanged += new System.EventHandler(this.ReviewtextBox_TextChanged);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(182, 294);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(165, 36);
            this.Addbutton.TabIndex = 4;
            this.Addbutton.Text = "Add Review";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(675, 15);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(106, 32);
            this.LogOutButton.TabIndex = 29;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Backspace
            // 
            this.Backspace.Image = global::Movie_Rental_System.Properties.Resources.kisspng_computer_keyboard_backspace_computer_icons_symbol_space_button_5b2068932d8227_7224148515288505791864;
            this.Backspace.Location = new System.Drawing.Point(12, 12);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(63, 35);
            this.Backspace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Backspace.TabIndex = 28;
            this.Backspace.TabStop = false;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // AddReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 436);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.ReviewtextBox);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddReviewForm";
            this.Text = "Add Review";
            this.Load += new System.EventHandler(this.AddReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Rating;
        private System.Windows.Forms.TextBox ReviewtextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.PictureBox Backspace;
    }
}
