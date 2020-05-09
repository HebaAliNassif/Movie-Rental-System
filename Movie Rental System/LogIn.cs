using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Rental_System
{
    public partial class LogIn : Form
    {
        Form ParentForm;
        Controller controllerObj;
        public LogIn(Form PF)
        {
            InitializeComponent();
            ParentForm = PF;
            controllerObj = new Controller();

        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Hide();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            String UserName;
            String Password;
            try
            {
                UserName = UsernameTextBox.Text;
            }
            catch
            {
                MessageBox.Show("Please enter a username");
                return;
            }
            try
            {
                Password = PasswordTextBox.Text;
            }
            catch
            {
                MessageBox.Show("Please enter a password");
                return;
            }
            bool Customer = false;
            bool Staff = false;
            bool Admin = false;
            int i = 0;

            i = controllerObj.SignInCustomer(UserName, Password);
            if (i != 0)
            {
                Customer = true;
            }
            else
            {
                i = 0;
                i = controllerObj.SignInStaff(UserName, Password);
                if (i != 0)
                {
                    string role = controllerObj.GetStaffWithName(UserName).Rows[0]["Role"].ToString(); ;
                    if (role == "S")
                    {
                        Staff = true;
                    }
                    else
                    {
                        Admin = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid username or password");
                    return;
                }
            }

            if (Customer)
            {
                AccountDetailsForm S = new AccountDetailsForm(UserName, this);
                S.Show();
                this.Hide();
            }
            else if (Staff)
            {
                StaffAccount S = new StaffAccount(this, UserName, i);
                S.Show();
                this.Hide();
            }
            else if (Admin)
            {
                AdminAccount A = new AdminAccount(this, UserName, i);
                A.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a valid username or password");
                return;
            }

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
