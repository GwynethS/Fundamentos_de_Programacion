using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA5.Entities;
using TA5.Services;

namespace TA5
{
    public partial class FormReporte : Form
    {
        private EstudianteService eS = new();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarEstudiantes(List<Estudiante> lst)
        {
            listViewEstudiantes.Items.Clear();
            foreach (Estudiante estudiante in lst)
            {
                ListViewItem fila = new(estudiante.Codigo);
                fila.SubItems.Add(estudiante.Nombre);
                fila.SubItems.Add(estudiante.Apellidos);
                fila.SubItems.Add(estudiante.Ciclo.ToString());

                listViewEstudiantes.Items.Add(fila);
            }

            lbTotalEstudiantes.Text = lst.Count.ToString();
        }

        private void btnBuscarEstudiantesPorCodigoCurso_Click(object sender, EventArgs e)
        {
            //Validar campos
            if (txtCodigoCurso.Text == "")
            {
                MessageBox.Show("Por favor, ingrese el código del curso.");
                return;
            }

            MostrarEstudiantes(eS.ListarPorCodigoCurso(txtCodigoCurso.Text));
        }

        private void btnBuscarEstudiantesPorCiclo_Click(object sender, EventArgs e)
        {
            MostrarEstudiantes(eS.ListarPorCiclo((int)numericUpDownEstudianteCiclo.Value));
        }

        private void btnEstudiantesAprobadosMejorNota_Click(object sender, EventArgs e)
        {
            MostrarEstudiantes(eS.ListarEstudiantesAprobadosNotaMasAlta());
        }

        private void MostrarCursos(List<Curso> lst)
        {
            listViewCursos.Items.Clear();

            foreach (Curso c in lst)
            {
                ListViewItem fila = new ListViewItem(c.Codigo);
                fila.SubItems.Add(c.Nombre);
                fila.SubItems.Add(c.Creditos.ToString());
                fila.SubItems.Add(c.Nota.ToString());
                fila.SubItems.Add(c.Estado);

                listViewCursos.Items.Add(fila);
            }
            lbTotalCursos.Text = lst.Count.ToString();
        }

        private void btnBuscarCursosDesaprobados_Click(object sender, EventArgs e)
        {
            //Validar campos
            if (txtCodigoEstudianteCursosDesaprobados.Text == "")
            {
                MessageBox.Show("Por favor, ingrese el código de estudiante.");
                return;
            }
            CursoService cS = new(txtCodigoEstudianteCursosDesaprobados.Text);

            MostrarCursos(cS.ListarCursosDesaprobados());
        }
    }
}
