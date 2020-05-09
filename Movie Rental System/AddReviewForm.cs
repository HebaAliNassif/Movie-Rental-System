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
    public partial class AddReviewForm : Form
    {
        int CID;
        int MID;
        Controller controllerObj;
        Form ParentForm;

        public AddReviewForm(Form PF,int mid, int cid)
        {
            InitializeComponent();
            controllerObj = new Controller();
            CID = cid;
            MID = mid;
            ParentForm = PF;

        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (ReviewtextBox.Text == "")
            {
                MessageBox.Show("Please Write Your Review!");
            }
            else
            {
                int r = controllerObj.AddReview(ReviewtextBox.Text,CID,MID,Convert.ToInt32(Rating.Value),DateTime.Now.ToLongDateString());
                if (r > 0)
                    MessageBox.Show("Review Added Successfully");
                else
                    MessageBox.Show("Couldn't Add Review!");
            }
        }

        private void ReviewtextBox_TextChanged(object sender, EventArgs e)
        {

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
