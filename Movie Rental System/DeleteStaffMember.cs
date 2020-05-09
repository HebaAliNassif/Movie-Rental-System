using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movie_Rental_System
{
    public partial class DeleteStaffMember : Form
    {
        Controller controllerObj;
        Form ParentForm;
        Validation V;
        //private object UserNameTextBox;

        public DeleteStaffMember(Form PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ParentForm = PF;
        }

        private void DeleteStaffMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(UserNameText.Text))
            {
                DataTable T = controllerObj.GetStaffWithName(UserNameText.Text);
                if (T.Rows.Count!= 0)
                {
                    if(Convert.ToChar(T.Rows[0]["Role"])=='S')
                    {
                        controllerObj.DeleteStaffMember(UserNameText.Text);
                        MessageBox.Show("Staff is Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Employee does not exist");
                    }
                }
                else
                {
                    MessageBox.Show("Employee does not exist");
                }
            }
            else
            {
                MessageBox.Show("Please choose username.");
                return;
            }

        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Hide();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            StartPage S = new StartPage();
            S.Show();
            this.Hide();
        }
    }
}
