using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA4.Modelos
{
    internal class Estudiante
    {
        public Estudiante() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Ciclo { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
