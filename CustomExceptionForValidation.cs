using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationLambdaExpression
{
    public class CustomException_For_UserValidation : Exception
    {
        private ExceptionType type;
        public enum ExceptionType
        { 
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            INVALID_MESSAGE
        }

        public CustomException_For_UserValidation(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}