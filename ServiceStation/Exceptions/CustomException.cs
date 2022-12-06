using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStation.Exceptions
{
    public class CustomException : Exception 
    {
        public CustomException(string message) : base(message)
        {
            Console.WriteLine("It is the text of Custom Exception!");
        }
    }
}
