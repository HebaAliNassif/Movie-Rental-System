using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Movie_Rental_System
{
    public partial class ViewMoviePage : Form
    {
        int Movie_ID;
        int Customer_ID;
        Controller controllerObj;
        Form ParentForm;
        public ViewMoviePage(Form PF, int MovieID, int CustomerID)
        {
            Movie_ID = MovieID;
            Customer_ID = CustomerID;

            InitializeComponent();
            ParentForm = PF;
            AvailabilityLabel.Visible = false;
            AvailabilitydataGridView.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ViewMoviePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MovieRentalSystemsDataSet.Movie' table. You can move, or remove it, as needed.
            controllerObj = new Controller();
            try
            {

                DataTable dt = controllerObj.DisplayMovieDetails(Movie_ID);
                TitleLabel1.Text = dt.Rows[0]["Title"].ToString();
                ReleaseDatelabel1.Text = dt.Rows[0]["Release_Date"].ToString();
                Genrelabel1.Text = dt.Rows[0]["Genre"].ToString();
                Durationlabel1.Text = dt.Rows[0]["Duration"].ToString();
                Plotlabel1.Text = dt.Rows[0]["Plot"].ToString();
                linkLabel1.Text = dt.Rows[0]["Trailer"].ToString();

                if (dt.Rows[0]["Poster"].ToString() != "")
                {

                    byte[] images = ((byte[])dt.Rows[0]["Poster"]);

                
                    PosterLabel.Visible = false;

                    MemoryStream mstream = new MemoryStream(images);
                    pictureBox1.Image = Image.FromStream(mstream);

                }


                    object r = controllerObj.CalculateRating(Movie_ID);
                   Ratinglabel1.Text = Convert.ToString(r);

            }

            catch (Exception message)
            {
                MessageBox.Show("Couldn't Find Movie!" + message);
                return;

            }

        }

        private void Plotlabel1_Click(object sender, EventArgs e)
        {

        }

        private void AvailabilityLabel_Click(object sender, EventArgs e)
        {

        }

        private void Availablitybutton_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = controllerObj.GetStock(Movie_ID);
                AvailabilitydataGridView.DataSource = dt;
                AvailabilitydataGridView.Refresh();

                if (dt == null)
                {
                    Availablitybutton.Visible = false;
                    AvailabilityLabel.Visible = true;
                }
                else
                {
                    AvailabilitydataGridView.Show();
                }
            }

            catch (Exception message)
            {
                MessageBox.Show("Couldn't Access Database!" + message);
                return;

            }
        }

        private void Genrelabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PosterLabel_Click(object sender, EventArgs e)
        {

        }

        private void AvailabilitydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WishlistButton_Click(object sender, EventArgs e)
        {

        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            Movie_Reviews_Ratings S = new Movie_Reviews_Ratings(Movie_ID, this);
            S.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Ratinglabel1_Click(object sender, EventArgs e)
        {

        }

        private void Reviewbutton1_Click(object sender, EventArgs e)
        {
            AddReviewForm S = new AddReviewForm(this,Movie_ID,Customer_ID);
            S.Show();
            this.Hide();
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
