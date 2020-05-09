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
    public partial class Insert_Movie : Form
    {
        string imgLocation;
        Controller controllerObj;
        Form ParentForm;

        public Insert_Movie(Form PF)
        {
            InitializeComponent();
            ParentForm = PF;
            controllerObj = new Controller();
        }

        private void Insert_Movie_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()
            { Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                   imgLocation = dialog.FileName.ToString();
                    MoviepictureBox.ImageLocation = imgLocation;
                }
            }
                
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            if (this.imgLocation != null)
            {
                //MemoryStream ms = new MemoryStream();
                //MoviepictureBox.Image.Save(ms, Image)
                FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images = brs.ReadBytes((int)Stream.Length);
            }
            int s = 0;

            try
            {

                s = controllerObj.AddMovie(TitletextBox.Text, PlottextBox.Text, images, GenrecomboBox.Text, ReleasedateTimePicker.Value.ToString("yyyy-MM-dd"), TrailertextBox.Text, Convert.ToInt32(DurationtextBox.Text), Convert.ToInt32(PricetextBox.Text));

                if (s <= 0)
                {
                    MessageBox.Show("Couldn't add Movie.");
                    return;
                }
                MessageBox.Show("Movie Added Successfully!");
            }

            catch (Exception message)
            {
                MessageBox.Show("Couldn't add Movie!" +message);
                return;
            }


        }

        private void TitletextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void GenreLabel_Click(object sender, EventArgs e)
        {

        }


        private void GenrecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RatingtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantitytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReleasedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TrailerLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DurationtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlottextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DurationtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PricetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PricetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
