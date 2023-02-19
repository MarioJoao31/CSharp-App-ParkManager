
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPark.Models;
using SmartPark.Exceptions;
using SmartPark.Enums;

namespace SmartPark.Data
{
    public class Users 
    {
        //list
        List<User> users = new List<User>();

        //constructor
        public Users()
        {
            this.Add(new User("Mário", "mario@gmail.com", "password", 1,TipoEstatuto.Aluno,TipoPolo.EST));
            this.Add(new User("joao", "dady@gmail.com", "asd", 1, TipoEstatuto.Aluno, TipoPolo.EST));
            this.Add(new User("helder", "mario@gmail.com", "asd123", 1, TipoEstatuto.Professor, TipoPolo.ESG));
            this.Add(new User("admin", "admin@gmail.com", "admin", 0, TipoEstatuto.Professor, TipoPolo.ESG));
        }

        //methods
        /// <summary>
        /// Adiciona na lista 
        /// </summary>
        /// <param name="newuser">novo user</param>
        /// <exception cref="UserNullException"></exception>
        /// <exception cref="Exception"></exception>
        public void Add(User newuser)
        {
            //TODO:fazer exceptions para os users 

            if (newuser == null)
                throw new UserNullException("[Data]SmartPark.Data.Users.Add()->UserNull");

            try
            {
                this.users.Add(newuser);
            }
            
            catch (Exception)
            {
                throw new Exception("[Data]SmartPark.Data.Users.Add()");
            }
        }

        /// <summary>
        /// checks if is the username and passwrod match the list
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="password">password</param>
        /// <returns>bool</returns>
        public bool ValidatePassword(string email,string password) => users.Exists(u => u.Email.Equals(email) && u.GetPassword().Equals(password));

        /// <summary>
        /// retorna o grau de permissao do user 
        /// </summary>
        /// <param name="email">email do user</param>
        /// <returns> int </returns>
        public int GetGrauUser(string email)
        {
            User selectedUser;
            selectedUser = this.users.Find(u => u.Email.Equals(email));
            return selectedUser.GetNivelUser();
        }

        /// <summary>
        /// retorna um array de todos os users 
        /// </summary>
        /// <returns> array</returns>
        public User[] GetUsers()
        {
            return this.users.ToArray();
        }

            
        /// <summary>
        /// elimina user atraves do id 
        /// </summary>
        /// <param name="userID"> id do user a eliminar</param>
        public void Delete(int userID)
        {
            //var
            int index = 0;

            //finds index
            index = this.users.FindIndex(u => u.IdUser == userID);

            //removes from list
            this.users.RemoveAt(index);
        }

        /// <summary>
        /// verifica se existe um user com esse email 
        /// </summary>
        /// <param name="email">email a passar </param>
        /// <returns>bool </returns>
        public bool ExistsEmail(string email) => users.Exists(u => u.Email == email);
        
        /// <summary>
        /// retornar a lista de users
        /// </summary>
        /// <returns></returns>
        public List<User> List() => this.users;
        /// <summary>
        /// retornar a lista com o estatuto do id do user
        /// </summary>
        /// <param name="tipoEstatuto"></param>
        /// <returns></returns>
        public List<User> GetUserByState(TipoEstatuto tipoEstatuto) => this.users.Where(u => u.StatusDescription == tipoEstatuto).ToList();
        
        public int GetIdUserByEmail(string email)
        {
            User iduser;
            iduser = this.users.Find(u => u.Email.Equals(email));
            return iduser.IdUser;
        }
    }
}
