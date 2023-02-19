using SmartPark.Enums;
using SmartPark.Exceptions;
using SmartPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPark.Data
{
    public class Veiculos
    {
        //criar lista veiculos
        List<Veiculo> veiculos = new List<Veiculo>();
        //constructor
        public Veiculos()
        {
            this.Add(new Veiculo(1, "12-HH-12", TipoVeiculo.Carro));
            this.Add(new Veiculo(2, "13-HH-13", TipoVeiculo.Mota));
        }

        /// <summary>
        /// Adiciona veiculo a lista
        /// </summary>
        /// <param name="newVeiculo">passa um novo veiculo</param>
        public void Add(Veiculo newVeiculo)
        {
            try
            {
                if (newVeiculo is null)
                    throw new VeiculoNullException("[Data]SmartPark.Data.Veiculos.Add()->VeiculoNull");

                
                if (this.veiculos.Exists(v => v.Matricula == newVeiculo.Matricula && v.IdUserMatricula == newVeiculo.IdUserMatricula))
                    throw new VeiculoNotUniqueException("[Data]SmartPark.Data.Veiculos.Add()->VeiculoNotUnique");

                this.veiculos.Add(newVeiculo);

            }
            catch (VeiculoNullException)
            {
                Console.WriteLine("[Data]SmartPark.Data.Veiculos.Add()->VeiculoNull");
            }
            catch (VeiculoNotUniqueException)
            {
                Console.WriteLine("[Data]SmartPark.Data.Veiculos.Add()->VeiculoNotUnique");
            }
            catch (IdUserMatriculaNotUnique)
            {
                Console.WriteLine("[Data]SmartPark.Data.Veiculos.Add()->IdUserMatriculaNotUnique");
            }
            
        }


        /// <summary>
        /// muda as proprieadades do veiculo passando um veiculo novo
        /// </summary>
        /// <param name="veiculo">veiculo </param>
        /// <exception cref="VeiculoNullException"></exception>
        /// <exception cref="VeiculoNotUniqueException"></exception>
        /// <exception cref="IdUserMatriculaNotUnique"></exception>
        public void Update(Veiculo veiculo)
        {
            //variavel temporaria
            int index = 0;
            //se for nulo --> throw nossa exception
            if (veiculos is null)
                throw new VeiculoNullException("[Data]SmartPark.Data.Veiculos.Update()->VeiculoNull");
            if (this.veiculos.Exists(v => v.Matricula.Equals(veiculo.Matricula)))
                throw new VeiculoNotUniqueException("[Data]SmartPark.Data.Veiculos.Update()->VeiculoNotUnique");
            if (this.veiculos.Exists(u => u.IdUserMatricula == veiculo.IdUserMatricula))
                throw new IdUserMatriculaNotUnique("[Data]SmartPark.Data.Veiculos.Update()->IdUserMatriculaNotUnique");

            //index of position of the Veiculo
            index = this.veiculos.FindIndex(v => v.Matricula == veiculo.Matricula && v.IdUserMatricula == veiculo.IdUserMatricula);
            //veiculo that have unique matricula and iduser unique, change the veiculo
            this.veiculos[index] = veiculo;
        }

        /// <summary>
        /// Elimina o veiculo 
        /// </summary>
        /// <param name="veiculo"></param>
        /// <exception cref="VeiculoNullException"></exception>
        /// <exception cref="VeiculoNotUniqueException"></exception>
        /// <exception cref="IdUserMatriculaNotUnique"></exception>
        public void Delete(string matricula, int idUser)
        {
            //variavel temporaria
            int index = 0;

            try
            {
                if (matricula == "" || idUser == 0)
                    throw new ParameterException("[Data]SmartPark.Data.Veiculos.Delete()->Parameters not filled");

                //index of position of the Veiculo
                index = this.veiculos.FindIndex(v => v.Matricula == matricula && v.IdUserMatricula == idUser);
                //remove the Veiculo
                this.veiculos.RemoveAt(index);
            }
            catch (ParameterException)
            {
                Console.WriteLine("[Data]SmartPark.Data.Veiculos.Delete()->Parameters not filled");
            }
            catch (Exception )
            {
                throw;
            }

            
        }

        //Lista os veiculos todos dentro da lista user
        /// <summary>
        /// retorna a lista de veiculos
        /// </summary>
        /// <returns>lista de todos os veiculos</returns>
        public List<Veiculo> List() => this.veiculos;

        /// <summary>
        ///  retorna a lista de veiculos de um user
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public List<Veiculo> GetUserVeiculos(int idUser) => this.veiculos.Where(v => v.IdUserMatricula == idUser).ToList();

        /// <summary>
        /// retorna a contagem de veiculos
        /// </summary>
        /// <returns></returns>
        public int TotalVeiculos()
        {
            return this.veiculos.Count;
        }
    }
}
