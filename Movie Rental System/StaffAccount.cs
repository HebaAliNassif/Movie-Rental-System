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
    public partial class StaffAccount : Form
    {
        Form ParentForm;
        int StaffID;
        string UserName;
        Validation V;
        Controller controllerObj;
        public StaffAccount(Form PF,string username, int St_ID)
        {
            InitializeComponent();
            ParentForm = PF;
            StaffID = St_ID;
            UserName = username;
            controllerObj = new Controller();
        }

        private void StaffAccount_Load(object sender, EventArgs e)
        {
            DataTable Staffinfo=controllerObj.GetStaffWithName(UserName);
            IDTextBox.Text = Staffinfo.Rows[0]["Staff_ID"].ToString();
            FNametextBox.Text = Staffinfo.Rows[0]["FName"].ToString();
            LNametextBox.Text = Staffinfo.Rows[0]["LName"].ToString();
            EmailtextBox.Text= Staffinfo.Rows[0]["Email"].ToString();
            PNumbertextBox.Text = Staffinfo.Rows[0]["PhoneNumber"].ToString();
            BranchNumberTextBox.Text= Staffinfo.Rows[0]["BNumber"].ToString();
            UserNameTextBox.Text= Staffinfo.Rows[0]["Username"].ToString();

        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Hide();
        }

        private void ProvidedFunctionalitiesButton_Click(object sender, EventArgs e)
        {
            Staff F = new Staff(UserName,StaffID, this);
            F.Show();
            this.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            FNametextBox.ReadOnly = false;
            LNametextBox.ReadOnly = false;
            EmailtextBox.ReadOnly = false;
            PasswordtextBox.ReadOnly = true;
            PNumbertextBox.ReadOnly = false;
        }

        private void EditPassButton_Click(object sender, EventArgs e)
        {
            FNametextBox.ReadOnly = true;
            LNametextBox.ReadOnly = true;
            EmailtextBox.ReadOnly = true;
            PasswordtextBox.ReadOnly = false;
            PNumbertextBox.ReadOnly = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (PasswordtextBox.ReadOnly)
            {
                try
                {
                    String Email = EmailtextBox.Text;
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
                    i = controllerObj.UpdateStaff(
                    FNametextBox.Text.ToString(),
                    LNametextBox.Text.ToString(),
                    EmailtextBox.Text.ToString(),
                    PNumbertextBox.Text.ToString(),
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
                    i = controllerObj.UpdateStaffPassword(PasswordtextBox.Text, UserName);
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

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            StartPage S = new StartPage();
            S.Show();
            this.Hide();
        }
    }
}
