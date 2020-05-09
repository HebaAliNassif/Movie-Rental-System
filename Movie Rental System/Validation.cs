using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Movie_Rental_System
{
    class Validation
    {
        bool NumberIsPositive(int num)
        {
            if (num > 0)
                return true;
            else
                return false;
        }

        bool NumberIsPositiveOrZero(int num)
        {
            if (num >= 0)
                return true;
            else
                return false;
        }

        bool NumberIsNegative(int num)
        {
            if (num < 0)
                return true;
            else
                return false;
        }

        bool NumberIsNegativeOrZero(int num)
        {
            if (num <= 0)
                return true;
            else
                return false;
        }

        bool NumberIsZero(int num)
        {
            if (num == 0)
                return true;

            return false;
        }

        bool StrigWithNoDigits(string s)
        {
            if (s.Any(char.IsDigit))
                return false;
            return true;
        }

        //To use this function
        //String err = "";
        //Object data = ValidationClass.isPositiveInteger("3",err);
        // int x = (int)data;
        public static Object isPositiveInteger(String input, StringBuilder err)
        {
            Object returnData = null;
            try
            {
                int x = Convert.ToInt32(input);
                if (x < 0)
                {
                    err.Append("Input " + input + " is a negative number");
                }
                else
                {
                    returnData = x;
                }
            }
            catch
            {
                err.Append("Input " + input + " is not a valid integer");
            }
            return returnData;
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsCardNumberValid(string cardNumber)
        {
            int i, checkSum = 0;

            // Compute checksum of every other digit starting from right-most digit
            for (i = cardNumber.Length - 1; i >= 0; i -= 2)
                checkSum += (cardNumber[i] - '0');

            // Now take digits not included in first checksum, multiple by two,
            // and compute checksum of resulting digits
            for (i = cardNumber.Length - 2; i >= 0; i -= 2)
            {
                int val = ((cardNumber[i] - '0') * 2);
                while (val > 0)
                {
                    checkSum += (val % 10);
                    val /= 10;
                }
            }

            // Number is valid if sum of both checksums MOD 10 equals 0
            return ((checkSum % 10) == 0);
        }
        public static bool IsPasswordValid(string password)
        {

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            bool isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password);
            return isValidated;
        }
        public static bool IsPhoneNumberVlidate(string phone)
        {

            var regex = @"^0\d{10}$";
            return Regex.IsMatch(phone, regex);
        }
    }
}
