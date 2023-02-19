using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Exceptions
{
    public class ReservaNullException : Exception
    {
        public ReservaNullException(string source)
        {
            this.Source = source;
        }

        public override string Message => "Reserva is null";
    }
}
