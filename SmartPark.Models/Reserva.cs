using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Models
{
    public class Reserva
    {
        //Var
        public static int idIncrementer = 1;

        //prop
        /// <summary>
        /// incrementador
        /// </summary>
        public int ReservaId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateReserva { get; set; }

        /// <summary>
        /// Email do user
        /// </summary>
        public string UserEmailReserva { get; set; }
        /// <summary>
        /// nome do parque
        /// </summary>
        public string NomeParqueReserva { get; set; }

        public Reserva(DateTime dataReserva, string EmaiUser, string NomeParque)
        {
            this.ReservaId = idIncrementer++;
            this.DateReserva = dataReserva;
            this.UserEmailReserva = EmaiUser;
            this.NomeParqueReserva = NomeParque;
        }
    }
}
