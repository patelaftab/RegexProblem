using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regexproblem regexproblem = new Regexproblem();
            regexproblem.Validatefirstname("Aftab");
            regexproblem.Validatelastname("Patel");
            regexproblem.ValidateEmail("abc.xyz@bridgelabz.co.in\r\n");
            Console.ReadLine();
        }
    }
}
