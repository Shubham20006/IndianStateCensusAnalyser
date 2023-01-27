using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndStateCensusAnalyser
{
    public class CustomException:Exception
    {
        public enum ExceptionType
        {           
            RECORD_NOT_MATCH,
            INCORRECT_TYPE,
            INCORRECT_DELIMITER,
            INCORRECT_HEADER
        }
        ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
