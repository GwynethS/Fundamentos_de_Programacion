using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;


namespace Contactos
{
    public partial class MainWindow : Window
    {
        ContactosEntities dbcontexto = null;
        public MainWindow()
        {
            InitializeComponent();
            dbcontexto = new ContactosEntities();
            /*ObjectQuery<persona> datoquery = ((IObjectContextAdapter)dbcontexto).ObjectContext.CreateObjectSet<persona>();*/

            var datoquery = from b in dbcontexto.personas orderby b.nombre select b;

            try
            {
                this.dgDatos.ItemsSource = datoquery.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Ingrese el ID.");
                return;
            }

            String id = txtId.Text;

            int codigo = int.Parse(id);

            var query = from b in dbcontexto.personas
                        where b.id == codigo
                        select b;

            this.dgDatos.ItemsSource = query.ToList();
        }

        private void ActualizarDataGrid()
        {
            this.dgDatos.ItemsSource = new List<persona>();

            var datos = dbcontexto.personas.ToList();

            this.dgDatos.ItemsSource = datos;
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";

            ActualizarDataGrid();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            int ultimoId = dbcontexto.personas.Max(p => p.id);
            int nuevoId = ultimoId + 1;

            persona nuevoRegistro = new persona
            {
                id = nuevoId,
                nombre = txtNombre.Text,
                celular = txtCelular.Text,
                correo = txtCorreo.Text
            };

            dbcontexto.personas.Add(nuevoRegistro);
            dbcontexto.SaveChanges();

            txtId.Text = "";
            txtNombre.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";

            ActualizarDataGrid();
        }
    };
}
