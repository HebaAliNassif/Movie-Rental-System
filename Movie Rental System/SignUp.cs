using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Movie_Rental_System
{
    public partial class SignUp : Form
    {
        Form ParentForm;
        Validation V;
        Controller controllerObj;
        public SignUp(Form PF)
        {
            InitializeComponent();
            ParentForm = PF;
            controllerObj = new Controller();

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Hide();
        }
        private void FnameTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FnameTextBox.Text))
            {
                MessageBox.Show("Please enter the First Name");
                return;
            }
            if (String.IsNullOrEmpty(LnameTextBox.Text))
            {
                MessageBox.Show("Please enter the Last Name");
                return;
            }

            if (String.IsNullOrEmpty(UserNameTextBox.Text))
            {
                MessageBox.Show("Please enter a User Name");
                return;
            }
            if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter a Password");
                return;
            }
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                MessageBox.Show("Please enter an Email");
                return;
            }
            if (String.IsNullOrEmpty(CreditCardNumberTextBox.Text))
            {
                MessageBox.Show("Please enter the Credit Card Number");
                return;
            }
            String Fname = FnameTextBox.Text;
            String Lname = LnameTextBox.Text;
            String UserName = UserNameTextBox.Text;
            String Password = PasswordTextBox.Text;
            String PhoneNumber;
            PhoneNumber = PhoneNumberTextBox.Text;

            String Email = EmailTextBox.Text;
            String CreditCardNumber = CreditCardNumberTextBox.Text;
            if (!Validation.IsValidEmail(Email))
            {
                MessageBox.Show("Please enter a valid Email Adress");
                return;
            }
            if (!Validation.IsPasswordValid(Password))
            {
                MessageBox.Show("Please enter a valid Password \n" + "It should contain at least one number,one uppercase letter and 8 letters");
                return;
            }
            if (!String.IsNullOrEmpty(PhoneNumber))
            {
                if (!Validation.IsPhoneNumberVlidate(PhoneNumber))
                {
                    MessageBox.Show("Please enter a valid Phone Number \n");
                    return;
                }
            }
            else
            {
            }
            int T = 0;
            try
            {
                T = controllerObj.GetPersonWithUserName(UserName);
                if (T != 0)
                {
                    MessageBox.Show("Please choose another username.It already exists.");
                    return;
                }
                T = 0;
                T = controllerObj.CheckIfEmailExist(Email);
                if (T != 0)
                {
                    MessageBox.Show("Please choose another Email.It already exists.");
                    return;
                }
                if (PhoneNumber != "")
                {
                    T = 0;
                    T = controllerObj.CheckIfPhoneNumberExist(PhoneNumber);
                    if ((T != 0))
                    {
                        MessageBox.Show("Please choose another Phone Number.It already exists.");
                        return;
                    }
                }
            }
            catch
            { }

            // if (!Validation.IsCardNumberValid(CreditCardNumberTextBox.Text))
            //{
            // MessageBox.Show("Please enter a valid Credit Card Number");
            //  return;
            // }
            int i = -1;
            try
            {
                i = controllerObj.SignUpCustomer(Fname, Lname, UserName, Password, PhoneNumber, Email, CreditCardNumber);
            }
            catch
            {
                MessageBox.Show("Couldn't sign up! Please try again later.");
                return;
            }
            if (i == 0 || i == -1)
            {
                MessageBox.Show("Couldn't sign up! Please try again later.");
                return;
            }
            MessageBox.Show("You have signed up successfully.");
            //Write the code for opening the customer's account form here
            AccountDetailsForm F = new AccountDetailsForm(UserName,this);
            F.Show();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// /////////////////////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////////////////////
        private void TXTB_ONLY_CHAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXTB_ONLY_NUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXTB_CHAR_AND_NUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow digit + char + white space
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LogInLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
