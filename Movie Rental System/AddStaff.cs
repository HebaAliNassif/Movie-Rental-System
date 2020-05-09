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
    public partial class AddStaff : Form
    {
        Controller controllerObj;
        Form ParentForm;
        Validation V;
        public AddStaff(Form PF)
        {
            InitializeComponent();
            ParentForm = PF;
            controllerObj = new Controller();



        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRentalSystemsDataSet.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.movieRentalSystemsDataSet.Branch);

        }

        private void button1_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(UserNameTextBox.Text))
            {
                MessageBox.Show("Please enter a User Name");
                return;
            }
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                MessageBox.Show("Please enter an Email");
                return;
            }
            if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter an Password");
                return;
            }

            String Fname = FnameTextBox.Text;
            String Lname = LnameTextBox.Text;
            String UserName = UserNameTextBox.Text;
            String Password = PasswordTextBox.Text;

            String PhoneNumber;
            PhoneNumber = PhoneNumberTextBox.Text;

            String Email = EmailTextBox.Text;
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

            // if (!Validation.IsCardNumberValid(CreditCardNumberTextBox.Text))
            //{
            // MessageBox.Show("Please enter a valid Credit Card Number");
            //  return;
            // }
            int i = -1;
            try
            {
                i = controllerObj.InsertStaff(Fname, Lname, UserName, Password, PhoneNumber, Email, Convert.ToInt32(BranchNumcomboBox2.SelectedValue));
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
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            StartPage S = new StartPage();
            S.Show();
            this.Hide();
        }
    }
}
