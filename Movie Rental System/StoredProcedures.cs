using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Rental_System
{
    class StoredProcedures
    {
        public static string StarsIn = "StarsIn";
        public static string SignUpCustomer = "SignUpCustomer";
        public static string InsertStaff = "InsertStaff";
        public static string InsertAdmin = "InsertAdmin";

        public static string SignInCustomer = "SignInCustomer";
        public static string SignInStaff = "SignInStaff";

        public static string GetCustomerWithUserName = "GetCustomerWithUserName";
        public static string GetCustomerWithEmail = "GetCustomerWithEmail";
        public static string GetCustomerWithPhoneNumber = "GetCustomerWithPhoneNumber";

        public static string GetStaffWithUserName = "GetStaffWithUserName";
        public static string GetStaffWithEmail = "GetStaffWithEmail";
        public static string GetStaffWithPhoneNumber = "GetStaffWithPhoneNumber";

        public static string CheckIfUserNameExist = "CheckIfUserNameExist";
        public static string CheckIfEmailExist = "CheckIfEmailExist";
        public static string CheckIfPhoneNumberExist = "CheckIfPhoneNumberExist";

        public static string GetStaffInfo = "GetStaffInfo";
        public static string GetStaffRole = "GetStaffRole";


        //loginids
        public static string ViewAllLoginID = "ViewAllLoginID";
        //MoviesInStock
        public static string ViewAllStockMoviesByEachMovie = "ViewAllStockMoviesByEachMovie";
        public static string DeleteMovieInStock = "DeleteMovieInStock";
        public static string AddMovieInStock = "AddMovieInStock";
        //Branch
        public static string ViewBranchNumb = "ViewBranchNumb";
        public static string AddBranch = "AddBranch";
        public static string ViewAllBranchDetails = "ViewAllBranchDetails";

        //customers
        public static string ViewAllCustomers = "ViewAllCustomers ";
        //moviies
        public static string ViewAllMovies = "ViewAllMovies";
        public static string DeleteMovie = "DeleteMovie";
        //staff
        public static string ViewAllStaff = "ViewAllStaff";
        public static string DeleteStaffMember = "DeleteStaffMember";
        public static string AddStaffMember = "AddStaffMember";
        //online and store renting
        public static string ShowAllOnlineRentingDetails = "ShowAllOnlineRentingDetails";
        public static string ShowStoreRentingDetails = "ShowStoreRentingDetails";
        public static string AddNewStoreRent = "AddNewStoreRent";
        //SuspensionList
        public static string ViewAllSuspensionListDetails = "ViewAllSuspensionListDetails";
        public static string RemoveCustomerFromSuspensionList = "RemoveCustomerFromSuspensionList";
        public static string AddCustomerinSuspensionList = "AddCustomerinSuspensionList";
        //Rating Reviews
        public static string ShowAllDetailsReview_Rating = "ShowAllDetailsReview_Rating";
        public static string ShowAllReview_RatingOfMovie = "ShowAllReview_RatingOfMovie";
        public static string RemoveeReview_Rating = "RemoveeReview_Rating";
        /// Request
        public static string RemoveeRequest = "RemoveeRequest";
        public static string ViewAllRequest = "ViewAllRequest";
        public static string ViewAllRequestWithCustomerName = "ViewAllRequestWithCustomerName";

        //Complains
        public static string ViewAllComplain = "ViewAllComplain";
        public static string RemoveeComplain = "RemoveeComplain";
        public static string ViewAllComplainandcustomerDetails = "ViewAllComplainandcustomerDetails";

        public static string RetrieveStoreRentalHistory = "StoreRentalHistory";
        public static string RetrieveOnlineRentalHistory = "OnlineRentalHistory";
        public static string SendMovieRequest = "AddMovieRequest";
        public static string SendComplain = "AddComplain";
        public static string GetCustomerFName = "GetCustomerFName";
        public static string GetCustomerLName = "GetCustomerLName";
        public static string GetCustomerEmail = "GetCustomerEmail";
        public static string GetCustomerPassword = "GetCustomerPassword";
        public static string GetCustomerPNumber = "GetCustomerPNumber";
        public static string GetCustomerCCN = "GetCustomerCCN";
        public static string UpdateCustomer = "UpdateCustomer";
        public static string AddReview = "AddReview";
        public static string GetMostWatched = "GetMostWatched";
        public static string AddActor = "AddActor";
        public static string RentOnline = "RentOnline";

        public static string UpdateCustomerPassword= "UpdateCustomerPassword";
        public static string UpdateStaffPassword = "UpdateStaffPassword";
        public static string UpdateStaff = "UpdateStaff";

        public static string FindMovie = "FindMovie";
        public static string AddMovie = "insertMovie";
        public static string DisplayMovieDetails = "DisplayMovieDetails";
        public static string DisplayMovieImage = "DisplayImage";
        public static string CalculateRating = "CalculateRating";
        public static string GetStock = "GetStock";
        public static string GetReview = "GetReview";
        public static string GetNewArrival = "GetNewArrival";
        public static string FindActor = "FindActor";
        public static string DisplayActorDetails = "DisplayActorDetails";



    }
}
