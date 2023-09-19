using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MoreLinq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB08.Modelos;

namespace LAB08
{
    public partial class Form1 : Form
    {
        List<Agencia> agencias = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAgencias(List<Agencia>lst)
        {
            listViewAgencia.Items.Clear();

            foreach(Agencia a in lst)
            {
                ListViewItem fila = new(a.Codigo);
                fila.SubItems.Add(a.Direccion);
                fila.SubItems.Add(a.Ciudad);
                fila.SubItems.Add(a.Telefono);

                listViewAgencia.Items.Add(fila);
            }
        }

        private void btnAgenciaAgregar_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtAgenciaCodigo.Text == "" || txtAgenciaDireccion.Text == "" || txtAgenciaCiudad.Text == "" || txtAgenciaTelefono.Text == "")
            {
                MessageBox.Show("Por favor, ingrese todos los campos.");
                return;
            }

            //Validar código repetido
            bool codigoRepetido = agencias.Exists(a => a.Codigo.Equals(txtAgenciaCodigo.Text));
            if (codigoRepetido)
            {
                MessageBox.Show("El código de esta agencia ya existe.");
                return;
            }

            //Crear el objeto
            Agencia agencia = new()
            {
                Codigo = txtAgenciaCodigo.Text,
                Direccion = txtAgenciaDireccion.Text,
                Ciudad = txtAgenciaCiudad.Text,
                Telefono = txtAgenciaTelefono.Text,
                Inmuebles = new()
            };

            //Agregar a la lista
            agencias.Add(agencia);

