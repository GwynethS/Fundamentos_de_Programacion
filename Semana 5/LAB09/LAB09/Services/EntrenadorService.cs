using LAB09.Entities;
using LAB09.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB09.Services
{
    internal class EntrenadorService
    {
        public EntrenadorService() { }
        private EntrenadorRepository eR = new();
        public bool Insertar(Entrenador entrenador)
        {
            if(eR.Existe(entrenador.Codigo))
            {
                return false;
            }
            else
            {
                eR.Insertar(entrenador);
                return true;
            }
        }
        public List<Entrenador> ListarTodo()
        {
            return EntrenadorRepository.ListarTodo();
        }
        public List<Entrenador> ListarPorRegion(String region)
        {
            return eR.ListarPorRegion(region);
        }
        public List<Entrenador> ListarPorPokemon(String nombrePokemon)
        {
            return eR.ListarPorPokemon(nombrePokemon);
        }
        public List<Entrenador> ListarPorMenosPokemon()
        {
            return eR.ListarPorMenosPokemon();
        }
    }
}
