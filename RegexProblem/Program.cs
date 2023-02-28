﻿using System;
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
            regexproblem.ValidateNumber("91 9876987654");
            regexproblem.ValidatePassword("aftabkas");
            regexproblem.ValidatePassword2("Aftabpat");
            regexproblem.ValidatePassword3("Aftabpat3");
            regexproblem.ValidatePassword4("Aftabpat@3");
            Console.ReadLine();
        }
    }
}
