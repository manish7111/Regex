using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidationUsingRegex
{
    public class RegexValidation
    {
        /// <summary>
        /// Regular Expressions global declarations.
        /// </summary>
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{6,}$";
        public static string MOBILENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string PASSWORD_REGEX = "^[a-zA-z0-9]{8,}";
        /// <summary>
        /// Validating input name with regular expression.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, NAME_REGEX);
        }
        /// <summary>
        /// Validating input mobile number with Regex
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool ValidMobileNumber(string number)
        {
            return Regex.IsMatch(number, MOBILENUMBER_REGEX);
        }
        /// <summary>
        /// Validating all kinds of emails using Regex
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
        /// <summary>
        /// Validating password as per input requirements using Regex
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidPassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD_REGEX);
        }
    }
}
