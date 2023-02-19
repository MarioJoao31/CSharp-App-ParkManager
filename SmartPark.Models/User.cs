using SmartPark.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Models
{
    //class filho
    public class User : Siga
    {
        //variables
        public static int idIncrementer = 1;

        public int IdUser { get; set; }
        //properties
        /// <summary>
        /// Nome de user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email de utilizador
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// pass do user
        /// </summary>
        private string _password { get; set; }

        public string Password
        {
            get { return _password; }
            set { this._password = value; }
        }
        

        /// <summary>
        /// Grau do user
        /// </summary>
        private int NivelUser { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="nivelUser"></param>
        /// <param name="statusDescription"></param>
        /// <param name="poloPreference"></param>
        public User(string nome, string email, string password, int nivelUser, TipoEstatuto statusDescription, TipoPolo poloPreference) : base(statusDescription, poloPreference)
        {
            this.IdUser = User.idIncrementer++;
            this.Name= nome;
            this.Email= email;
            this.Password= password;
            this.NivelUser= nivelUser;
        }

        /// <summary>
        /// metodo que retorna password
        /// </summary>
        /// <returns>string password</returns>
        public string GetPassword()
        {
            return this.Password;
        }

        /// <summary>
        /// metodo que retorna nivel de user
        /// </summary>
        /// <returns>int Niveluser</returns>
        public int GetNivelUser()
        {
            return this.NivelUser;
        }

        ///Meter AutoIncrement No users - Mario

    }
}
