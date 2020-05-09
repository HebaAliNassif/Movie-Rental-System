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
    public partial class StoreRenting : Form
    {
        Form ParentForm;
        int StaffID;
        Validation V;
        Controller controllerObj;
        public StoreRenting(int St_ID, Form PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            PF = ParentForm;
            StaffID = St_ID;
            //
            DataTable ff = controllerObj.ViewAllMovies();
            comboBox1.DataSource = ff;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Movie_ID";

            //
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //  if (String.IsNullOrEmpty(UserNameText.Text))//CUTOMER CAN BE  NULL
            // {
            //    MessageBox.Show("Please enter Customer User Name");
            //   return;
            // }
            if (String.IsNullOrEmpty(DurationTextBox.Text))
            {
                MessageBox.Show("Please enter a Duration");
                return;
            }
            if (String.IsNullOrEmpty(PriceTextBox.Text))
            {
                MessageBox.Show("Please enter Price");
                return;
            }

            DataTable T = controllerObj.GetCustomerWithUserName(UserNameText.Text);
            if (T.Rows.Count != 0)
            {
                int Customer_ID = Convert.ToInt32(T.Rows[0]["Customer_ID"]);
                int Movie_ID = Convert.ToInt32(comboBox1.SelectedValue);
                controllerObj.AddNewStoreRent(Customer_ID, Movie_ID, StaffID, dateTimePicker2.Value.ToString("yy-MM-dd"), Convert.ToInt32(DurationTextBox.Text), Convert.ToInt32(PriceTextBox.Text));
                MessageBox.Show("New Rent is Done");
            }

            else
            {
                MessageBox.Show("Rent Processes if failed");
            }

        }

        private void StoreRenting_Load(object sender, EventArgs e)
        {

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
