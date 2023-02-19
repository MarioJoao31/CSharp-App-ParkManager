using SmartPark.Models;
using SmartPark.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPark.Enums;

namespace SmartPark.Data
{
    public class Movements
    {
        //variables
        List<Movement> movements = new List<Movement>();

        //ctor
        public Movements()
        {
            this.Add(new Movement("23-SP-69", DateTime.Now, TipoMovimento.Entrada, 1));
            this.Add(new Movement("23-SP-69", DateTime.Now, TipoMovimento.Saida, 2));
            this.Add(new Movement("58-QH-79", DateTime.Now, TipoMovimento.Entrada, 3));
            this.Add(new Movement("11-QL-42", DateTime.Now, TipoMovimento.Entrada, 4));
            this.Add(new Movement("58-QH-79", DateTime.Now, TipoMovimento.Saida, 5));
        }



        /// <summary>
        /// adds a new movements in list 
        /// </summary>
        /// <param name="newMovement">new movement </param>
        /// <exception cref="MovementNullException">if is passed a null movement</exception>
        /// <exception cref="Exception"></exception>
        public void Add(Movement newMovement/*, List<Parque> parques*/)
        {
            //if null exception
            if (newMovement is null)
                throw new MovementNullException("[Data]->Movements.Add()");

            //TODO:criar if se existe parque ou nao

            //if (!parques.Exists(p => p.ParqueID == newMovement.ParqueID))
            //    throw new Exception();
            

            
            // passar para aqui a lista dos parques para verificar se existe ou nao


            //adiciona movimento
            try
            {
                this.movements.Add(newMovement);
            }
            catch (Exception)
            {

                throw new Exception();
            }

        }

        /// <summary>
        /// retona todos os movements
        /// </summary>
        /// <returns>retorna um array de moment</returns>
        public Movement[] GetMovements()
        {
            return this.movements.ToArray();
        }

        /// <summary>
        /// retorna um array com os todos os movimentos da matricula passada
        /// </summary>
        /// <param name="matricula">matricula </param>
        /// <returns>retorna o array</returns>
        public Movement[] GetMovementsbyPlate(string matricula)
        {
            return this.movements.Where(m => m.Matricula == matricula).ToArray();
        }

        
        //TODO: RETORNAR LISTA DE MOVIMENTOS NUM DIA


        /// <summary>
        /// retorna a lista dos movements com o dia escolhido
        /// </summary>
        /// <param name="diaEscolhido"></param>
        /// <param name="movimento"></param>
        /// <returns></returns>
        public List<Movement> GetMovementsByDay(DateTime diaEscolhido)
        {
            //formatar data de entrada
            string strFormat = "ddMMyyyy";
            string dia = diaEscolhido.ToString(strFormat);
            
            //cria Lista temporaria de movements onde vao ser guardados os movements com a mesma data
            List<Movement> listTemp = new List<Movement>();


            //pesqueisa dentro da classe movement dentro dos movements
            foreach (Movement movement in movements)
            {
                
                //compara a data de entrada com a data de movimento 
                if (dia == movement.DataMovimento.ToString(strFormat))
                {
                    listTemp.Add(movement);

                }

            }
            //retornar lista temporaria
            return listTemp;
        }
         
    }
}