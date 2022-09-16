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
    }
}
