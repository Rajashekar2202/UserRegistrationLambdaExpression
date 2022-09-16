using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LambdaExpression
{
    public class UserRegistration
    {
        string Firstname = @"[A-Z]{1}[a-z]{2}$";
        public string FirstnameCheckusingLambda(string firstName) => Regex.IsMatch(firstName, Firstname) ? "FirstName is Valid" : "FirstName is not Valid";

        
        static string RegexLastName = "^[A-Z]{1,}[a-z]{3,}$";
        public string validateLastNameusingLambda(string LastName) => Regex.IsMatch(LastName, RegexLastName) ? "valid" : "Ivalid";


        static string RegexEmail = "^[0-9a-zA-Z]+([+#%&_.][a-zA-Z0-9]+)*[@]{1}[a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public string validateEmailusingLambda(string Email) => Regex.IsMatch(Email, RegexEmail) ? "valid" : "Invalid";

        
        static string RegexMobileNumber = "^[1-9]{2}[6-9]{1}[0-9]{9}$";
        public string validateMobileNumberusingLambda(string MobileNumber) => Regex.IsMatch(MobileNumber, RegexMobileNumber) ? "valid" : "Invalid";


        public static string RegexPassword = "^[a-zA-Z]{8,}$";
        public string validatePasswordusingLambda(string Password) => Regex.IsMatch(Password, RegexPassword) ? "valid" : "Invalid";


        public static string RegexPassword1 = "^[A-Z]{1,}[a-z]{7,}$";
        public string validatePassword1usingLambda(string Password1) => Regex.IsMatch(Password1, RegexPassword1) ? "valid" : "Invalid";


        public static string RegexPassword2 = "^[A-Z]{1,}[a-z]{5,}[0-9]{1,}$";
        public string validatePassword2usingLambda(string Password2) => Regex.IsMatch(Password2, RegexPassword1) ? "valid" : "Invalid";

    }
}

