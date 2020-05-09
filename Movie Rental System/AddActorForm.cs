using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Movie_Rental_System
{
    public partial class AddActorForm : Form
    {
        string imgLocation;
        Controller controllerObj;
        Form ParentForm;
        public AddActorForm(Form PF)
        {

            InitializeComponent();
            controllerObj = new Controller();
            PF=ParentForm;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {



            try
            {
                if (FNametextBox.Text == "" || LNametextBox.Text == "")
                {
                    MessageBox.Show("Please Insert Actor Name!");
                }
                else
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

                    int s = controllerObj.AddActor(FNametextBox.Text, LNametextBox.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), images);
                    if (s <= 0)
                    {
                        MessageBox.Show("Couldn't Add Actor!");
                        return;
                    }
                    MessageBox.Show("Actor Added Successfully!");
                }


            }
            catch (Exception message)
            {
                MessageBox.Show("Couldn't Add Actor!" + message);
                return;
            }
        }


        private void Browsebutton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()
            { Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName.ToString();
                    pictureBox1.ImageLocation = imgLocation;
                }
            }

        }



        private void AddActorForm_Load(object sender, EventArgs e)
        {

        }

        private void FNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
  
