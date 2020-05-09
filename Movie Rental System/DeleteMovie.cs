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
    public partial class DeleteMovie : Form
    {
        Controller controllerObj;
        int AdminID;
        Form ParentForm;
        Validation V;
        public DeleteMovie(int ID, Form PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ParentForm = PF;


            DataTable ddd = controllerObj.ViewAllMovies();
            comboBox1.DataSource = ddd;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Movie_ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please Choose Film Title To Delete");
            }
            else
            {
                int r = controllerObj.DeleteMovies(Convert.ToInt32(comboBox1.SelectedValue));
                if (r > 0)
                    MessageBox.Show("movie deleted successfully");
                else
                    MessageBox.Show("deletion Failed");
            }
        }

        private void DeleteMovie_Load(object sender, EventArgs e)
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
