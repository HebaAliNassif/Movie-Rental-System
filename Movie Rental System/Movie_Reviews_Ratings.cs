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
    public partial class Movie_Reviews_Ratings : Form
    {
        Controller controllerObj;
        int Movie_ID;
        Form ParentForm;

        public Movie_Reviews_Ratings(int ID, Form PF)
        {
            Movie_ID = ID;
            ParentForm = PF;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Movie_Reviews_Ratings_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            controllerObj = new Controller();


            try
            {
                DataTable dt = controllerObj.GetReview(Movie_ID);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

                if (dt != null)
                {
                    Reviewlabel.Visible = false; ;

                    dataGridView1.Show();



                }
                else
                {
                    Reviewlabel.Visible = true;

                }
            }
            catch (Exception message)
            {
                MessageBox.Show("Couldn't Get Reviews!" + message);
                return;
            }
        }

        private void Reviewlabel_Click(object sender, EventArgs e)
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


