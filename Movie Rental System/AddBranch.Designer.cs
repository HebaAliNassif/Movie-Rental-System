namespace Movie_Rental_System
{
    partial class AddBranch
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
            this.BranchPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BranchEmailTextBox = new System.Windows.Forms.TextBox();
            this.BranchAddressTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Backspace)).BeginInit();
            this.SuspendLayout();
            // 
            // BranchPhoneNumberTextBox
            // 
            this.BranchPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchPhoneNumberTextBox.Location = new System.Drawing.Point(259, 193);
            this.BranchPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BranchPhoneNumberTextBox.Name = "BranchPhoneNumberTextBox";
            this.BranchPhoneNumberTextBox.Size = new System.Drawing.Size(261, 30);
            this.BranchPhoneNumberTextBox.TabIndex = 19;
            this.BranchPhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_ONLY_NUMBER_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Email";
            // 
            // BranchEmailTextBox
            // 
            this.BranchEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchEmailTextBox.Location = new System.Drawing.Point(259, 134);
            this.BranchEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BranchEmailTextBox.Name = "BranchEmailTextBox";
            this.BranchEmailTextBox.Size = new System.Drawing.Size(261, 30);
            this.BranchEmailTextBox.TabIndex = 14;
            // 
            // BranchAddressTextBox
            // 
            this.BranchAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchAddressTextBox.Location = new System.Drawing.Point(259, 83);
            this.BranchAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BranchAddressTextBox.Name = "BranchAddressTextBox";
            this.BranchAddressTextBox.Size = new System.Drawing.Size(261, 30);
            this.BranchAddressTextBox.TabIndex = 13;
            this.BranchAddressTextBox.TextChanged += new System.EventHandler(this.BranchAddressTextBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(259, 253);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "Add New Branch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Backspace
            // 
            this.Backspace.Image = global::Movie_Rental_System.Properties.Resources.kisspng_computer_keyboard_backspace_computer_icons_symbol_space_button_5b2068932d8227_7224148515288505791864;
            this.Backspace.Location = new System.Drawing.Point(3, 1);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(63, 35);
            this.Backspace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Backspace.TabIndex = 20;
            this.Backspace.TabStop = false;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // AddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.BranchPhoneNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BranchEmailTextBox);
            this.Controls.Add(this.BranchAddressTextBox);
            this.Controls.Add(this.button3);
            this.Name = "AddBranch";
            this.Text = "AddBranch";
            this.Load += new System.EventHandler(this.AddBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Backspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BranchPhoneNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BranchEmailTextBox;
        private System.Windows.Forms.TextBox BranchAddressTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox Backspace;
    }
}
