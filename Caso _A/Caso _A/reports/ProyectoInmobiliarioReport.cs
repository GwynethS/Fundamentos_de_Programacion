using Caso__A.controller;
using Caso__A.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso__A.reports
{
    internal class ProyectoInmobiliarioReport
    {
        ProyectoInmobiliarioController pC = new ProyectoInmobiliarioController();

        public ProyectoInmobiliarioReport() { }
        public bool Registrar(ProyectoInmobiliario proyecto)
        {
            if(pC.Existe(proyecto.Codigo))
            {
                return false;
            }
            else
            {
                pC.Registrar(proyecto);
                return true;
            }
        }

        public List<ProyectoInmobiliario>ListarTodo()
        {
            return ProyectoInmobiliarioController.ListarTodo();
        }

        public List<ProyectoInmobiliario> ListarProyectosLibresDistrito(String distrito)
        {
            return pC.ListarProyectosLibresDistrito(distrito);
        }
        public List<ProyectoInmobiliario> ProyectosLibresMetraje(String distrito, double metraje)
        {
            return pC.ProyectosLibresMetraje(distrito, metraje);
        }

        public List<ProyectoInmobiliario> ProyectosLibresHabitaciones(String distrito, int cantHabitaciones)
        {
            return pC.ProyectosLibresHabitaciones(distrito, cantHabitaciones);
        }

        public List<ProyectoInmobiliario> ProyectosLibresMetrajeHabitaciones(String distrito, double metraje, int cantHabitaciones)
        {
            return pC.ProyectosLibresMetrajeHabitaciones(distrito, metraje, cantHabitaciones);
        }
        public List<ProyectoInmobiliario> ListarProyectosVendidos()
        {
            return pC.ListarProyectosVendidos();
        }

        public double SumaPrecioProyectosVendidos()
        {
            return pC.SumaPrecioProyectosVendidos();
        }

        public void ActualizarComentario(String codigo, String comentario)
        {
            pC.ActualizarComentario(codigo, comentario);
        }
    }
}
