using System;
using System.Security.Principal;
using SmartPark.Exceptions;
using SmartPark.Models;

namespace SmartPark.Data
{
    public class Parques
    {
        //variables
        List<Parque> parques = new List<Parque>();

        //constructor
        public Parques()
        {
            this.Add(new Parque("Parque-A", 55));
            this.Add(new Parque("Parque-B", 23));
            this.Add(new Parque("Parque-C", 34));
            this.Add(new Parque("Parque-D", 45));
            this.Add(new Parque("Parque-E", 56));
        }

        //methods
        /// <summary>
        /// adiciona na lista
        /// </summary>
        /// <param name="newParque">novo parque</param>
        /// <exception cref="ParqueNullException">execption para parque nullo</exception>
        /// <exception cref="Exception"></exception>
        public void Add(Parque newParque)
        {

            if (newParque is null)
                throw new ParqueNullException("[Data]Parques.Add->newparque null");

            if (this.parques.Exists(p => p.NomeParque == newParque.NomeParque))
                throw new ParqueNotUniqueException("[Data]Parques.Add->newparque already exists with that name");

            if (this.parques.Exists(p => p.ParqueID == newParque.ParqueID))
                throw new ParqueNotUniqueException("[Data]Parques.Add->newparque already exists with that id");


            //adds to the list or gives error
            try
            {
                this.parques.Add(newParque);
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        /// <summary>
        /// returns all the parques in array
        /// </summary>
        /// <returns></returns>
        public Parque[] GetParques()
        {
            return this.parques.ToArray();
        }

        /// <summary>
        /// removes parque with id 
        /// </summary>
        /// <param name="parqueID"></param>
        public void Remove(int parqueID)
        {
            //var
            int index = 0;

            //finds index
            index = this.parques.FindIndex(p=>p.ParqueID == parqueID);
           
            //removes from list
            this.parques.RemoveAt(index);
        }

        /// <summary>
        /// update the number of spaces avaiable for the specific parque
        /// </summary>
        /// <param name="parqueId"></param>
        /// <param name="spaceValue"></param>
        public void UpdateSpaces(int parqueId, int spaceValue)
        {
            //Var
            Parque selectedParque;

            //find correct parque
            selectedParque = this.parques.Find(p => p.ParqueID == parqueId);

            //changes de value of avaible parques
            selectedParque.AvailablePlaces = selectedParque.AvailablePlaces + spaceValue;
        }

  
        /// <summary>
        /// sees if parque is full 
        /// </summary>
        /// <param name="parqueId"></param>
        /// <returns>bool if parque is not full</returns>
        public bool ExistsAvailableSpaces(int parqueId)
        {
            //var 
            Parque selectedParque;

            //finds selected parque
            selectedParque = this.parques.Find(p => p.ParqueID == parqueId);

            //if avaiable spaces is inferior than totalSpaces return true
            return selectedParque.AvailablePlaces != 0;
        }

    }
}

