using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA5.Entities
{
    internal class Curso
    {
        public Curso() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public int Creditos { get; set; }
        public double Nota { get; set; }
        public String Estado { get; set; }
    }
}
