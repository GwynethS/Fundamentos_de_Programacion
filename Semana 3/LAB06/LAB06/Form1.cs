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

namespace LAB06
{
    public partial class Form1 : Form
    {
        List<Album> Albumes = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlbumes(List<Album>lst)
        {
            listViewAlbum.Items.Clear();

            foreach(Album a in lst)
            {
                ListViewItem fila = new ListViewItem(a.Codigo);
                fila.SubItems.Add(a.Nombre);

                listViewAlbum.Items.Add(fila);
            }
        }

        private void AlbumMasHeroes(List<Album>lst)
        {
            Album? maxHeroes = lst.MaxBy(element => element.Heroes.Count).First();

            if(maxHeroes != null && maxHeroes.Heroes.Count != 0)
            {
                lbAlbumMaxHeroes.Text = maxHeroes.Nombre;
            }
        }

        private void btnAlbumRegistrar_Click(object sender, EventArgs e)
        {
            //Validacion
            if (txtAlbumCodigo.Text == "" || txtAlbumNombre.Text == "")
            {
                MessageBox.Show("Por favor, ingrese el código y nombre del álbum.");
                return;
            }

            //Codigo repetido
            bool codigoRepetido = Albumes.Exists(element => element.Codigo.Equals(txtAlbumCodigo.Text));

            if (codigoRepetido)
            {
                MessageBox.Show("Vaya! Parece que este código ya ha sido usado, prueba con uno diferente.");
                return;
            }

            //Crear el objeto album
            Album album = new()
            {
                Codigo = txtAlbumCodigo.Text,
                Nombre = txtAlbumNombre.Text,
                Heroes = new()
            };

            //Agregar objeto a la lista
            Albumes.Add(album);

            //Agregar al listView
            MostrarAlbumes(Albumes);

            //Mostrar max héroes
            AlbumMasHeroes(Albumes);

            //Limpiar textBox
            txtAlbumCodigo.Text = "";
            txtAlbumNombre.Text = "";
        }

        private void btnAlbumLimpiar_Click(object sender, EventArgs e)
        {
            MostrarAlbumes(Albumes);
            AlbumMasHeroes(Albumes);
        }

        private void MostrarHeroes(List<Heroe>lst)
        {
            listViewHeroe.Items.Clear();

            foreach(Heroe h in lst)
            {
                ListViewItem fila = new ListViewItem(h.Codigo);
                fila.SubItems.Add(h.Nombre);
                fila.SubItems.Add(h.Caracteristicas);
                fila.SubItems.Add(h.Poder.ToString());

                listViewHeroe.Items.Add(fila);
            }
        }

        private void HeroeMayorMenorPoder(List<Heroe> lst)
        {
            lbHeroeMax.Text = "";
            lbHeroeMin.Text = "";

            if (lst.Count == 0) return;
            Heroe? mayorPoder = lst.MaxBy(elemento => elemento.Poder).First();
            Heroe? menorPoder = lst.MinBy(elemento => elemento.Poder).First();
            if (mayorPoder != null) lbHeroeMax.Text = mayorPoder.Nombre;
            if (menorPoder != null) lbHeroeMin.Text = menorPoder.Nombre;
        }

        private void btnHeroeRegistrar_Click(object sender, EventArgs e)
        {
            //Validacion
            if (txtHeroeCodigo.Text == "" || txtHeroeNombre.Text == "" || txtHeroeCaracteristica.Text == "" || txtHeroePoder.Text == "" || listViewAlbum.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos y recuerde seleccionar el album a registrar");
                return;
            }

            //Buscar album seleccionado
            String albumCodigo = listViewAlbum.SelectedItems[0].Text;
            Album? albumSeleccionado = Albumes.Find(elemento => elemento.Codigo.Equals(albumCodigo));

            if (albumSeleccionado == null) return;

            //Heroe repetido
            List<Heroe> heroes = albumSeleccionado.Heroes;

            bool heroeRepetido = heroes.Exists(element => element.Codigo.Equals(txtHeroeCodigo.Text));

            if (heroeRepetido)
            {
                MessageBox.Show("Vaya! Parece que este héroe ya se ha registrado en el album seleccionado, prueba con uno diferente.");
                return;
            }

            //Crear el objeto album
            Heroe heroe = new()
            {
                Codigo = txtHeroeCodigo.Text,
                Nombre = txtHeroeNombre.Text,
                Caracteristicas = txtHeroeCaracteristica.Text,
                Poder = float.Parse(txtHeroePoder.Text)
            };

            //Agregar objeto a la lista
            albumSeleccionado.Heroes.Add(heroe);

            //Agregar al listView
            MostrarHeroes(albumSeleccionado.Heroes);

            HeroeMayorMenorPoder(albumSeleccionado.Heroes);

            AlbumMasHeroes(Albumes);
        }
        private void btnHeroeLimpiar_Click(object sender, EventArgs e)
        {
            listViewHeroe.Items.Clear();
            lbHeroeMax.Text = "";
            lbHeroeMin.Text = "";

            //Limpiar textBox
            txtHeroeCodigo.Text = "";
            txtHeroeNombre.Text = "";
            txtHeroeCaracteristica.Text = "";
            txtHeroePoder.Text = "";
        }

        private void listViewAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validación
            if (listViewAlbum.SelectedItems.Count == 0) return;

            //Buscar el album
            String albumCodigo = listViewAlbum.SelectedItems[0].Text;
            Album? albumSelecionado = Albumes.Find(elemento => elemento.Codigo.Equals(albumCodigo));

            if (albumSelecionado == null) return;

            //Mostrar los héroes

            MostrarHeroes(albumSelecionado.Heroes);
            HeroeMayorMenorPoder(albumSelecionado.Heroes);
        }

        private void listViewHeroe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validación
            if (listViewHeroe.SelectedItems.Count == 0) return;

            //Buscar los albumes
            String heroeCodigo = listViewHeroe.SelectedItems[0].Text;

            List<Album>? albumesEncontrados = Albumes.FindAll(elemento => elemento.Heroes.Exists(h => h.Codigo.Equals(heroeCodigo)));

            if (albumesEncontrados == null) return;

            //Mostrar los héroes

            MostrarAlbumes(albumesEncontrados);
            AlbumMasHeroes(albumesEncontrados);
        }
    }
}
