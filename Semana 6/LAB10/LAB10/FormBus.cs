using LAB10.entities;
using LAB10.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB10
{
    public partial class FormBus : Form
    {
        BusService bS = new();
        public FormBus()
        {
            InitializeComponent();
            MostrarBuses(bS.ListarTodo());
        }

        private void MostrarBuses(List<Bus> lst)
        {
            listViewBuses.Items.Clear();
            foreach (Bus bus in lst)
            {
                ListViewItem fila = new(bus.Matricula);
                fila.SubItems.Add(bus.Tipo);
                fila.SubItems.Add(bus.Conductor);
                listViewBuses.Items.Add(fila);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos

            if (txtMatricula.Text == "" || cbTipo.Text == "" || txtConductor.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            Bus bus = new()
            {
                Matricula = txtMatricula.Text,
                Tipo = cbTipo.Text,
                Conductor = txtConductor.Text,
                Rutas = new()
            };

            if (!bS.Registrar(bus))
            {
                MessageBox.Show("La matricula ya se encuentra registrada, pruebe con otra diferente");
                return;
            }

            MostrarBuses(bS.ListarTodo());
        }

        private void btnVerRutas_Click(object sender, EventArgs e)
        {
            if (listViewBuses.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un bus");
                return;
            }

            String matricula = listViewBuses.SelectedItems[0].Text;

            FormRuta frm = new FormRuta(matricula);
            frm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte frm = new();
            frm.Show();
        }
    }
}
