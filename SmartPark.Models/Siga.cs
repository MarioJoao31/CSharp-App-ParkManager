using SmartPark.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Models
{
    /// <summary>
    /// Base class/ classe pai 
    /// </summary>
    public abstract class Siga
    {
        //properties
        /// <summary>
        /// Descrição de estatuto 
        /// </summary>
        public TipoEstatuto StatusDescription { get; set; }

        /// <summary>
        /// polo de preferencia
        /// </summary>
        public TipoPolo PreferencePolo { get; set; }

        public Siga(TipoEstatuto statusDescription, TipoPolo preferencePolo)
        {
            StatusDescription = statusDescription;
            PreferencePolo = preferencePolo;
        }
    }
}
