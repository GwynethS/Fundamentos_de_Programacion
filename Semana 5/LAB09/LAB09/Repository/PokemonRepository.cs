using LAB09.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB09.Repository
{
    internal class PokemonRepository
    {
        public PokemonRepository() { }
        public bool Existe(String codigoPokemon)
        {
            List<Entrenador> entrenadores = EntrenadorRepository.ListarTodo();
            
            foreach(Entrenador en in entrenadores)
            {
                bool existe = en.Pokemons.Exists(po => po.Codigo.Equals(codigoPokemon));

                if (existe)
                {
                    return true;
                }
            }
            return false;
        }
        public void Insertar(String codigoEntrenador, Pokemon pokemon)
        {
            Entrenador? en = EntrenadorRepository.ListarTodo().Find(ent => ent.Codigo.Equals(codigoEntrenador));
            if(en != null)
            {
                en.Pokemons.Add(pokemon);
            }
        }
        public List<Pokemon> ListarTodo(String codigoEntrenador)
        {
            Entrenador? en = EntrenadorRepository.ListarTodo().Find(ent => ent.Codigo.Equals(codigoEntrenador));
            if (en != null)
            {
                return en.Pokemons;
            }
            else
            {
                return new List<Pokemon>();
            }
        }
    }
}
