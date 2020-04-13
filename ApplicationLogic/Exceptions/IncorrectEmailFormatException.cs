using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Exceptions
{
    class IncorrectEmailFormatException: Exception
    {
        public string Email { get; private set; }
        public IncorrectEmailFormatException(string email): base($"{email} email has incorrect format")
        {
        }
    }
}
