using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Empleado employee = new Empleado();
            employee.Nombre = txtNombre.Text;
            employee.Categoria = cbCategoria.Text;
            employee.Tardanzas = int.Parse(txtTardanza.Text);
            employee.Llamadas = int.Parse(txtLlamadas.Text);

            switch (employee.Categoria)
            {
                case "A": employee.Pago = 2500;
                    break;
                case "B":
                    employee.Pago = 2000;
                    break;
                case "C":
                    employee.Pago = 1500;
                    break;
                case "D":
                    employee.Pago = 900;
                    break;
            }

            employee.Pago -= (employee.Tardanzas * 5.00 + employee.Llamadas * 10.00);

            if (lbTotal.Text == "") lbTotal.Text = "1";
            else lbTotal.Text = (int.Parse(lbTotal.Text) + 1).ToString();

            ListViewItem fila = new ListViewItem(employee.Nombre);
            fila.SubItems.Add(employee.Categoria);
            fila.SubItems.Add(employee.Tardanzas.ToString());
            fila.SubItems.Add(employee.Llamadas.ToString());
            fila.SubItems.Add(employee.Pago.ToString());

            listView.Items.Add(fila);

            txtNombre.Text = "";
            cbCategoria.Text = "";
            txtTardanza.Text = "";
            txtLlamadas.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            cbCategoria.Text = "";
            txtTardanza.Text = "";
            txtLlamadas.Text = "";
        }
    }
}
