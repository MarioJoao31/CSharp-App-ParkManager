using SmartPark.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Models
{
    public class Veiculo
    {
       //proprieties
       /// <summary>
       /// id do user a que pertence o veiculo
       /// </summary>
        public int IdUserMatricula { get; set; }
        
        /// <summary>
        /// matricula de carro
        /// </summary>
        public string Matricula { get; set; }

        /// <summary>
        /// tipo de veiculo
        /// </summary>
        public TipoVeiculo TipoVeiculo { get; set; }

        /// <summary>
        /// ctor veiculo
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="matricula"></param>
        /// <param name="tipoVeiculo"></param>
        public Veiculo(int idUser, string matricula, TipoVeiculo tipoVeiculo)
        {
           this.IdUserMatricula = idUser;
           this.Matricula = matricula;
          this.TipoVeiculo= tipoVeiculo;
       }
   }
}