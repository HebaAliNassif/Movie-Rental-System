using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//in store rental only?
namespace Movie_Rental_System
{
    public partial class SuspensionList : Form
    {
        Form ParentForm;
        int StaffID;
        Validation V;
        Controller controllerObj;
        public SuspensionList(int St_ID, Form PF)
        {

            InitializeComponent();
            controllerObj = new Controller();
            PF = ParentForm;
            StaffID = St_ID;

        }

        private void SuspensionList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //view
        {
            DataTable dt = controllerObj.ViewSuspemsionDetails();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CommentTextBox.Text))
            {
                MessageBox.Show("Please enter a Comment");
                return;
            }
            if (String.IsNullOrEmpty(UserNameText.Text))
            {
                MessageBox.Show("Please enter Customer User Name");
                return;
            }
            if (String.IsNullOrEmpty(DurationTextBox.Text))
            {
                MessageBox.Show("Please enter a Duration");
                return;
            }

            DataTable T = controllerObj.GetCustomerWithUserName(UserNameText.Text);
            if (T.Rows.Count != 0)
            {
                int Customer_ID = Convert.ToInt32(T.Rows[0]["Customer_ID"]);
                controllerObj.AddinSuspenionList(Customer_ID, StaffID, dateTimePicker1.Value.ToString("yy-MM-dd"), Convert.ToInt32(DurationTextBox.Text), CommentTextBox.Text);
                MessageBox.Show("Customer is inserted");
            }

            else
            {
                MessageBox.Show("Customer does not exist");
            }

        }




        private void button3_Click(object sender, EventArgs e) //remove
        {

            if (String.IsNullOrEmpty(CustomerNameReText.Text))
            {
                MessageBox.Show("Please enter Customer User Name");
                return;
            }
            DataTable T = controllerObj.GetCustomerWithUserName(CustomerNameReText.Text);
            if (T.Rows.Count != 0)
            {
                int Customer_ID = Convert.ToInt32(T.Rows[0]["Customer_ID"]);
                controllerObj.RemoveFromSusp(Customer_ID);
                MessageBox.Show("Customer is removed ");
            }

            else
            {
                MessageBox.Show("Customer does not exist");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StartPage S = new StartPage();
            S.Show();
            this.Hide();
        }
    }
}

   
