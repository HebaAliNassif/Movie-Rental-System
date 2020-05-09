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
    public partial class Complains : Form
    {
        Controller controllerObj;
        Form ParentForm;
        Validation V;
        public Complains(Form PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ParentForm = PF;
        }

        private void Complains_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//view
        {
            DataTable dt = controllerObj.ViewComplains();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)//remove complain of customer
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Choose complain ID To Delete complain");
                return;
            }
            try
            {
                Convert.ToInt32(textBox1.Text);

            }
            catch (Exception ee)
            {
                MessageBox.Show("enter valid complain ID");
            }

            int r = controllerObj.RemoveComplains(Convert.ToInt32(textBox1.Text));
            if (r > 0)
                MessageBox.Show("complain deleted successfully");
            else
                MessageBox.Show("Deletion Failed");

        }

        private void button3_Click(object sender, EventArgs e)//viewwithcustomerdetails
        {
            DataTable dt = controllerObj.ViewComplainsWithCustomerDetails();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
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