            MostrarAgencias(agencias);
        }

        private void btnAgenciaLimpiar_Click(object sender, EventArgs e)
        {
            MostrarAgencias(agencias);
            txtAgenciaCodigo.Text = "";
            txtAgenciaCiudad.Text = "";
            txtAgenciaDireccion.Text = "";
            txtAgenciaTelefono.Text = "";
        }

        private void MostrarInmuebles(List<Inmueble>lst)
        {
            listViewInmueble.Items.Clear();
            double montoTotalAlquiler = 0;
            foreach(Inmueble i in lst)
            {
                if (i.Condicion.Equals("Alquiler"))
                {
                    montoTotalAlquiler += i.Precio;
                }

                ListViewItem fila = new ListViewItem(i.Codigo);
                fila.SubItems.Add(i.Direccion);
                fila.SubItems.Add(i.Superficie.ToString());
                fila.SubItems.Add(i.Precio.ToString());
                fila.SubItems.Add(i.Condicion);

                listViewInmueble.Items.Add(fila);
            }

            lbTotalAlquiler.Text = "S/. " + montoTotalAlquiler;
        }

        private void btnInmuebleAgregar_Click(object sender, EventArgs e)
        {
            //Validar agencia seleccionada
            if (listViewAgencia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una agencia.");
                return;
            }

            //Validación de campos
            if (txtInmuebleCodigo.Text == "" || txtInmuebleDireccion.Text == "" || txtInmuebleSuperficie.Text == "" || txtInmueblePrecio.Text == "" || cbInmuebleCondicion.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            //Validar código
            String codigoInmueble = txtInmuebleCodigo.Text;

            bool codigoRepetido = agencias.Exists(a => a.Inmuebles.Exists(i => i.Codigo == codigoInmueble));

            if (codigoRepetido)
            {
                MessageBox.Show("Este código ya se encuenta registrado en otra agencia.");
            }

            //Buscar agencia seleccionada

            String codigoAgencia = listViewAgencia.SelectedItems[0].Text;
            Agencia? agenciaSeleccionada = agencias.Find(a => a.Codigo.Equals(codigoAgencia));

            if (agenciaSeleccionada == null) return;

            //Crear el objeto
            Inmueble inmueble = new()
            {
                Codigo = txtInmuebleCodigo.Text,
                Direccion = txtInmuebleDireccion.Text,
                Superficie = double.Parse(txtInmuebleSuperficie.Text),
                Precio = double.Parse(txtInmueblePrecio.Text),
                Condicion = cbInmuebleCondicion.Text
            };

            //Agregar a la agencia seleccionada
            agenciaSeleccionada.Inmuebles.Add(inmueble);

            //Mostrar en el listView
            MostrarInmuebles(agenciaSeleccionada.Inmuebles);
        }

        private void btnInmuebleLimpiar_Click(object sender, EventArgs e)
        {
            listViewInmueble.Items.Clear();

            txtInmuebleCodigo.Text = "";
            txtInmuebleDireccion.Text = "";
            txtInmuebleSuperficie.Text = "";
            txtInmueblePrecio.Text = "";
            cbInmuebleCondicion.SelectedIndex = -1;

            lbTotalAlquiler.Text = "S/. 0";
        }

        private void listViewAgencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validar seleccionado
            if (listViewAgencia.SelectedItems.Count == 0)
            {
                return;
            }

            //Código de la agencia
            String codigoAgencia = listViewAgencia.SelectedItems[0].Text;
            Agencia? agenciaSeleccionada = agencias.Find(a => a.Codigo.Equals(codigoAgencia));

            if (agenciaSeleccionada == null) return;

            //Mostrar inmuebles de la agencia seleccionada
            MostrarInmuebles(agenciaSeleccionada.Inmuebles);
        }

        private void btnAgenciaAlquilerInmuebleMaxSuperficie_Click(object sender, EventArgs e)
        {
            List<Agencia> agenciasTemp = new();

            double maxSuperficie = 0;

            foreach(Agencia a in agencias)
            {
                if (a.Inmuebles.Count == 0) return;
                Inmueble? inmuebleMaxSuperficie = a.Inmuebles.MaxBy(i => i.Superficie).First();

                if(inmuebleMaxSuperficie != null)
                {
                    if(inmuebleMaxSuperficie.Superficie > maxSuperficie)
                    {
                        maxSuperficie = inmuebleMaxSuperficie.Superficie;
                        agenciasTemp.Clear();
                        agenciasTemp.Add(a);
                    }
                    else if (inmuebleMaxSuperficie.Superficie == maxSuperficie)
                    {
                        agenciasTemp.Add(a);
                    }
                }
            }

            //Mostrar en el listView
            MostrarAgencias(agenciasTemp);
        }

        private void btnAgenciaMayorInmueblesVenta_Click(object sender, EventArgs e)
        {
            List<Agencia> agenciasTemp = new();

            int maxVenta = 0;

            foreach (Agencia a in agencias)
            {
                int inmueblesVenta = a.Inmuebles.FindAll(i => i.Condicion.Equals("Venta")).Count;

                if (inmueblesVenta > maxVenta)
                {
                    maxVenta = inmueblesVenta;
                    agenciasTemp.Clear();
                    agenciasTemp.Add(a);
                }
                else if (inmueblesVenta == maxVenta)
                {
                    agenciasTemp.Add(a);
                }
            }

            //Mostrar en el listView
            MostrarAgencias(agenciasTemp);
        }

        private void btnInmuebleBuscar_Click(object sender, EventArgs e)
        {
            //Validar el input
            if(txtInmuebleBuscarAgencia.Text == "")
            {
                MessageBox.Show("Ingrese el código de la agencia a buscar.");
                return;
            }

            //Buscar la agencia seleccionada
            Agencia? agenciaSeleccionada = agencias.Find(a => a.Codigo.Equals(txtInmuebleBuscarAgencia.Text));

            if(agenciaSeleccionada == null)
            {
                MessageBox.Show("Lo sentimos, parece que no hay una agencia registrada con este código.");
                return;
            }

            List<Inmueble>? inmueblesTemp = agenciaSeleccionada.Inmuebles.FindAll(i => i.Condicion.Equals("Venta"));

            if (inmueblesTemp == null)
            {
                MessageBox.Show("No hay inmuebles en venta para esta agencia.");
                return;
            }

            MostrarInmuebles(inmueblesTemp);
        }
    }
}
