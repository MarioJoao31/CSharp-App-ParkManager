using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Exceptions
{
    public class VeiculoNullException : Exception
    {
        public VeiculoNullException(string source)
        {
            this.Source = source;
        }
        public override string Message => "This Veiculo is Null";
    }
}
