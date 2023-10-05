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
    public partial class FormRuta : Form
    {
        private RutaService rS = new();
        private String matricula;
        public FormRuta(String matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
            MostrarRutas(rS.ListarTodo(matricula));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos
            if (txtCodigo.Text == "" || txtOrigen.Text == "" || txtDestino.Text == "" || txtKilometros.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            Ruta ruta = new()
            {
                Codigo = txtCodigo.Text,
                Origen = txtOrigen.Text,
                Destino = txtDestino.Text,
                Kilometros = double.Parse(txtKilometros.Text)
            };

            if (!rS.Registrar(matricula, ruta))
            {
                MessageBox.Show("El código ya ha sido registrado, pruebe con uno diferente");
                return;
            }

            MostrarRutas(rS.ListarTodo(matricula));
        }
    }
}
