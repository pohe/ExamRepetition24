using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{

    //Spg 12 DriverExistException
    public class DriverExistException: Exception
    {
        public DriverExistException(string message):base(message)
        {
            
        }
    }
}
