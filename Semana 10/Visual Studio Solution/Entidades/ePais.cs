using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ePais
    {
        public int IdPais { get; set; }
        public string NombrePais { get; set; }

        public override string ToString()
        {
            return NombrePais;
            
        }
    }
}
