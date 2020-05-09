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
    public partial class ViewActorPage : Form
    {
        int Actor_ID;
        Controller controllerObj;
        Form ParentForm;
        public ViewActorPage(Form PF, int ID)
        {
            Actor_ID = ID;
            InitializeComponent();
            ParentForm = PF;

        }

        private void ViewActorPage_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            try
            {

                DataTable dt = controllerObj.DisplayActorDetails(Actor_ID);
                FNamelabel.Text = dt.Rows[0]["FName"].ToString();
                BDatelabel.Text = dt.Rows[0]["Birthdate"].ToString();
                LNamelabel.Text = dt.Rows[0]["LName"].ToString();


                if (dt.Rows[0]["Photo"].ToString() != "")
                {



                    byte[] images = ((byte[])dt.Rows[0]["Photo"]);

                    PhotoLabel.Visible = false;

                    MemoryStream mstream = new MemoryStream(images);
                    pictureBox1.Image = Image.FromStream(mstream);

                }


                DataTable dt1 = controllerObj.StarsIn(Actor_ID);
                dataGridView1.DataSource = dt1;
                dataGridView1.Refresh();



            }
            catch (Exception message)
            {
                MessageBox.Show("Couldn't Find Actor!" + message);
                return;

            }

            
            }

     

        private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void FNamelabel_Click(object sender, EventArgs e)
            {

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void Backspace_Click(object sender, EventArgs e)
        {

        }

        private void Backspace_Click_1(object sender, EventArgs e)
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

