using SmartPark.Exceptions;
using SmartPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Data
{
    public class Reservas
    {
        List<Reserva> reservas = new List<Reserva>();

        public Reservas()
        {
            reservas.Add(new Reserva(DateTime.Today, "admin@gmail.com", "Parque-A"));
        }

        /// <summary>
        /// adiciona reservas 
        /// </summary>
        /// <param name="newReserva"></param>
        /// <param name="users"></param>
        /// <param name="parque"></param>
        public void Add(Reserva newReserva, Users users, Parques parque)
        {
            try
            {
                //se for null
                if (newReserva is null)
                    throw new ReservaNullException("[Data]-SmartPark.Data-Reservas.Add()");
                //se nao existir email deste user
                if (!users.ExistsEmail(newReserva.UserEmailReserva))
                {
                    throw new EmailDoesntExistException("[Data]-SmartPark.Data-Reservas.Add()");
                }
                //se nao existe nome do parque 

                
                reservas.Add(newReserva);
            }
            catch (EmailDoesntExistException)
            {
                Console.WriteLine("[Data]-SmartPark.Data-Reservas.Add()- Email nao existe");
            }
            catch (ReservaNullException)
            {
                Console.WriteLine("[Data]-SmartPark.Data-Reservas.Add()");
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// retorna a lista de reservas 
        /// </summary>
        /// <returns></returns>
        public List<Reserva> GetReservas() => this.reservas.ToList();
    }
}
