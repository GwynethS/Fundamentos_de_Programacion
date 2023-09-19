using LAB09.Entities;
using LAB09.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB09
{
    public partial class FormEntrenador : Form
    {
        private EntrenadorService eS = new();
        public FormEntrenador()
        {
            InitializeComponent();
            Mostrar(eS.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new();
            form.Show();
        }
        private void Mostrar(List<Entrenador> lst)
        {
            listViewEntrenadores.Items.Clear();
            foreach(Entrenador en in lst)
            {
                ListViewItem fila = new(en.Codigo);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Edad.ToString());
                fila.SubItems.Add(en.Region);
                listViewEntrenadores.Items.Add(fila);
            }
            lbTotalEntrenadores.Text = lst.Count.ToString();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validación de campos
            if (txtCodigo.Text == "" || txtNombre.Text=="" || txtEdad.Text=="" || cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            //Crear el objeto
            Entrenador entrenador = new()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text),
                Region = cbRegion.Text,
                Pokemons = new List<Pokemon>()
            };

            //Insertar
            bool insertado = eS.Insertar(entrenador);

            if (!insertado)
            {
                MessageBox.Show("El código ya existe.");
                return;
            }

            //Mostrar lista
            Mostrar(eS.ListarTodo());
        }

        private void btnVerPokemons_Click(object sender, EventArgs e)
        {
            //Validación de seleccion
            if(listViewEntrenadores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un entrenador");
                return;
            }
            FormPokemon form = new(listViewEntrenadores.SelectedItems[0].Text);
            form.Show();
        }
    }
}
