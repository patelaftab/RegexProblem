using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class Regexproblem
    {
        public void Validatefirstname(string name)
        {
            string firstName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, firstName)) 
            {
                Console.WriteLine("The Name is MAtching");
            }
            else
            {
                Console.WriteLine("The Regex Pattern is not WOrking");
            }  
        }
        public void Validatelastname(string name)
        {
            string lastName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("The Name is MAtching");
            }
            else
            {
                Console.WriteLine("The PAttern is Not MAtching");
            }

        }
        public void ValidateEmail(string email)
        {
            string emailadd = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            if(Regex.IsMatch(email, emailadd))
            {
                Console.WriteLine("Email Address Matching Wih Regex Pattern");
            }
            else
                Console.WriteLine("Not Matching With Pattern");
        }
    }
}
