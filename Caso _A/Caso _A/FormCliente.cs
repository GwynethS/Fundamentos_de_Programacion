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
    public partial class FormCliente : Form
    {
        private String codigo;
        private ClienteReport cR = new ClienteReport();
        public FormCliente(String codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            MostrarClientes(cR.ListarTodo(codigo));
        }
        private void MostrarClientes(List<Cliente>lst)
        {
            listViewClientes.Items.Clear();
            foreach(Cliente c in lst)
            {
                ListViewItem fila = new ListViewItem(c.Dni);
                fila.SubItems.Add(c.Nombre);
                fila.SubItems.Add(c.Email);
                fila.SubItems.Add(c.Movil);
                fila.SubItems.Add(c.Comentarios);
                listViewClientes.Items.Add(fila);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos

            Cliente cliente = new Cliente()
            {
                Nombre = txtNombre.Text,
                Dni = txtDni.Text,
                Email = txtEmail.Text,
                Movil = txtCelular.Text,
                Comentarios = txtComentarios.Text
            };

            if(!cR.Registrar(codigo, cliente))
            {
                MessageBox.Show("El código ya existe.");
                return;
            }

            MostrarClientes(cR.ListarTodo(codigo));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
