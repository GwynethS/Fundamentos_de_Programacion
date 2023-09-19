using LAB09.Entities;
using LAB09.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB09.Services
{
    internal class PokemonService
    {
        String codigoEntrenador;
        public PokemonService(String codigoEntrenador)
        {
            this.codigoEntrenador = codigoEntrenador;
        }
        private PokemonRepository pR = new();
        public bool Insertar(Pokemon pokemon)
        {
            if (pR.Existe(pokemon.Codigo))
            {
                return false;
            }
            else
            {
                pR.Insertar(codigoEntrenador, pokemon);
                return true;
            }
        }
        public List<Pokemon> ListarTodo()
        {
            return pR.ListarTodo(codigoEntrenador);
        }
    }
}
