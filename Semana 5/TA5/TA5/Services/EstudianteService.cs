using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA5.Entities;
using TA5.Repository;

namespace TA5.Services
{
    internal class EstudianteService
    {
        public EstudianteService() { }
        private EstudianteRepository eR = new();
        public bool Insertar(Estudiante estudiante)
        {
            if(eR.Existe(estudiante.Codigo))
            {
                return false;
            }
            else
            {
                eR.Insertar(estudiante);
                return true;
            }
        }
        public List<Estudiante>ListarTodo()
        {
            return EstudianteRepository.ListarTodo();
        }
        public List<Estudiante> ListarPorCodigoCurso(String codigoCurso)
        {
            return eR.ListarPorCodigoCurso(codigoCurso);
        }
        public List<Estudiante> ListarPorCiclo(int ciclo)
        {
            return eR.ListarPorCiclo(ciclo);
        }
        public List<Estudiante> ListarEstudiantesAprobadosNotaMasAlta()
        {
            return eR.ListarEstudiantesAprobadosNotaMasAlta();
        }
    }
}
