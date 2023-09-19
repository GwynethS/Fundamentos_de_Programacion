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
    public partial class FormReporte : Form
    {
        private EntrenadorService eS = new();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void Mostrar(List<Entrenador>lst)
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

        private void btnBuscarNombrePokemon_Click(object sender, EventArgs e)
        {
            //Validar campos
            if(txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del pokemon");
                return;
            }

            Mostrar(eS.ListarPorPokemon(txtNombre.Text));
        }

        private void btnBuscarRegion_Click(object sender, EventArgs e)
        {
            //Validación de campos
            if(cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese región.");
                return;
            }

            //Mostrar en el listView
            Mostrar(eS.ListarPorRegion(cbRegion.Text));
        }

        private void btnBuscarMenosPokemon_Click(object sender, EventArgs e)
        {
            //Mostrar en el listView
            Mostrar(eS.ListarPorMenosPokemon());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
