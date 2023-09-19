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
    public partial class FormCurso : Form
    {
        private CursoService cS; 
        public FormCurso(String codigoEstudiante)
        {
            cS = new(codigoEstudiante);
            InitializeComponent();
            Mostrar(cS.ListarTodo());
        }

        private void Mostrar(List<Curso> lst)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCursoRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos ingresados
            if (txtCursoCodigo.Text == "" || txtCursoNombre.Text == "" || txtCursoNota.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            //Validar nota ingresada
            double nota = double.Parse(txtCursoNota.Text);
            if (nota < 0 || nota > 20)
            {
                MessageBox.Show("La nota ingresada está fuera del rango permitido. Por favor, ingrese una nota de 0 - 20");
                return;
            }

            //Establecer estado del curso
            String estado = "";
            if (nota >= 13) estado = "Aprobado";
            else estado = "Desaprobado";

            //Crear el objeto
            Curso curso = new()
            {
                Codigo = txtCursoCodigo.Text,
                Nombre = txtCursoNombre.Text,
                Creditos = (int)numericUpDownCursoCreditos.Value,
                Nota = nota,
                Estado = estado
            };

            //Insertar el objeto
            bool insertado = cS.Insertar(curso);

            if(!insertado)
            {
                MessageBox.Show("Vaya! Parece que el estudiante seleccionado ya se ha registrado en este curso, pruebe con uno diferente.");
                return;
            }

            Mostrar(cS.ListarTodo());
        }
    }
}
