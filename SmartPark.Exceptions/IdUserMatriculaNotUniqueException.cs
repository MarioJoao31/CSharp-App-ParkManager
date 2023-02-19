using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Exceptions
{
    public class IdUserMatriculaNotUnique : Exception
    {
        public IdUserMatriculaNotUnique(string source)
        {
            this.Source = source;
        }
        public override string Message => "This IdUserMatricula is not unique";
    
    }
}
