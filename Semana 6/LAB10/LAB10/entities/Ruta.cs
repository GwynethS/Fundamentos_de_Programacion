using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10.entities
{
    internal class Ruta
    {
        public Ruta() { }
        public String Codigo { get; set; }
        public String Origen {  get; set; } 
        public String Destino { get; set; }
        public Double Kilometros { get; set; }
    }
}
