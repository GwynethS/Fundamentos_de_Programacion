using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB05
{
    public partial class Form1 : Form
    {
        List<Electrodomestico> electrodomesticos = new List<Electrodomestico>(); 

        public void Mostrar(List<Electrodomestico>lista)
        {
            listView1.Items.Clear();
            int stockTotal = 0;

            foreach (Electrodomestico ele in lista)
            {
                ListViewItem fila = new ListViewItem(ele.Codigo);
                fila.SubItems.Add(ele.Nombre);
                fila.SubItems.Add(ele.Stock.ToString());
                fila.SubItems.Add(ele.Precio.ToString());
                
                listView1.Items.Add(fila);

                stockTotal += ele.Stock;
            }

            //Actualizar los totales
            lbTotalRegistros.Text = lista.Count.ToString();
            lbTotalStock.Text = stockTotal.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "" || numUpDownStock.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            //Verificar código repetido
            bool existe = electrodomesticos.Exists(elemento => elemento.Codigo.Equals(txtCodigo.Text));
            if (existe)
            {
                MessageBox.Show("El código ingresado ya existe.");
                return;
            }

            //Crear el objeto
            Electrodomestico elec = new Electrodomestico()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Stock = (int)numUpDownStock.Value,
                Precio = double.Parse(txtPrecio.Text)
            };

            //Agregar a la lista
            electrodomesticos.Add(elec);

            //Mostrar la lista
            Mostrar(electrodomesticos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Validación
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un electrodoméstico");
                return;
            }

            //Obtener el código
            String codigo = listView1.SelectedItems[0].Text;

            //Eliminar al que tiene ese código
            electrodomesticos.RemoveAll(elememento => elememento.Codigo.Equals(codigo));

            //Mostrar en el ListView
            Mostrar(electrodomesticos);
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            electrodomesticos.Clear();

            Mostrar(electrodomesticos);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            electrodomesticos.Sort((e1, e2) => {
                if (e1.Precio < e2.Precio) return 1;
                else return -1;
            });

            Mostrar(electrodomesticos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Mostrar(electrodomesticos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validación
            if(txtBuscar.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un nombre para iniciar la búsqueda");
                return;
            }

            //Buscar el electrodoméstico
            List<Electrodomestico> elecTemp = electrodomesticos.FindAll(elemento => elemento.Nombre.Contains(txtBuscar.Text));

            Mostrar(elecTemp);
        }
    }
}
