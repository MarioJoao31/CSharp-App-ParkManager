using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Exceptions
{
    public class VeiculoNotUniqueException : Exception
    {
        public VeiculoNotUniqueException(string source)
        {
            this.Source = source;
        }
        public override string Message => "This Veiculo is not unique";
    }
}
