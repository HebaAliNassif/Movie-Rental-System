using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Movie_Rental_System
{
    class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public int SignUpCustomer(string Fname, string Lname, string UserName, String Password, String PhoneNumber, String Email, String CreditCardNumber)
        {

            string StoredProcedureName = StoredProcedures.SignUpCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Username", UserName);
            Parameters.Add("@Password", Password);
            if (!String.IsNullOrEmpty(PhoneNumber))
            {
                Parameters.Add("@PhoneNumber", PhoneNumber);
            }
            else
            {
                Parameters.Add("@PhoneNumber", DBNull.Value);
            }
            Parameters.Add("@Email", Email);
            Parameters.Add("@CreditCardNumber", CreditCardNumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertStaff(string Fname, string Lname, string UserName, String Password, String PhoneNumber, String Email, int Bnumber)
        {

            string StoredProcedureName = StoredProcedures.InsertStaff;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Username", UserName);
            Parameters.Add("@Password", Password);
            if (!String.IsNullOrEmpty(PhoneNumber))
            {
                Parameters.Add("@PhoneNumber", PhoneNumber);
            }
            else
            {
                Parameters.Add("@PhoneNumber", DBNull.Value);
            }
            Parameters.Add("@Email", Email);
            Parameters.Add("@BNumber", Bnumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertAdmin(string Fname, string Lname, string UserName, String Password, String PhoneNumber, String Email, String CreditCardNumber, int Bnumber)
        {

            string StoredProcedureName = StoredProcedures.InsertAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Username", UserName);
            Parameters.Add("@Password", Password);
            if (!String.IsNullOrEmpty(PhoneNumber))
            {
                Parameters.Add("@PhoneNumber", PhoneNumber);
            }
            else
            {
                Parameters.Add("@PhoneNumber", DBNull.Value);
            }
            Parameters.Add("@Email", Email);
            Parameters.Add("@BNumber", Bnumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        /// //////////////////////////////////////////////////////////

        public int SignInCustomer(string UserName, string Password)
        {
            string StoredProcedureName = StoredProcedures.SignInCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", UserName);
            Parameters.Add("@Password", Password);
            try
            {
                return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            }
            catch
            {
                return 0;
            }
        }
        public int SignInStaff(string UserName, string Password)
        {
            string StoredProcedureName = StoredProcedures.SignInStaff;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", UserName);
            Parameters.Add("@Password", Password);
            try
            {
                return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            }
            catch
            {
                return 0;
            }
        }
        /// //////////////////////////////////////////////////////////

        public DataTable GetCustomerWithUserName(string UserName)
        {
            string StoredProcedureName = StoredProcedures.GetCustomerWithUserName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", UserName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetCustomerWithEmail(string Email)
        {
            string StoredProcedureName = StoredProcedures.GetCustomerWithEmail;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetCustomerIdWithPhoneNuber(string PhoneNumber)
        {
            string StoredProcedureName = StoredProcedures.GetCustomerWithPhoneNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PhoneNumber);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        /// //////////////////////////////////////////////////////////

        public DataTable GetStaffWithEmail(string Email)
        {

            string StoredProcedureName = StoredProcedures.GetStaffWithEmail;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetStaffWithName(string UserName)
        {
            string StoredProcedureName = StoredProcedures.GetStaffWithUserName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", UserName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetStaffWithPhoneNumber(string PhoneNumber)
        {

            string StoredProcedureName = StoredProcedures.GetStaffWithPhoneNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PhoneNumber);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        /// //////////////////////////////////////////////////////////

        public int GetPersonWithUserName(string UserName)
        {

            string StoredProcedureName = StoredProcedures.CheckIfUserNameExist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", UserName);
            try
            {
                return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            }
            catch
            {
                return 0;
            }
        }
        public int CheckIfPhoneNumberExist(string PhoneNumber)
        {

            string StoredProcedureName = StoredProcedures.CheckIfPhoneNumberExist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PhoneNumber);
            try
            {
                return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            }
            catch
            {
                return 0;
            }
        }
        public int CheckIfEmailExist(string Email)
        {

            string StoredProcedureName = StoredProcedures.CheckIfEmailExist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            try
            {
                return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            }
            catch
            {
                return 0;
            }
        }

        /// //////////////////////////////////////////////////////////
        /// 
        public string GetStaffRole(int Staff_ID)
        {
            string StoredProcedureName = StoredProcedures.GetStaffRole;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", Staff_ID);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }




        /// ////////////////////for Movies
        public DataTable ViewAllMovies()
        {
            String StoredProcedureName = StoredProcedures.ViewAllMovies;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int DeleteMovies(int Movie_ID) //msh rady??
        {
            String StoredProcedureName = StoredProcedures.DeleteMovie;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Movie_ID", Movie_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //////////////////////////////////////////Customersss
        public DataTable ViewAllCustomers()
        {
            String StoredProcedureName = StoredProcedures.ViewAllCustomers;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        /////////////////////////////////////////////BranchNumber
        ///
        public DataTable ViewBranchNumber()
        {
            String StoredProcedureName = StoredProcedures.ViewBranchNumb;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable ViewBranchDetails()
        {
            String StoredProcedureName = StoredProcedures.ViewAllBranchDetails;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public int AddNewBranch( string Address, string Email, string PhoneNumber)
        {
            String StoredProcedureName = StoredProcedures.AddBranch;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Address", Address);
            Parameters.Add("@Email", Email);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        /// ///////// getlogin id
        public DataTable GetAllLoginID()
        {
            String StoredProcedureName = StoredProcedures.ViewAllLoginID;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }


        /////////////MoviesInStock
        public DataTable ViewStockMovies()
        {
            String StoredProcedureName = StoredProcedures.ViewAllStockMoviesByEachMovie;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int DeleteMoviesinStock(int BNumber, int Movie_ID) //msh rady??
        {
            String StoredProcedureName = StoredProcedures.DeleteMovieInStock;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BNumber", BNumber);
            Parameters.Add("@Movie_ID", Movie_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddMoviesinStock(int BNumber, int Movie_ID, int Quantity)
        {
            String StoredProcedureName = StoredProcedures.AddMovieInStock;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BNumber", BNumber);
            Parameters.Add("@Movie_ID", Movie_ID);
            Parameters.Add("@Quantity", Quantity);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //////////////////// /////////STAFFFF
        public DataTable ViewAllStaffMember()  //view staff members details
        {
            String StoredProcedureName = StoredProcedures.ViewAllStaff;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //add staff memmber
        public int AddNewStaffMember(int Staff_ID, string FName, string LName, string Email, int PhoneNumber, int BNumber, int Login_ID)
        {
            String StoredProcedureName = StoredProcedures.AddStaffMember;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Staff_ID", Staff_ID);
            Parameters.Add("@FName", FName);
            Parameters.Add("@LName", LName);
            Parameters.Add("@Email", Email);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            Parameters.Add("@BNumber", BNumber);
            Parameters.Add("@Login_ID", Login_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ///DeleteStaffMember
        public int DeleteStaffMember(string username) //msh rady??
        {
            String StoredProcedureName = StoredProcedures.DeleteStaffMember;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ///////////////////////////////////
        ///onnline and store Renting
        public DataTable ViewOnlineRentingDetails()
        {
            String StoredProcedureName = StoredProcedures.ShowAllOnlineRentingDetails;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable ViewStoreRentingDetails()
        {
            String StoredProcedureName = StoredProcedures.ShowStoreRentingDetails;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int AddNewStoreRent( int Customer_ID, int Movie_ID, int Staff_ID, string Str_Date, int Duration, int Price)
        {
            String StoredProcedureName = StoredProcedures.AddNewStoreRent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
           // Parameters.Add("@SRental_ID", SRental_ID);
            Parameters.Add("@Customer_ID", Customer_ID);
            Parameters.Add("@Movie_ID", Movie_ID);
            Parameters.Add("@Staff_ID", Staff_ID);
            Parameters.Add("@Str_Date", Str_Date);
            Parameters.Add("@Duration", Duration);
            Parameters.Add("@Price", Price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        /// //////////////////////////

        ///////////Suspension
        public DataTable ViewSuspemsionDetails()
        {
            String StoredProcedureName = StoredProcedures.ViewAllSuspensionListDetails;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int AddinSuspenionList(int Customer_ID, int Staff_ID, string Str_Date, int Duration, string Comment)
        {
            String StoredProcedureName = StoredProcedures.AddCustomerinSuspensionList;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Customer_ID", Customer_ID);
            Parameters.Add("@Staff_ID", Staff_ID);
            Parameters.Add("@Str_Date", Str_Date);
            Parameters.Add("@Duration,", Duration);
            Parameters.Add("@Comment", Comment);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int RemoveFromSusp(int Customer_ID)
        {
            String StoredProcedureName = StoredProcedures.RemoveCustomerFromSuspensionList;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Customer_ID", Customer_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        /////View rating-Reviews
        public DataTable ViewAllRatingReviews()
        {
            String StoredProcedureName = StoredProcedures.ShowAllDetailsReview_Rating;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable ViewRatingReviewsOfMovie(int Movie_ID)
        {
            String StoredProcedureName = StoredProcedures.ShowAllReview_RatingOfMovie;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Movie_ID", Movie_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int RemoveRatingRieview(int Review_ID) //msh rady??
        {
            String StoredProcedureName = StoredProcedures.RemoveeReview_Rating;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Review_ID", Review_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ///////////////Complains
        ///
        public DataTable ViewComplains()
        {
            String StoredProcedureName = StoredProcedures.ViewAllComplain;

            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int RemoveComplains(int Complain_ID) 
        {
            String StoredProcedureName = StoredProcedures.RemoveeComplain;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Complain_ID", Complain_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable ViewComplainsWithCustomerDetails()
        {
            String StoredProcedureName = StoredProcedures.ViewAllComplainandcustomerDetails;

            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        /////////////Requests
        public DataTable ViewRequests()
        {
            String StoredProcedureName = StoredProcedures.ViewAllRequest;

            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int RemoveRequests(int Request_ID)
        {
            String StoredProcedureName = StoredProcedures.RemoveeRequest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Request_ID", Request_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //ViewAllRequestWithCustomerName
        public DataTable ViewAllRequestWithCustomerName()
        {
            String StoredProcedureName = StoredProcedures.ViewAllRequestWithCustomerName;

            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetStoreRentalHistory(int CustomerID)
        {
            String StoredProcedureName = StoredProcedures.RetrieveStoreRentalHistory;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Customer_ID", CustomerID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetOnlineRentalHistory(int CustomerID)
        {
            String StoredProcedureName = StoredProcedures.RetrieveOnlineRentalHistory;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Customer_ID", CustomerID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int MovieRequest(int CID, string MovieName)
        {
            string StoredProcedureName = StoredProcedures.SendMovieRequest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Customer_ID", CID);
            Parameters.Add("@Movie_Name", MovieName);
            Parameters.Add("@Date", DateTime.Now.Date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int SendComplain(int CID, string Comment)
        {
            string StoredProcedureName = StoredProcedures.SendComplain;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Customer_ID", CID);
            Parameters.Add("@Comment", Comment);
            Parameters.Add("@Date", DateTime.Now.Date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetCustomerFName(int CustomerID)
        {
            String StoredProcedureName = StoredProcedures.GetCustomerFName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CustomerID", CustomerID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetCustomerLName(int CustomerID)
        {
            String StoredProcedureName = StoredProcedures.GetCustomerLName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CustomerID", CustomerID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetCustomerEmail(int CustomerID)
        {
            String StoredProcedureName = StoredProcedures.GetCustomerEmail;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CustomerID", CustomerID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetCustomerPassword(int CustomerID)
        {
            String StoredProcedureName = StoredProcedures.GetCustomerPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CustomerID", CustomerID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetCustomerPNumber(int CustomerID)
        {
            String StoredProcedureName = StoredProcedures.GetCustomerPNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CustomerID", CustomerID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetCustomerCCN(int CustomerID)
        {
            String StoredProcedureName = StoredProcedures.GetCustomerCCN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CustomerID", CustomerID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int UpdateCustomer(string fname, string lname, string email,  string pn, string ccn, int cid)
        {
            string StoredProcedureName = StoredProcedures.UpdateCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@Email", email);
            Parameters.Add("@PhoneNumber", pn);
            Parameters.Add("@CCN", ccn);
            Parameters.Add("@CustomerID", cid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddActor(string fname, string lname, string BirthDate, byte[] photo)
        {
            string StoredProcedureName = StoredProcedures.AddActor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@Birthdate", BirthDate);
            Parameters.Add("@Photo", photo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddReview(string Comment, int Customer_ID, int Movie_ID, int Rating, string date)
        {
            string StoredProcedureName = StoredProcedures.AddReview;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Comment", Comment);
            Parameters.Add("@Customer_ID", Customer_ID);
            Parameters.Add("@Movie_ID", Movie_ID);
            Parameters.Add("@Rating", Rating);
            Parameters.Add("@Date", date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetMostWatched()
        {
            String StoredProcedureName = StoredProcedures.GetMostWatched;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int RentOnline(int cid, int mid, string strdate, int duration, int price)
        {
            string StoredProcedureName = StoredProcedures.RentOnline;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CustomerID", cid);
            Parameters.Add("@MovieID", mid);
            Parameters.Add("@Str_Date", strdate);
            Parameters.Add("@Duration", duration);
            Parameters.Add("@Price", price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
        public int UpdateCustomerPassword(string Password, string username)
        {
            string StoredProcedureName = StoredProcedures.UpdateCustomerPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Password", Password);
            Parameters.Add("@Username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateStaffPassword(string Password, string username)
        {
            string StoredProcedureName = StoredProcedures.UpdateStaffPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Password", Password);
            Parameters.Add("@Username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateStaff(string fname, string lname, string email, string pn, int cid)
        {
            string StoredProcedureName = StoredProcedures.UpdateStaff;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@Email", email);
            Parameters.Add("@PhoneNumber", pn);
            Parameters.Add("@Staff_ID", cid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable StarsIn(int Actor_ID)
        {
            String StoredProcedureName = StoredProcedures.StarsIn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Actor_ID", Actor_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }



        public DataTable GetNewArrival()
        {
            String StoredProcedureName = StoredProcedures.GetNewArrival;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public object FindMovie(string Title)
        {
            String StoredProcedureName = StoredProcedures.FindMovie;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Title", Title);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object FindActor(string FName, string LName)
        {
            String StoredProcedureName = StoredProcedures.FindActor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FName", FName);
            Parameters.Add("@LName", LName);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        //
        public DataTable DisplayMovieDetails(int Movie_ID)
        {
            String StoredProcedureName = StoredProcedures.DisplayMovieDetails;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Movie_ID", Movie_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable DisplayActorDetails(int Actor_ID)
        {
            String StoredProcedureName = StoredProcedures.DisplayActorDetails;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Actor_ID", Actor_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public object CalculateRating(int Movie_ID)
        {

            string StoredProcedureName = StoredProcedures.CalculateRating;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Movie_ID", Movie_ID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object DisplayMovieImage(int Movie_ID)
        {

            string StoredProcedureName = StoredProcedures.DisplayMovieImage;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Movie_ID", Movie_ID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable GetStock(int Movie_ID)
        {
            String StoredProcedureName = StoredProcedures.GetStock;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Movie_ID", Movie_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetReview(int Movie_ID)
        {
            String StoredProcedureName = StoredProcedures.GetReview;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Movie_ID", Movie_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddMovie(string Title, string Plot, byte[] Poster, string Genre, string Release_Date, string Trailer, int Duration, int Price)
        {

            string StoredProcedureName = StoredProcedures.AddMovie;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("@Movie_ID", Movie_ID);
            Parameters.Add("@Title", Title);
            Parameters.Add("@Plot", Plot);
            Parameters.Add("@Poster", Poster);
            Parameters.Add("@Genre", Genre);
            Parameters.Add("@Release_Date", Release_Date);
            Parameters.Add("@Trailer", Trailer);
            Parameters.Add("@Duration", Duration);
            Parameters.Add("@Price", Price);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}
