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
    public partial class FormProyecto : Form
    {
        private ProyectoInmobiliarioReport pR = new ProyectoInmobiliarioReport();
        public FormProyecto()
        {
            InitializeComponent();
            MostrarProyectos(pR.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarProyectos(List<ProyectoInmobiliario>lst)
        {
            listViewProyectos.Items.Clear();
            foreach(ProyectoInmobiliario p in lst)
            {
                ListViewItem fila = new ListViewItem(p.Codigo);
                fila.SubItems.Add(p.NombrePropietario);
                fila.SubItems.Add(p.MovilPropietario);
                fila.SubItems.Add(p.Estado);
                fila.SubItems.Add(p.CantidadHabitaciones.ToString());
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos

            //Crear objeto
            ProyectoInmobiliario proyecto = new ProyectoInmobiliario()
            {
                Codigo = txtCodigo.Text,
                NombrePropietario = txtNombre.Text,
                MovilPropietario = txtCelular.Text,
                Estado = cbEstado.Text,
                CantidadHabitaciones = (int)nUpDownHabitaciones.Value,
                CantidadEstacionamientos = (int)nUpDownEstacionamientos.Value,
                CuentaDeposito = txtCuenta.Text,
                Metraje = double.Parse(txtMetraje.Text),
                Precio = double.Parse(txtPrecio.Text),
                Distrito = cbDistrito.Text,
                Descripcion = txtDescripcion.Text,
                Comentarios = txtComentarios.Text,
                Clientes = new List<Cliente>()
            };

            if(!pR.Registrar(proyecto))
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            MostrarProyectos(pR.ListarTodo());
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            if(listViewProyectos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un código");
                return;
            }

            FormCliente frm = new FormCliente(listViewProyectos.SelectedItems[0].Text);
            frm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte frm = new FormReporte();
            frm.Show();
        }

        private void btnActualizarComentarios_Click(object sender, EventArgs e)
        {
            if (listViewProyectos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un código");
                return;
            }

            pR.ActualizarComentario(listViewProyectos.SelectedItems[0].Text, txtComentarios.Text);
            MostrarProyectos(pR.ListarTodo());
        }
    }
}
