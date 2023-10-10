using LAB11.controller;
using LAB11.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB11
{
    public partial class FormEstacionamiento : Form
    {
        CarroController carroController = new();
        public FormEstacionamiento()
        {
            InitializeComponent();
        }

        void Mostrar(Queue<Carro> qu)
        {
            int contador = 0;
            listViewEstacionamiento.Items.Clear();
            foreach (Carro car in qu)
            {
                ListViewItem fila = new(car.Matricula);
                fila.SubItems.Add(car.Duenio);

                if (contador < 5)
                {
                    fila.BackColor = Color.LightCoral;
                    contador++;
                }
                listViewEstacionamiento.Items.Add(fila);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (carroController.ObtenerCola().Count < 5)
            {
                MessageBox.Show("El carro se agregará al estacionamiento.");
            }
            else
            {
                MessageBox.Show("El carro se agregará a la cola.");
            }

            Carro carro = new()
            {
                Matricula = txtIngresoMatricula.Text,
                Duenio = txtIngresoDuenio.Text
            };

            carroController.Ingresar(carro);

            Mostrar(carroController.ObtenerCola());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            String matricula = txtSalidaMatricula.Text;

            int movimientos = carroController.Salir(matricula);

            MessageBox.Show("Se realizaron " + movimientos + " movimientos");

            Mostrar(carroController.ObtenerCola());
        }
    }
}
