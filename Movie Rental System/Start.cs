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
    public partial class StartPage : Form
    {
        Controller controllerObj;
        int CID;
        public StartPage()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controllerObj.GetMostWatched();
                if (dt != null)
                {
                    int count = 0;
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        int movie_ID = Convert.ToInt32(dataRow["Movie_ID"]);
                        object r = controllerObj.DisplayMovieImage(movie_ID);

                        byte[] images1 = ((byte[])r);
                        count++;
                        if (count == 1)
                        {


                            MemoryStream mstream = new MemoryStream(images1);
                            MostWatchedpictureBox1.Image = Image.FromStream(mstream);


                        }
                        if (count == 2)
                        {

                            MemoryStream mstream = new MemoryStream(images1);
                            MostWatchedpictureBox2.Image = Image.FromStream(mstream);


                        }
                        if (count == 3)
                        {


                            MemoryStream mstream = new MemoryStream(images1);
                            MostWatchedpictureBox3.Image = Image.FromStream(mstream);


                        }
                        if (count == 4)
                        {

                            MemoryStream mstream = new MemoryStream(images1);
                            MostWatchedpictureBox4.Image = Image.FromStream(mstream);

                        }
                    }
                }
            }

            catch (Exception message)
            {
                MessageBox.Show("Can't Load Page!" + message);
                return;
            }

            try
            {
                DataTable dt = controllerObj.GetNewArrival();
                if (dt != null)
                {
                    int count = 0;
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        int movie_ID = Convert.ToInt32(dataRow["Movie_ID"]);
                        object r = controllerObj.DisplayMovieImage(movie_ID);

                        byte[] images1 = ((byte[])r);
                        count++;
                        if (count == 1)
                        {


                            MemoryStream mstream = new MemoryStream(images1);
                            NewArrivalpictureBox1.Image = Image.FromStream(mstream);


                        }
                        if (count == 2)
                        {

                            MemoryStream mstream = new MemoryStream(images1);
                            NewArrivalpictureBox2.Image = Image.FromStream(mstream);


                        }

                        if (count == 3)
                        {


                            MemoryStream mstream = new MemoryStream(images1);
                            NewArrivalpictureBox3.Image = Image.FromStream(mstream);


                        }
                        if (count == 4)
                        {

                            MemoryStream mstream = new MemoryStream(images1);
                            NewArrivalpictureBox4.Image = Image.FromStream(mstream);

                        }
                    }
                }
            }

            catch (Exception message)
            {
                MessageBox.Show("Can't Load Page!" + message);
                return;
            }




        }
        private void button2_Click(object sender, EventArgs e)
        {
            SignUp S = new SignUp(this);
            S.Show();
            this.Hide();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            LogIn G = new LogIn(this);
            G.Show(this);
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewArrivallabel_Click(object sender, EventArgs e)
        {

        }

        private void NewArrivalpictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MostWatchedpictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            string Searchby = SearchbycomboBox.Text;

            if (Searchby == "Actor")
            {
                string FName;
                string LName;
                if (EntrytextBox.Text.Contains(' '))
                {
                    string[] Name = EntrytextBox.Text.Split(' ');
                    FName = Name[0];
                    LName = Name[1];

                    try
                    {
                        object s = controllerObj.FindActor(FName, LName);

                        if (s != null)
                        {
                            ViewActorPage m = new ViewActorPage(this, Convert.ToInt32(s));
                            m.Show();
                        }
                        else
                        {
                            MessageBox.Show("Actor Not Found!");
                        }
                    }

                    catch (Exception message)
                    {
                        MessageBox.Show("Actor Not Found!" + message);
                        return;

                    }
                }
                else
                {
                    MessageBox.Show("Actor Not Found!");
                    return;

                }
            }

            else
            {
                try
                {
                    object s = controllerObj.FindMovie(EntrytextBox.Text);

                    if (s != null)
                    {
                        ViewMoviePage m = new ViewMoviePage(this, Convert.ToInt32(s), Convert.ToInt32(CID));
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Movie Not Found!");
                    }
                }

                catch (Exception message)
                {
                    MessageBox.Show("Movie Not Found!" + message);
                    return;

                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Insert_Movie S = new Insert_Movie(this);
            S.Show();
            this.Hide();
        }

        private void NewArrivalpictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void MostWatchedpictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

