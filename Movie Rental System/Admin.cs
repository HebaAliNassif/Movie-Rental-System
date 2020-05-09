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
    public partial class Admin : Form
    {
        Controller controllerObj;
        int AdminID;
        Form ParentForm;
        Validation V;
        string username;
        public Admin(string UserName, int ID, Form PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ParentForm = PF;
            username = UserName;
        }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            /// ////////////////////////////////////////////FOR CUSTOMERS//////////////////////////

            private void button12_Click(object sender, EventArgs e) //viewcustomer
            {
                DataTable dt = controllerObj.ViewAllCustomers();
                dataGridView4.DataSource = dt;
                dataGridView4.Refresh();
            }
            private void button14_Click(object sender, EventArgs e) //susbended details
            {
                SuspensionList p = new SuspensionList(AdminID, this); // go to anther form
                p.Show();
                this.Hide();
            }
            /////////////////////////////////////////////
            //////////////////////////////////////AVAILABLE MOVIES/////////////////////////////////
            private void button6_Click(object sender, EventArgs e)//viewallcustomerinfo
            {
                DataTable dt = controllerObj.ViewAllMovies();
                dataGridView3.DataSource = dt;
                dataGridView3.Refresh();
            }

            private void button5_Click(object sender, EventArgs e)//add movie
            {
            Insert_Movie S = new Insert_Movie(this);
            S.Show();
            this.Hide();
        }

            private void button7_Click(object sender, EventArgs e)
            {
                DeleteMovie pp = new DeleteMovie(AdminID, this); // go to anther form
                pp.Show();
                this.Hide();
            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }


            /// //////// MOVIES IN STOCK
            private void button15_Click(object sender, EventArgs e)//viewmovieinstock
            {
                DataTable dt = controllerObj.ViewStockMovies();
                dataGridView7.DataSource = dt;
                dataGridView7.Refresh();
            }

            private void button17_Click(object sender, EventArgs e)//add movieinstock
            {
                AddMovieInStock p = new AddMovieInStock(AdminID, this); // go to anther form
                p.Show();
                this.Hide();
            }


            private void button16_Click(object sender, EventArgs e)//deletemovieinstock
            {

                DeleteFromStock D = new DeleteFromStock(AdminID, this);
                D.Show();
                this.Hide();
            }

            /// //////////////////////////////stafff details
            private void button8_Click(object sender, EventArgs e)//viewstaff member
            {
                DataTable dt = controllerObj.ViewAllStaffMember();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }

            private void button10_Click(object sender, EventArgs e) //add staff member
            {
                AddStaff Da = new AddStaff(this);
                Da.Show();
                this.Hide();
            }

            private void button9_Click(object sender, EventArgs e)
            {
                DeleteStaffMember S = new DeleteStaffMember(this);
                S.Show();
                this.Hide();
            }

            ///.// ////////onnline and store renting

            private void button1_Click(object sender, EventArgs e)//online renting
            {
                OnlineRenting S = new OnlineRenting(this);
                S.Show();
                this.Hide();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                StoreRenting S = new StoreRenting(AdminID, this);
                S.Show();
                this.Hide();
            }

            /// ///////Reviews and rating
            private void button4_Click(object sender, EventArgs e)
            {
                ReviewAndRating RR = new ReviewAndRating(this); // go to anther form
                RR.Show();
                this.Hide();
            }

            /// complains
            private void button3_Click(object sender, EventArgs e)
            {

            }

            private void button3_Click_1(object sender, EventArgs e)
            {
                Complains RR7 = new Complains(this); // go to anther form
                RR7.Show();
                this.Hide();
            }

            /// ///////request     
            private void button13_Click(object sender, EventArgs e)
            {

            }
            private void button13_Click_1(object sender, EventArgs e)
            {
                Request RR5 = new Request(this); // go to anther form
                RR5.Show();
                this.Hide();
            }

            /// /////////////////BRANCHHh
            private void button19_Click(object sender, EventArgs e)
            {
                AddBranch RR5 = new AddBranch(this); // go to anther form
                RR5.Show();
                this.Hide();

            }

            private void button18_Click(object sender, EventArgs e)//VIEW BRANCHDETAILS
            {
                DataTable dt = controllerObj.ViewBranchDetails();
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();

            }
            // //////////////////branch numbers
            private void button11_Click(object sender, EventArgs e)
            {
                DataTable dt = controllerObj.ViewBranchNumber();
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
            }

            private void Admin_Load(object sender, EventArgs e)
            {

            }

            private void GetCustomerWithUserName_Click(object sender, EventArgs e)
            {
                GetCustomerWithuserName C = new GetCustomerWithuserName(this);
                C.Show();
                this.Hide();
            }

            private void Backspace_Click(object sender, EventArgs e)
            {
                ParentForm.Show();
                this.Hide();
            }

            private void LogOutButton_Click(object sender, EventArgs e)
            {

            }

        private void ADDActorButton_Click(object sender, EventArgs e)
        {
            AddActorForm C = new AddActorForm(this);
            C.Show();
            this.Hide();
        }

        private void LogOutButton_Click_1(object sender, EventArgs e)
        {
            StartPage S = new StartPage();
            S.Show();
            this.Hide();
        }
        ////////////////////////
    }
    }

