using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA2
{
    public partial class Form1 : Form
    {
        Contacto[] contactos = new Contacto[100];
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }
            else
            {
                if(txtTelefono.Text.Length != 9)
                {
                    MessageBox.Show("El número de teléfono debe tener 9 dígitos.");
                    return;
                }
            }

            //Crear el objeto
            Contacto contacto = new Contacto();
            contacto.Nombre = txtNombre.Text;
            contacto.Apellidos = txtApellido.Text;
            contacto.Telefono = txtTelefono.Text;

            contactos[cont] = contacto;
            cont++;

            LimpiarFormulario();
        }

        private void mostrar(Contacto[] arr, int cantidad)
        {
            listViewContactos.Items.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                ListViewItem fila = new ListViewItem(arr[i].Nombre);
                fila.SubItems.Add(arr[i].Apellidos);
                fila.SubItems.Add(arr[i].Telefono);
                listViewContactos.Items.Add(fila);
            }

            txtBuscar.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                MessageBox.Show("Por favor, agregue al menos 1 contacto a su lista");
                return;
            }

            mostrar(contactos, cont);
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private class ComparacionAscendente : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                String nombre1 = ((Contacto)x).Nombre;
                String nombre2 = ((Contacto)y).Nombre;
                String apellido1 = ((Contacto)x).Apellidos;
                String apellido2 = ((Contacto)y).Apellidos;

                int resultadoNombre = String.Compare(nombre1, nombre2);

                if (resultadoNombre == 0) // Si los nombres son iguales
                {
                    return String.Compare(apellido1, apellido2);
                }
                else
                {
                    return resultadoNombre;
                }
            }
        }

        private class ComparacionDescendente : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                String nombre1 = ((Contacto)x).Nombre;
                String nombre2 = ((Contacto)y).Nombre;
                String apellido1 = ((Contacto)x).Apellidos;
                String apellido2 = ((Contacto)y).Apellidos;

                int resultadoNombre = String.Compare(nombre2, nombre1);

                if (resultadoNombre == 0) // Si los nombres son iguales
                {
                    return String.Compare(apellido2, apellido1);
                }
                else
                {
                    return resultadoNombre;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Validación
            if(listViewContactos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione el contacto a eliminar.");
                return;
            }

            //Obtener la posición del elemento
            //Lambda: elemento => condición del elemento 
            int pos = Array.FindIndex(contactos, contacto => contacto.Telefono == listViewContactos.SelectedItems[0].SubItems[2].Text);

            //Lógica de eliminación
            for (int i = pos; i < cont; i++)
            {
                contactos[i] = contactos[i + 1];
            }

            cont--;
            mostrar(contactos, cont);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Por favor, inserte un nombre o teléfono a buscar");
                return;
            }

            Contacto[] contactosTemp = Array.FindAll(contactos, contacto => contacto != null && (contacto.Nombre.Contains(txtBuscar.Text) || contacto.Apellidos.Contains(txtBuscar.Text) || contacto.Telefono.Contains(txtBuscar.Text)));

            if (contactosTemp.Length == 0)
            {
                MessageBox.Show("Lo sentimos, la persona que buscas no está en tus contactos");
                return;
            }
            else
            {
                mostrar(contactosTemp, contactosTemp.Length);
            }
        }

        private void cbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                MessageBox.Show("Por favor, agregue al menos 1 contacto a su lista");
                return;
            }
            
            switch (cbOrdenar.SelectedItem.ToString())
            {
                case "Nombre A-Z":
                    Array.Sort(contactos, 0, cont, new ComparacionAscendente());
                    mostrar(contactos, cont);
                    break;
                case "Nombre Z-A":
                    Array.Sort(contactos, 0, cont, new ComparacionDescendente());
                    mostrar(contactos, cont);
                    break;
            }
        }
    }
}
