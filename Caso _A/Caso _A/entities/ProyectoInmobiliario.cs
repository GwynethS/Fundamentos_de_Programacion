using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso__A.entities
{
    internal class ProyectoInmobiliario
    {
        public ProyectoInmobiliario() { }
        public String Codigo { get; set; }
        public String NombrePropietario { get; set; }
        public String MovilPropietario { get; set; }
        public String Estado { get; set; }
        public int CantidadHabitaciones { get; set; }
        public int CantidadEstacionamientos { get; set; }
        public String CuentaDeposito { get; set; }
        public double Metraje { get; set; }
        public double Precio { get; set; }
        public String Distrito { get; set; }
        public String Descripcion { get; set; }
        public String Comentarios { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
