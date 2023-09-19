using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA5.Entities;

namespace TA5.Repository
{
    internal class CursoRepository
    {
        public CursoRepository() { }
        public bool Existe(String codigoEstudiante, String codigoCurso)
        {
            List<Estudiante> estudiantes = EstudianteRepository.ListarTodo();

            //Buscar el estudiante seleccionado
            Estudiante? estudianteSeleccionado = estudiantes.Find(estudiante => estudiante.Codigo.Equals(codigoEstudiante));

            if (estudianteSeleccionado != null)
            {
             
                return estudianteSeleccionado.Cursos.Exists(curso => curso.Codigo.Equals(codigoCurso));
            }

            return true;
        }
        public void Insertar(String codigoEstudiante, Curso curso)
        {
            List<Estudiante> estudiantes = EstudianteRepository.ListarTodo();

            Estudiante? estudianteSeleccionado = estudiantes.Find(estudiante => estudiante.Codigo.Equals(codigoEstudiante));

            if(estudianteSeleccionado != null)
            {
                estudianteSeleccionado.Cursos.Add(curso);
            }
        }
        public List<Curso> ListarTodo(String codigoEstudiante)
        {
            List<Estudiante> estudiantes = EstudianteRepository.ListarTodo();

            Estudiante? estudianteSeleccionado = estudiantes.Find(estudiante => estudiante.Codigo.Equals(codigoEstudiante));
            
            if(estudianteSeleccionado != null)
            {
                return estudianteSeleccionado.Cursos;
            }
            else
            {
                return new List<Curso>();
            }
        }
        public List<Curso>ListarCursosDesaprobados(String codigoEstudiante)
        {
            List<Estudiante> estudiantes = EstudianteRepository.ListarTodo();

            Estudiante? estudianteSeleccionado = estudiantes.Find(estudiante => estudiante.Codigo.Equals(codigoEstudiante));

            if (estudianteSeleccionado != null)
            {
                List<Curso> cursosTemp = estudianteSeleccionado.Cursos.FindAll(curso => curso.Estado.Equals("Desaprobado"));

                return cursosTemp;
            }

            return new List<Curso>();
        }
    }
}
