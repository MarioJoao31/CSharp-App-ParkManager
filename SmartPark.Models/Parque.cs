using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Models
{
    public class Parque
    {
        //variables
        private static int idIncrementer = 1;

        //proprieties

        /// <summary>
        /// id od parque
        /// </summary>
        public int ParqueID { get; set; }

        /// <summary>
        /// nome do parque 
        /// </summary>
        public string NomeParque { get; set; }

        /// <summary>
        /// lugares disponiveis
        /// </summary>
        public int AvailablePlaces { get; set; }

        /// <summary>
        /// lugares totais do parque
        /// </summary>
        public int TotalPlaces { get; set; }


        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="nomeParque"></param>
        /// <param name="totalPlaces"></param>
        public Parque(string nomeParque,int totalPlaces)
        {
            this.ParqueID = Parque.idIncrementer++;         
            this.NomeParque = nomeParque;          
            this.AvailablePlaces = totalPlaces;
            this.TotalPlaces = totalPlaces;

        }
    }

}
