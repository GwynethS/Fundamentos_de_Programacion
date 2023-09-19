using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA4.Modelos;

namespace TA4
{
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarEstudiantes(List<Estudiante>lst)
        {
            listViewEstudiantes.Items.Clear();

            foreach(Estudiante e in lst)
            {
                ListViewItem fila = new ListViewItem(e.Codigo);
                fila.SubItems.Add(e.Nombre);
                fila.SubItems.Add(e.Apellidos);
                fila.SubItems.Add(e.Ciclo.ToString());

                listViewEstudiantes.Items.Add(fila);
            }
        }

        private void btnAgenciaAgregar_Click(object sender, EventArgs e)
        {
            //Validar campos ingresados
            if(txtEstudianteCodigo.Text == "" || txtEstudianteNombre.Text == "" || txtEstudianteApellidos.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los datos del estudiante para poder registrarlo.");
                return;
            }

            //Validar código repetido
            bool codigoRepetido = estudiantes.Exists(estudiante => estudiante.Codigo.Equals(txtEstudianteCodigo.Text));
            if(codigoRepetido)
            {
                MessageBox.Show("Vaya! Parece que ya se ha registrado un estudiante con este código, pruebe con uno diferente.");
                return;
            }

            //Crear el objeto estudiante
            Estudiante estudiante = new()
            {
                Codigo = txtEstudianteCodigo.Text,
                Nombre = txtEstudianteNombre.Text,
                Apellidos = txtEstudianteApellidos.Text,
                Ciclo = (int)numericUpDownEstudianteCiclo.Value,
                Cursos = new()
            };

            //Agregar el objeto estudiante a la lista de estudiantes
            estudiantes.Add(estudiante);

            //Mostrar la lista de estudiantes
            MostrarEstudiantes(estudiantes);

            //Limpiar campos
            txtEstudianteCodigo.Text = "";
            txtEstudianteNombre.Text = "";
            txtEstudianteApellidos.Text = "";
            numericUpDownEstudianteCiclo.Value = 1;
        }

        private void btnEstudianteLimpiar_Click(object sender, EventArgs e)
        {
            MostrarEstudiantes(estudiantes);

            //Limpiar campos
            txtEstudianteCodigo.Text = "";
            txtEstudianteNombre.Text = "";
            txtEstudianteApellidos.Text = "";
            numericUpDownEstudianteCiclo.Value = 1;
        }

        private void MostrarCursos(List<Curso>lst)
        {
            listViewCursos.Items.Clear();

            foreach(Curso c in lst)
            {
                ListViewItem fila = new ListViewItem(c.Codigo);
                fila.SubItems.Add(c.Nombre);
                fila.SubItems.Add(c.Creditos.ToString());
                fila.SubItems.Add(c.Nota.ToString());
                fila.SubItems.Add(c.Estado);

                listViewCursos.Items.Add(fila);
            }
        }

        private void btnCursoRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos ingresados
            if (txtCursoCodigo.Text == "" || txtCursoNombre.Text == "" || txtCursoNota.Text == "" || listViewEstudiantes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un estudiante para poder registrar el curso.");
                return;
            }

            //Validar nota ingresada
            double nota = double.Parse(txtCursoNota.Text);
            if (nota < 0 || nota > 20)
            {
                MessageBox.Show("La nota ingresada está fuera del rango permitido. Por favor, ingrese una nota de 0 - 20");
                return;
            }

            //Buscar el estudiante seleccionado
            String codigoEstudiante = listViewEstudiantes.SelectedItems[0].Text;
            Estudiante? estudianteSeleccionado = estudiantes.Find(estudiante => estudiante.Codigo.Equals(codigoEstudiante));

            if (estudianteSeleccionado == null) return;

            //Validar código curso repetido
            String codigoCurso = txtCursoCodigo.Text;
            bool codigoRepetido = estudianteSeleccionado.Cursos.Exists(curso => curso.Codigo.Equals(codigoCurso));

            if (codigoRepetido)
            {
                MessageBox.Show("Vaya! Parece que el estudiante seleccionado ya se ha registrado en este curso, pruebe con uno diferente.");
                return;
            }

            //Establecer estado del curso
            String estado = "";
            if (nota >= 13) estado = "Aprobado";
            else estado = "Desaprobado";

            //Crear el objeto curso

