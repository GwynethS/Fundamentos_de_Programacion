using LAB09.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB09.Repository
{
    internal class EntrenadorRepository
    {
        private static List<Entrenador> entrenadores = new();
        public EntrenadorRepository() { }
        public bool Existe(String codigoEntrenador)
        {
            return entrenadores.Exists(en => en.Codigo.Equals(codigoEntrenador));
        }
        public void Insertar(Entrenador entrenador)
        {
            entrenadores.Add(entrenador);
        }
        public static List<Entrenador> ListarTodo()
        {
            return entrenadores;
        }
        public List<Entrenador> ListarPorRegion(String region)
        {
            return entrenadores.FindAll(en => en.Region.Equals(region));
        }
        public List<Entrenador> ListarPorPokemon(String nombrePokemon)
        {
            List<Entrenador> entrenadoresTemp = new();
            foreach(Entrenador en in entrenadores)
            {
                bool exsite = en.Pokemons.Exists(po => po.Nombre.Equals(nombrePokemon));
                if(exsite)
                {
                    entrenadoresTemp.Add(en);
                }
            }
            return entrenadoresTemp;
        }
        public List<Entrenador> ListarPorMenosPokemon()
        {
            List<Entrenador> entrenadoresTemp = new();
            int minTotal = 6;

            foreach (Entrenador en in entrenadores)
            {
                if (en.Pokemons.Count < minTotal)
                {
                    minTotal = en.Pokemons.Count;
                    entrenadoresTemp.Clear();
                    entrenadoresTemp.Add(en);
                }else if(en.Pokemons.Count == minTotal)
                {
                    entrenadoresTemp.Add(en);
                }
            }
            return entrenadoresTemp;
        }
    }
}
