using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Exceptions
{
    public class ParameterException : Exception
    {
        public ParameterException(string source)
        {
            this.Source = source;
        }
        public override string Message => "Parameters empty";
    }
}
