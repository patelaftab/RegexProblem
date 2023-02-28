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
                Console.WriteLine("The First Name is MAtching");
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
                Console.WriteLine("The Last Name is MAtching");
            }
            else
            {
                Console.WriteLine("The PAttern is Not MAtching");
            }

        }
        public void ValidateEmail(string email)
        {
            string emailadd = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}?";
            if(Regex.IsMatch(email, emailadd))
            {
                Console.WriteLine("Email Address Matching Wih Regex Pattern");
            }
            else
                Console.WriteLine("Not Matching With Pattern");
        }
        public void ValidateNumber(string number)
        {
            string phoneNumber = "^[0-9]{1,2}[ ][0-9]{10}?";
            if(Regex.IsMatch(number, phoneNumber))
            {
                Console.WriteLine("The Regex Pattern For Phone Number IS Mactching");
            }
            else
                Console.WriteLine("Pattern is Not MAtching");
        }
        public void ValidatePassword(string password)
        {
            string passwrd = @"[A-Z a-z 0-9]{8,}";
            if (Regex.IsMatch(password, passwrd))
            {
                Console.WriteLine("Pattern is Matching For Password");
            }
            else
            {
                Console.WriteLine("Pattern is Not Mathing");
            }
        }
        public void ValidatePassword2(string password)
        {
            string passwordPatten = "(?=.*[A-Z])[A-Za-z0-9]{8,}";
            if (Regex.IsMatch(password, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password not Valid ");
            }
        }
        public void ValidatePassword3(string password)
        {
            string passwordPatten = "(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}";
            if (Regex.IsMatch(password, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password not Valid ");
            }
        }
        public void ValidatePassword4(string password)
        {
            string passwordPatten = "(?=.*[A-Z])(?=.*[0-9])(?=.*[*#@$!^_-])[A-Za-z0-9]{8,}";
            if (Regex.IsMatch(password, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password not Valid ");
            }
        }
    }
}