            Curso curso = new()
            {
                Codigo = codigoCurso,
                Nombre = txtCursoNombre.Text,
                Creditos = (int)numericUpDownCursoCreditos.Value,
                Nota = nota,
                Estado = estado
            };

            //Agregar el curso al estudiante seleccionado
            estudianteSeleccionado.Cursos.Add(curso);

            //Mostrar cursos en el listView
            MostrarCursos(estudianteSeleccionado.Cursos);
        }

        private void btnCursoLimpiar_Click(object sender, EventArgs e)
        {
            listViewCursos.Items.Clear();

            //Limpiar campos
            txtCursoCodigo.Text = "";
            txtCursoNombre.Text = "";
            numericUpDownCursoCreditos.Value = 1;
            txtCursoNota.Text = "";

            txtCodigoEstudianteCursosDesaprobados.Text = "";
        }

        private void listViewEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validar selección
            if (listViewEstudiantes.SelectedItems.Count == 0) return;

            //Obtener estudiante seleccionado
            String codigoEstudiante = listViewEstudiantes.SelectedItems[0].Text;
            Estudiante? estudianteSeleccionado = estudiantes.Find(estudiante => estudiante.Codigo.Equals(codigoEstudiante));

            if (estudianteSeleccionado == null) return;

            //Mostrar cursos del estudiante seleccionado
            MostrarCursos(estudianteSeleccionado.Cursos);
        }

        private void listViewCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validar selección
            if (listViewCursos.SelectedItems.Count == 0) return;

            //Obtener curso seleccionado
            String codigoCurso = listViewCursos.SelectedItems[0].Text;
            List<Estudiante> estudiantesTemp = estudiantes.FindAll(estudiante => estudiante.Cursos.Exists(curso => curso.Codigo.Equals(codigoCurso)));

            if (estudiantesTemp.Count == 0) return;

            //Mostrar estudiantes con el curso seleccionado
            MostrarEstudiantes(estudiantesTemp);
        }

        private void btnEstudiantesAprobadosMejorNota_Click(object sender, EventArgs e)
        {
            if (estudiantes.Count == 0)
            {
                MessageBox.Show("Debe registrar estudiantes para poder realizar la búsqueda.");
                return;
            }

            List<Estudiante> estudiantesTemp = new();
            double maxNota = 0;

            foreach(Estudiante estudiante in estudiantes)
            {
                if (estudiante.Cursos.Count == 0) continue;

                //Buscar el curso aprobado con la máxima nota
                double maxNotaCurso = 0;
                foreach(Curso c in estudiante.Cursos)
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
                }else if (maxNotaCurso == maxNota && maxNotaCurso != 0)
                {
                    estudiantesTemp.Add(estudiante);
                }
            }

            if (estudiantesTemp.Count == 0)
            {
                MessageBox.Show("Lo sentimos, no se han encontrado estudiantes con cursos aprobados o aún no se han registrado los cursos.");
                return;
            }

            //Mostrar en el listView a los estudiantes con mayor nota
            MostrarEstudiantes(estudiantesTemp);
        }

        private void btnBuscarCursosDesaprobados_Click(object sender, EventArgs e)
        {
            //Validar input
            if (txtCodigoEstudianteCursosDesaprobados.Text == "")
            {
                MessageBox.Show("Por favor, ingrese el código del estudiante a buscar.");
                return;
            }

            if (estudiantes.Count == 0)
            {
                MessageBox.Show("Debe registrar estudiantes para poder realizar la búsqueda.");
                return;
            }

            //Buscar estudiante seleccionado
            String codigoEstudiante = txtCodigoEstudianteCursosDesaprobados.Text;
            Estudiante? estudianteSeleccionado = estudiantes.Find(estudiante => estudiante.Codigo.Equals(codigoEstudiante));

            if (estudianteSeleccionado == null)
            {
                MessageBox.Show("Lo sentimos, no se ha encontrado un estudiante con el código indicado.");
                return;
            }

            List<Curso> cursosTemp = estudianteSeleccionado.Cursos.FindAll(curso => curso.Estado.Equals("Desaprobado"));

            if (cursosTemp.Count == 0)
            {
                MessageBox.Show("El estudiante no tiene cursos desaprobados.");
                return;
            }

            MostrarCursos(cursosTemp);
        }
    }
}
