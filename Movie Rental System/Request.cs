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
    public partial class Request : Form
    {
        Form ParentForm;
        Validation V;
        Controller controllerObj;
        public Request(Form PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ParentForm = PF;


        }

        private void Request_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//show all requests
        {
            DataTable dt = controllerObj.ViewRequests();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)//delete
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Choose request ID to delet request");
                return;
            }
           try
            {
                Convert.ToInt32(textBox1.Text);

            }
            catch(Exception ee)
            {
                MessageBox.Show("enter valid request ID");
            }
            
                int r = controllerObj.RemoveRequests(Convert.ToInt32(textBox1.Text));
                if (r > 0)
                    MessageBox.Show("Request deleted successfully");
                else
                    MessageBox.Show("Deletion Failed");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewAllRequestWithCustomerName();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            //
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
