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
    public partial class FormPokemon : Form
    {
        private PokemonService pS;
        public FormPokemon(String codigoEntrenador)
        {
            pS = new(codigoEntrenador);
            InitializeComponent();
            Mostrar(pS.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mostrar(List<Pokemon> lst)
        {
            listViewPokemons.Items.Clear();
            int totalPuntosSalud = 0;
            foreach(Pokemon po in lst)
            {
                ListViewItem fila = new(po.Codigo);
                fila.SubItems.Add(po.Nombre);
                fila.SubItems.Add(po.Apodo);
                fila.SubItems.Add(po.Tipo);
                fila.SubItems.Add(po.PuntosSalud.ToString());
                fila.SubItems.Add(po.Legendario.ToString());
                listViewPokemons.Items.Add(fila);

                totalPuntosSalud += po.PuntosSalud;
            }
            lbTotalPokemons.Text = lst.Count.ToString();
            lbTotalPS.Text = totalPuntosSalud.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validación de campos
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtApodo.Text == "" || cbTipo.Text == "" || txtPS.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            //Validar número de pokemons
            if (pS.ListarTodo().Count == 6)
            {
                MessageBox.Show("No se pueden agregar más de 6 pokemons");
                return;
            }

            //Crear el objeto
            Pokemon pokemon = new()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Apodo = txtApodo.Text,
                Tipo = cbTipo.Text,
                PuntosSalud = int.Parse(txtPS.Text),
                Legendario = chBLegendario.Checked
            };

            //Insertar
            bool insertado = pS.Insertar(pokemon);
            
            if (!insertado)
            {
                MessageBox.Show("El código ya existe.");
                return;
            }

            //Actualizar listView
            Mostrar(pS.ListarTodo());
        }
    }
}
