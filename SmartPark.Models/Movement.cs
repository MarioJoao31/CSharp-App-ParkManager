using SmartPark.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Models
{
    public class Movement
    {
        //variables
        public static int idIncrementer = 1;

        //properties
        /// <summary>
        /// id do movimento
        /// </summary>
        public int IdMovimento { get; set; }

        /// <summary>
        /// valor da matricula
        /// </summary>
        public string Matricula { get; set; }

        /// <summary>
        /// data de movimento
        /// </summary>
        public DateTime DataMovimento { get; set; }

        /// <summary>
        /// tipo de movimento entrada/saida
        /// </summary>
        public TipoMovimento TipoMovimento { get; set; }

        /// <summary>
        /// numbero do parque em que esta reservado
        /// </summary>
        public int ParqueID { get; set; }


        //constructor
        /// <summary>
        /// cria movimento e depois incrementa id 
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="dataMovimento"></param>
        /// <param name="tipoMovimento"></param>
        /// <param name="parqueId"></param>
        public Movement(string matricula, DateTime dataMovimento,TipoMovimento tipoMovimento, int parqueId)
        {
            this.IdMovimento = Movement.idIncrementer++;
            this.Matricula = matricula;
            this.DataMovimento = dataMovimento;
            this.TipoMovimento = tipoMovimento;
            this.ParqueID = parqueId;
            
        }



    }
}
