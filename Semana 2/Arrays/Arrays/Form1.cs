using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        Atencion[] atenciones = new Atencion[100];
        int cont = 0;
        int totalLavado = 0;
        int totalEncerado = 0;
        int totalSilicona = 0;
        double montoPromedioLavado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validación
            if (cbVehiculo.Text == "" || cbServicio.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            //Creación de la atención
            Atencion atencion = new Atencion();
            atencion.TipoAuto = cbVehiculo.Text;
            atencion.TipoServicio = cbServicio.Text;

            //Asignación de monto
            switch (atencion.TipoServicio)
            {
                case "Lavado": 
                    atencion.Monto = 10;
                    totalLavado++;
                    break;
                case "Encerado": 
                    atencion.Monto = 15;
                    totalEncerado++;
                    break;
                case "Silicona": 
                    atencion.Monto = 10;
                    totalSilicona++;
                    break;
            }

            if (atencion.TipoAuto == "Camioneta") atencion.Monto *= 1.05;

            //Agregar al arreglo
            atenciones[cont] = atencion;
            cont++;

            cbVehiculo.SelectedIndex = -1;
            cbServicio.SelectedIndex = -1;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                MessageBox.Show("Por favor, registre al menos una atención.");
                return;
            } 

            listView1.Items.Clear();
            montoPromedioLavado = 0;
            for (int i = 0; i < cont; i++)
            {
                ListViewItem fila = new ListViewItem(atenciones[i].TipoAuto);
                fila.SubItems.Add(atenciones[i].TipoServicio);
                fila.SubItems.Add("S/." + atenciones[i].Monto.ToString());
                listView1.Items.Add(fila);
                if (atenciones[i].TipoServicio == "Lavado") montoPromedioLavado += atenciones[i].Monto;
            }

            if (totalLavado != 0) montoPromedioLavado = montoPromedioLavado / totalLavado;
            else montoPromedioLavado = 0;

            montoPromedio.Text = Math.Round(montoPromedioLavado, 2).ToString();
            nLavado.Text = totalLavado.ToString();
            nEncerado.Text = totalEncerado.ToString();
            nSilicona.Text = totalSilicona.ToString();

            int[] totales = { totalLavado, totalSilicona, totalEncerado };
            int min = totales.Min();

            menorDemanda.Text = "";

            if (min == totalLavado) menorDemanda.Text += "Lavado\n";
            if (min == totalEncerado) menorDemanda.Text += "Encerado\n";
            if (min == totalSilicona) menorDemanda.Text += "Silicona\n";
        }
    }
}
