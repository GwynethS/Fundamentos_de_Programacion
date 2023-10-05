using Caso__A.entities;
using Caso__A.reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso__A
{
    public partial class FormReporte : Form
    {
        private ProyectoInmobiliarioReport pR = new ProyectoInmobiliarioReport();
        private ClienteReport cR = new ClienteReport();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarProyectos(List<ProyectoInmobiliario> lst)
        {
            listViewProyectos.Items.Clear();
            foreach (ProyectoInmobiliario p in lst)
            {
                ListViewItem fila = new ListViewItem(p.Codigo);
                fila.SubItems.Add(p.NombrePropietario);
                fila.SubItems.Add(p.MovilPropietario);
                fila.SubItems.Add(p.Estado);
                fila.SubItems.Add(p.CantidadEstacionamientos.ToString());
                fila.SubItems.Add(p.CantidadEstacionamientos.ToString());
                fila.SubItems.Add(p.CuentaDeposito);
                fila.SubItems.Add(p.Metraje.ToString());
                fila.SubItems.Add(p.Precio.ToString());
                fila.SubItems.Add(p.Distrito);
                fila.SubItems.Add(p.Descripcion);
                fila.SubItems.Add(p.Comentarios);
                listViewProyectos.Items.Add(fila);
            }
        }

        private void btnListarProyectosLibres_Click(object sender, EventArgs e)
        {
            if (cbDistrito.Text == "")
            {
                MessageBox.Show("Seleccione un distrito");
                return;
            }

            if (txtMetraje.Text == "" && nUpDownHabitaciones.Value == 0)
            {
                MostrarProyectos(pR.ListarProyectosLibresDistrito(cbDistrito.Text));
            }
            else if(txtMetraje.Text != "" && nUpDownHabitaciones.Value == 0)
            {
                MostrarProyectos(pR.ProyectosLibresMetraje(cbDistrito.Text, double.Parse(txtMetraje.Text)));
            }else if(txtMetraje.Text == "" && nUpDownHabitaciones.Value != 0)
            {
                MostrarProyectos(pR.ProyectosLibresHabitaciones(cbDistrito.Text, (int)nUpDownHabitaciones.Value));
            }else if(txtMetraje.Text != "" && nUpDownHabitaciones.Value != 0)
            {
                MostrarProyectos(pR.ProyectosLibresMetrajeHabitaciones(cbDistrito.Text, double.Parse(txtMetraje.Text), (int)nUpDownHabitaciones.Value));
            }
        }

        private void btnProyectosVendidos_Click(object sender, EventArgs e)
        {
            MostrarProyectos(pR.ListarProyectosVendidos());
            lbSumaPrecios.Text = pR.SumaPrecioProyectosVendidos().ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
