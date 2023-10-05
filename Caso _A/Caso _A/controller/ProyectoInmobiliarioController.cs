using Caso__A.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso__A.controller
{
    internal class ProyectoInmobiliarioController
    {
        private static List<ProyectoInmobiliario> proyectos = new List<ProyectoInmobiliario>();
        public ProyectoInmobiliarioController() { }
        public bool Existe(String codigo)
        {
            return proyectos.Exists(p => p.Codigo.Equals(codigo));
        }
        public void Registrar(ProyectoInmobiliario proyecto)
        {
            proyectos.Add(proyecto);
        }
        public static List<ProyectoInmobiliario> ListarTodo()
        {
            return proyectos;
        }
        public List<ProyectoInmobiliario>ListarProyectosLibresDistrito(String distrito)
        {
            List<ProyectoInmobiliario> proyectosLibres = proyectos.FindAll(p => p.Estado.Equals("Libre"));

            if (proyectosLibres.Count > 0)
            {
                List<ProyectoInmobiliario> proyectosDistrito = proyectosLibres.FindAll(p => p.Distrito.Equals(distrito));

                if(proyectosDistrito.Count > 0)
                {
                    return proyectosDistrito;
                }
                else
                {
                    return new List<ProyectoInmobiliario>();
                }
            }
            else
            {
                return new List<ProyectoInmobiliario>();
            }
        }
        public List<ProyectoInmobiliario>ProyectosLibresMetraje(String distrito, double metraje)
        {
            List<ProyectoInmobiliario> proyectosMetraje = ListarProyectosLibresDistrito(distrito).FindAll(p => p.Metraje.Equals(metraje));

            if(proyectosMetraje.Count > 0)
            {
                return proyectosMetraje;
            }
            else
            {
                return new List<ProyectoInmobiliario>();
            }
        }

        public List<ProyectoInmobiliario> ProyectosLibresHabitaciones(String distrito, int cantHabitaciones)
        {
            List<ProyectoInmobiliario> proyectosHabitaciones = ListarProyectosLibresDistrito(distrito).FindAll(p => p.CantidadHabitaciones.Equals(cantHabitaciones));

            if (proyectosHabitaciones.Count > 0)
            {
                return proyectosHabitaciones;
            }
            else
            {
                return new List<ProyectoInmobiliario>();
            }
        }

        public List<ProyectoInmobiliario> ProyectosLibresMetrajeHabitaciones(String distrito, double metraje, int cantHabitaciones)
        {
            List<ProyectoInmobiliario> proyectosMetrajeHabitaciones = ProyectosLibresMetraje(distrito, metraje).FindAll(p => p.CantidadHabitaciones.Equals(cantHabitaciones));

            if (proyectosMetrajeHabitaciones.Count > 0)
            {
                return proyectosMetrajeHabitaciones;
            }
            else
            {
                return new List<ProyectoInmobiliario>();
            }
        }
        public List<ProyectoInmobiliario>ListarProyectosVendidos()
        {
            List<ProyectoInmobiliario> proyectosVendidos = proyectos.FindAll(p => p.Estado.Equals("Firmado"));

            if(proyectosVendidos.Count > 0)
            {
                return proyectosVendidos;
            }
            else
            {
                return new List<ProyectoInmobiliario>();
            }
        }

        public double SumaPrecioProyectosVendidos()
        {
            double suma = 0;
            foreach(ProyectoInmobiliario p in ListarProyectosVendidos())
            {
                suma += p.Precio;
            }
            return suma;
        }

        public void ActualizarComentario(String codigo, String comentario)
        {
            ProyectoInmobiliario proyecto = proyectos.Find(p => p.Codigo.Equals(codigo));

            proyecto.Comentarios = comentario;
        }
    }
}
