using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Empleado
    {
        public Empleado() { }
        public Empleado(String nombre, String categoria, int tardanzas, int llamadas)
        {
            Nombre = nombre;
            Categoria = categoria;
            Tardanzas = tardanzas;
            Llamadas = llamadas;
        }
        public String Nombre { get; set; }
        public String Categoria { get; set; }
        public int Tardanzas { get; set; }
        public int Llamadas { get; set; }

        public double Pago { get; set; }
    }
}
