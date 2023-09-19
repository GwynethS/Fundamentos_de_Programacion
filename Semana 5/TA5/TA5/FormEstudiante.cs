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
    public partial class FormEstudiante : Form
    {
        private EstudianteService eS = new();
        public FormEstudiante()
        {
            InitializeComponent();
            Mostrar(eS.ListarTodo());
        }

        private void Mostrar(List<Estudiante>lst)
        {
            listViewEstudiantes.Items.Clear();
            foreach(Estudiante estudiante in lst)
            {
                ListViewItem fila = new(estudiante.Codigo);
                fila.SubItems.Add(estudiante.Nombre);
                fila.SubItems.Add(estudiante.Apellidos);
                fila.SubItems.Add(estudiante.Ciclo.ToString());

                listViewEstudiantes.Items.Add(fila);
            }

            lbTotalEstudiantes.Text = lst.Count.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstudianteRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos ingresados
            if (txtEstudianteCodigo.Text == "" || txtEstudianteNombre.Text == "" || txtEstudianteApellidos.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los datos del estudiante para poder registrarlo.");
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

            //Insertar estudiante
            bool insertado = eS.Insertar(estudiante);

            if(!insertado)
            {
                MessageBox.Show("Vaya! Parece que ya se ha registrado un estudiante con este código, pruebe con uno diferente.");
                return;
            }

            //Mostrar lista
            Mostrar(eS.ListarTodo());
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            if (listViewEstudiantes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un estudiante.");
                return;
            }

            FormCurso frm = new(listViewEstudiantes.SelectedItems[0].Text);
            frm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte frm = new();
            frm.Show();
        }
    }
}
