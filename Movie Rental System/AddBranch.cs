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
    public partial class AddBranch : Form
    {
        Form ParentForm;
        Validation V;
        Controller controllerObj;
        public AddBranch(Form PF)
        {
            InitializeComponent();
            ParentForm = PF;
            controllerObj = new Controller();
        }

        private void AddBranch_Load(object sender, EventArgs e)
        {

        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Hide();
        }

        private void BranchAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BranchAddressTextBox.Text == "" || BranchPhoneNumberTextBox.Text == "" || BranchEmailTextBox.Text == "")
            {
                MessageBox.Show("Please enter All Values To Insert New Branch");
                return;
            }
            string Address = Convert.ToString(BranchAddressTextBox.Text);
            string phonenumber = Convert.ToString(BranchPhoneNumberTextBox.Text);
            string Email = Convert.ToString(BranchEmailTextBox.Text);


            if (!Validation.IsValidEmail(Email))
            {
                MessageBox.Show("Enter valid email address");
                return;
            }
            if (!Validation.IsPhoneNumberVlidate(phonenumber))
            {
                MessageBox.Show("Enter valid phone number");
                return;
            }
            int T = 0;
            T = controllerObj.CheckIfEmailExist(Email);
            if (T != 0)
            {
                MessageBox.Show("Please choose another Email.It already exists.");
                return;
            }
            if (phonenumber != "")
            {
                T = 0;
                T = controllerObj.CheckIfPhoneNumberExist(phonenumber);
                if ((T != 0))
                {
                    MessageBox.Show("Please choose another Phone Number.It already exists.");
                    return;
                }
            }

            int r = controllerObj.AddNewBranch(Address, Email, phonenumber);
            if (r > 0)
            {
                MessageBox.Show("New Branch is Inserted");
            }
            else
                MessageBox.Show("insertation failed");
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
    }
}
