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
    public partial class GetCustomerWithuserName : Form
    {
        Form ParentForm;
        Validation V;
        Controller controllerObj;
        public GetCustomerWithuserName(Form PF)
        {
            InitializeComponent();
            ParentForm = PF;
            controllerObj = new Controller();
        }

        private void GetCustomerButton_Click(object sender, EventArgs e)
        {
            string username;
            if(String.IsNullOrEmpty(UserNameTextBox.Text))
            {
                MessageBox.Show("Please enter a User Name");
                return;
            }
            username = UserNameTextBox.Text;
            DataTable D=controllerObj.GetCustomerWithUserName(username);
            if (D.Rows.Count != 0)
            {
                IDLabelOut.Text = D.Rows[0]["Customer_ID"].ToString();
                NameLabelOut.Text = D.Rows[0]["FName"].ToString() + "  " + D.Rows[0]["LName"].ToString();
                EmailLabelOut.Text = D.Rows[0]["Email"].ToString();
                PhoneNumberLabelOut.Text = D.Rows[0]["PhoneNumber"].ToString();
                UserNameLabelOut.Text = D.Rows[0]["Username"].ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid User Name");
                return;
            }
            

        }

        private void GetCustomerWithuserName_Load(object sender, EventArgs e)
        {

        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Hide();
        }
    }
}
