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
    public partial class FormReporte : Form
    {
        private BusService bS = new();
        private RutaService rS = new();
        public FormReporte()
        {
            InitializeComponent();
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

        private void MostrarRutas(List<Ruta> lst)
        {
            listViewRutas.Items.Clear();
            foreach (Ruta ruta in lst)
            {
                ListViewItem fila = new(ruta.Codigo);
                fila.SubItems.Add(ruta.Origen);
                fila.SubItems.Add(ruta.Destino);
                fila.SubItems.Add(ruta.Kilometros.ToString());
                listViewRutas.Items.Add(fila);
            }
        }

        private void btnBusesRutaMasLarga_Click(object sender, EventArgs e)
        {
            MostrarBuses(bS.ListarBusesConRutasMasLargas());
        }

        private void btnBusesMenosRutas_Click(object sender, EventArgs e)
        {
            MostrarBuses(bS.ListarBusesConMenosRutas());
        }

        private void btnRutasPorConductor_Click(object sender, EventArgs e)
        {
            if (txtConductor.Text == "")
            {
                MessageBox.Show("Ingrese un conductor");
                return;
            }

            MostrarRutas(rS.ListarRutasPorConductor(txtConductor.Text));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
