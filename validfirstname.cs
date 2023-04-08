using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace UserRegistrationProblem
{
    public class validfirstname
    {
        public static string FirstName = "^[A-Z]{1}[A-Za-z]{3,}$";
        public bool ValidateFirstName(string FName)
        {
            return Regex.IsMatch(FName, FirstName);
        }
    }
}
