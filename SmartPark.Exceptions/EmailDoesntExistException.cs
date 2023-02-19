using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Exceptions
{
    public class EmailDoesntExistException : Exception
    {
        public EmailDoesntExistException(string source)
        {
            this.Source = source;
        }

        public override string Message => "Email doesnt exist in users list";
    }
}
