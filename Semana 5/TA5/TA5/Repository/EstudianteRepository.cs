using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA5.Entities;

namespace TA5.Repository
{
    internal class EstudianteRepository
    {
        private static List<Estudiante> estudiantes = new();
        public EstudianteRepository() { }
        public bool Existe(String codigoEstudiante)
        {
            return estudiantes.Exists(estudiante => estudiante.Codigo.Equals(codigoEstudiante));
        }

        public void Insertar(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }
        public static List<Estudiante> ListarTodo()
        {
            return estudiantes;
        }
        public List<Estudiante>ListarPorCodigoCurso(String codigoCurso)
        {
            List<Estudiante> estudiantesTemp = new();
            foreach(Estudiante estudiante in estudiantes)
            {
                bool existe = estudiante.Cursos.Exists(c => c.Codigo.Equals(codigoCurso));
                if (existe)
                {
                    estudiantesTemp.Add(estudiante);
                }
            }
            return estudiantesTemp;
        }
        public List<Estudiante>ListarPorCiclo(int ciclo)
        {
            List<Estudiante> estudiantesTemp = new();
            foreach (Estudiante estudiante in estudiantes)
            {
                bool existe = estudiante.Ciclo.Equals(ciclo);
                if (existe)
                {
                    estudiantesTemp.Add(estudiante);
                }
            }
            return estudiantesTemp;
        }
        public List<Estudiante>ListarEstudiantesAprobadosNotaMasAlta()
        {
            List<Estudiante> estudiantesTemp = new();
            double maxNota = 0;

            foreach (Estudiante estudiante in estudiantes)
            {
                if (estudiante.Cursos.Count == 0) continue;

                //Buscar el curso aprobado con la máxima nota
                double maxNotaCurso = 0;
                foreach (Curso c in estudiante.Cursos)
                {
                    if (c.Nota > maxNotaCurso && c.Estado == "Aprobado")
                    {
                        maxNotaCurso = c.Nota;
                    }
                }

                if (maxNotaCurso > maxNota)
                {
                    maxNota = maxNotaCurso;
                    estudiantesTemp.Clear();
                    estudiantesTemp.Add(estudiante);
                }
                else if (maxNotaCurso == maxNota && maxNotaCurso != 0)
                {
                    estudiantesTemp.Add(estudiante);
                }
            }
            return estudiantesTemp;
        }
    }
}
