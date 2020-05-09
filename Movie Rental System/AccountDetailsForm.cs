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
    public partial class AccountDetailsForm : Form
    {
        Controller controllerObj;
        string username;
        Form ParentForm;
        public AccountDetailsForm(string un, Form PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ParentForm = PF;
            username = un;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            FNametextBox.ReadOnly = false;
            LNametextBox.ReadOnly = false;
            EmailtextBox.ReadOnly = false;
            PasswordtextBox.ReadOnly = true;
            PNumbertextBox.ReadOnly = false;
            CCNtextBox.ReadOnly = false;
            
        }

        private void AccountDetailsForm_Load(object sender, EventArgs e)
        {
            DataTable D = controllerObj.GetCustomerWithUserName(username);

            LNametextBox.Text = D.Rows[0]["LName"].ToString();
            FNametextBox.Text = D.Rows[0]["FName"].ToString();
            PasswordtextBox.Text = D.Rows[0]["Password"].ToString();
            EmailtextBox.Text = D.Rows[0]["Email"].ToString();
            PNumbertextBox.Text = D.Rows[0]["PhoneNumber"].ToString();
            CCNtextBox.Text = D.Rows[0]["CCN"].ToString();
            UserNameTextBox.Text = D.Rows[0]["Username"].ToString();
            IDTextBox.Text = D.Rows[0]["Customer_ID"].ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (PasswordtextBox.ReadOnly)
            {
                try
                {
                    String Email = EmailtextBox.Text;
                    String CreditCardNumber = CCNtextBox.Text;
                    String Password = PasswordtextBox.Text;
                    String PhoneNumber = PNumbertextBox.Text;
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
                    i = controllerObj.UpdateCustomer(
                    FNametextBox.Text.ToString(),
                    LNametextBox.Text.ToString(),
                    EmailtextBox.Text.ToString(),
                    PNumbertextBox.Text.ToString(),
                    CCNtextBox.Text.ToString(),
                    Convert.ToInt32(IDTextBox.Text));
                    if (i > 0)
                    {
                        MessageBox.Show("Saved Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }

                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                if (!Validation.IsPasswordValid(PasswordtextBox.Text))
                {
                    MessageBox.Show("Please enter a valid Password \n" + "It should contain at least one number,one uppercase letter and 8 letters");
                    return;
                }
                else
                {
                     i = 0;
                    i = controllerObj.UpdateCustomerPassword(PasswordtextBox.Text, username);
                    if (i > 0)
                    {
                        MessageBox.Show("Password Updated!");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FNametextBox.ReadOnly = true;
            LNametextBox.ReadOnly = true;
            EmailtextBox.ReadOnly = true;
            PasswordtextBox.ReadOnly = false;
            PNumbertextBox.ReadOnly = true;
            CCNtextBox.ReadOnly = true;
            
         

            }

        private void Backspace_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Hide();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            StartPage S = new StartPage();
            S.Show();
            this.Hide();
        }
    }
    }
