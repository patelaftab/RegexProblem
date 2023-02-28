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
       
    }
}
