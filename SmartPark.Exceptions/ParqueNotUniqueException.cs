using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Exceptions
{
    public class ParqueNotUniqueException : Exception
    {
        public ParqueNotUniqueException(string source)
        {
            this.Source = source;
        }

        public override string Message => "This parque is not unique";
    }
}
