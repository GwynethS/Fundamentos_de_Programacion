using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB09.Entities
{
    internal class Pokemon
    {
        public Pokemon() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Apodo { get; set; }
        public String Tipo { get; set; }
        public int PuntosSalud { get; set; }
        public bool Legendario { get; set; }
    }
}
