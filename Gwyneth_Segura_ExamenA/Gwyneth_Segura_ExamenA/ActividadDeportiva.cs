using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwyneth_Segura_ExamenA
{
    internal class ActividadDeportiva
    {
        public ActividadDeportiva() { }
        public String Codigo { get; set; }
        public String Nombre { get; set;}
        public String Horario { get; set; }
        public int Capacidad { get; set; }  
        public List<Miembro> Miembros {  get; set; }    
    }
}
