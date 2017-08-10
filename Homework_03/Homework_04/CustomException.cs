using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
{
    public class CustomException : Exception
    {
        public String message;
        public CustomException(String exception)
        {
            message = "Exception Occured: " + exception;
        }
    }
}
