using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Album
{
    public partial class Form1 : Form
    {
        List<Album> albumes = new List<Album>();
        public Form1()
        {
            InitializeComponent();
        }

        public void MostrarAlbumes(List<Album>lst)
        {
            listViewAlbum.Items.Clear();

            foreach(Album a in lst)
            {
                ListViewItem fila = new ListViewItem(a.Codigo);
                fila.SubItems.Add(a.Nombre);

                listViewAlbum.Items.Add(fila);
            }
        }

        public void MostrarHeroe(List<Heroe> lst)
        {
            listViewHeroe.Items.Clear();

            foreach (Heroe h in lst)
            {
                ListViewItem fila = new ListViewItem(h.Codigo);
                fila.SubItems.Add(h.Nombre);
                fila.SubItems.Add(h.Caracteristicas);
                fila.SubItems.Add(h.Poder.ToString());

                listViewHeroe.Items.Add(fila);
            }
        }

        public void LimpiarAlbumes()
        {
            txtACodigo.Text = "";
            txtANombre.Text = "";
        }

        public void LimpiarHeroes()
        {
            txtHCodigo.Text = "";
            txtHNombre.Text = "";
            txtHCaracteristicas.Text = "";
            cbHPoder.SelectedIndex = -1;
        }

        private void btnARegistrar_Click(object sender, EventArgs e)
        {
            if (txtACodigo.Text == "" || txtANombre.Text == "")
            {
                MessageBox.Show("Por favor, ingrese el nombre y el código del album a registrar.");
                return;
            }

            if (albumes.Exists(element => element.Codigo.Equals(txtACodigo.Text)))
            {
                MessageBox.Show("Vaya! Parece que este código ya se encuentra registrado. Por favor, ingrese uno nuevo.");
                return;
            }

            Album album = new Album
            {
                Codigo = txtACodigo.Text,
                Nombre = txtANombre.Text
            };

            albumes.Add(album);

            MostrarAlbumes(albumes);
            LimpiarAlbumes();
        }

        private void btnHRegistrar_Click(object sender, EventArgs e)
        {
            if (txtHCodigo.Text== "" || txtHNombre.Text == "" || txtHCaracteristicas.Text == "" || cbHPoder.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos del héroe antes de registrarlo");
                return;
            }

            if (listViewAlbum.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un album al que desea agregar al héroe.");
                return;
            }

            int albumPos = albumes.FindIndex(element => element.Codigo.Equals(listViewAlbum.SelectedItems[0].Text));

            if (albumes[albumPos].heroes != null)
            {
                if (albumes[albumPos].heroes.Exists(element => element.Codigo.Equals(txtHCodigo.Text)))
                {
                    MessageBox.Show("Este héroe ya se encuentra registrado en el album.");
                    return;
                }
            }        

            Heroe heroe = new Heroe
            {
                Codigo = txtHCodigo.Text,
                Nombre = txtHNombre.Text,
                Caracteristicas = txtHCaracteristicas.Text,
                Poder = int.Parse(cbHPoder.Text)
            };

            albumes[albumPos].heroes.Add(heroe);
            MostrarHeroe(albumes[albumPos].heroes);
        }
    }
}
