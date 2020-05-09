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
    public partial class Staff : Form
    {
        Controller controllerObj;
        int StaffID;
        Form ParentForm;
        Validation V;
        public Staff(string username,int ID, Form PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ParentForm = PF;
            StaffID = ID;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewAllCustomers();
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();
        }

        private void GetCustomerWithUserName_Click(object sender, EventArgs e)
        {
            GetCustomerWithuserName C = new GetCustomerWithuserName(this);
            C.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewAllStaffMember();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)//viewallmovies
        {
            DataTable dt = controllerObj.ViewAllMovies();
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)//addmovie
        {
            Insert_Movie S = new Insert_Movie(this);
            S.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)//delete
        {
            DeleteMovie pp = new DeleteMovie(StaffID, this); // go to anther form
            pp.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)//viewbranchnumber
        {
            DataTable dt = controllerObj.ViewBranchNumber();
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void button18_Click(object sender, EventArgs e)//branchdetails
        {
            DataTable dt = controllerObj.ViewBranchDetails();
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)//complains
        {
            Complains RR7 = new Complains(this); // go to anther form
            RR7.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Request RR5 = new Request(this); // go to anther form
            RR5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReviewAndRating RR = new ReviewAndRating(this); // go to anther form
            RR.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e) 
        {
            SuspensionList p = new SuspensionList(StaffID, this); // go to anther form
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnlineRenting S = new OnlineRenting(this);
            S.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StoreRenting S = new StoreRenting(StaffID, this);
            S.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewStockMovies();
            dataGridView7.DataSource = dt;
            dataGridView7.Refresh();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddMovieInStock p = new AddMovieInStock(StaffID, this); // go to anther form
            p.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DeleteFromStock D = new DeleteFromStock(StaffID, this);
            D.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Hide();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            StartPage S = new StartPage();
            S.Show();
            this.Hide();
        }
    }
}
