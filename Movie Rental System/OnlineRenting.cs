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
    public partial class OnlineRenting : Form
    {
        Controller controllerObj;
        Form ParentForm;
        Validation V;
        public OnlineRenting(Form PF)
        {
            InitializeComponent();
            ParentForm = PF;
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewOnlineRentingDetails();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
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
