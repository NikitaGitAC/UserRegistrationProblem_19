using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class passwordrule3
    {
        public static string PassWord = "^(?=.*[0-9])(?=.*[A-Z]).{8,}$";
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, PassWord);
        }
    }
}
