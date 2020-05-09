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
    public partial class ReviewAndRating : Form
    {
        Controller controllerObj;
        Form ParentForm;
        Validation V;
        public ReviewAndRating(Form PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ParentForm = PF;

        }

        private void ReviewAndRating_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//viewAllRating
        {
            DataTable dt = controllerObj.ViewAllRatingReviews();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Choose Review_Rating ID To Delete ");
                return;
            }
            try
            {
                Convert.ToInt32(textBox1.Text);

            }
            catch (Exception ee)
            {
                MessageBox.Show("enter valid Review_Rating ID");
            }

            int r = controllerObj.RemoveRatingRieview(Convert.ToInt32(textBox1.Text));
            if (r > 0)
                MessageBox.Show("Rating deleted successfully");
            else
                MessageBox.Show("Deletion Failed");



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
