using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA5.Entities;
using TA5.Repository;

namespace TA5.Services
{
    internal class CursoService
    {
        String codigoEstudiante;
        public CursoService(String codigoEstudiante)
        {
            this.codigoEstudiante = codigoEstudiante;
        }
        private CursoRepository cR = new();
        public bool Insertar(Curso curso)
        {
            if (cR.Existe(codigoEstudiante, curso.Codigo))
            {
                return false;
            }
            else
            {
                cR.Insertar(codigoEstudiante, curso);
                return true;
            }
        }
        public List<Curso> ListarTodo()
        {
            return cR.ListarTodo(codigoEstudiante);
        }
        public List<Curso> ListarCursosDesaprobados()
        {
            return cR.ListarCursosDesaprobados(codigoEstudiante);
        }
    }
}
