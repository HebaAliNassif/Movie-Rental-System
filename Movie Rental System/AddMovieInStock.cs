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
    public partial class AddMovieInStock : Form
    {
        Form ParentForm;
        int StaffID;
        Validation V;
        Controller controllerObj;
        public AddMovieInStock(int St_ID, Form PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            PF = ParentForm;
            StaffID = St_ID;


            DataTable dt = controllerObj.ViewAllMovies();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Title";
            comboBox2.ValueMember = "Movie_ID";


            DataTable dt3 = controllerObj.ViewBranchNumber();
            comboBox1.DataSource = dt3;
            comboBox1.DisplayMember = "Branch_ID";
            comboBox1.ValueMember = "Branch_ID";
        }

        private void AddMovieInStock_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("please choose all values to add movie");
                return;
            }
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                if (a <= 0 || a > 200)
                {
                    MessageBox.Show("Enter Suitable Number of Quantity");
                    return;
                }

            }
            catch (Exception e2)
            {
                MessageBox.Show("Enter Valid Number Of Quantity");
                return;
            }
            int r = controllerObj.AddMoviesinStock(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(textBox1.Text));
            if (r > 0)
                MessageBox.Show("Movie inserted in stock successfully");
            else
                MessageBox.Show("Insertion Failed");
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
