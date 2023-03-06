﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class CustomeException:Exception
    {
        public enum ExceptionType
        {
            NULL_INPUT,
            EMPTY_INPUT,
        }
        public ExceptionType Type;
        public CustomeException(ExceptionType Type,string message):base(message)
        {
            this.Type = Type;
        }
    }
}
