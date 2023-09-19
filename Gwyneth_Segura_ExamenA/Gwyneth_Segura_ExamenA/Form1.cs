namespace Gwyneth_Segura_ExamenA
{
    public partial class Form1 : Form
    {
        List<ActividadDeportiva> actividades = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarActividades(List<ActividadDeportiva> lst)
        {
            listViewActividad.Items.Clear();

            foreach (ActividadDeportiva a in lst)
            {
                ListViewItem fila = new(a.Codigo);
                fila.SubItems.Add(a.Nombre);
                fila.SubItems.Add(a.Horario);
                fila.SubItems.Add(a.Capacidad.ToString());

                listViewActividad.Items.Add(fila);
            }
        }

        private void btnActividadRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos ingresados
            if (txtActividadCodigo.Text == "" || txtActividadNombre.Text == "" || maskedTextBoxFiltrarHorario.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos para registrar la actividad.");
                return;
            }

            //Validar código de actividaed

            bool codigoRepetido = actividades.Exists(a => a.Codigo.Equals(txtActividadCodigo.Text));

            if (codigoRepetido)
            {
                MessageBox.Show("Este código ya ha sido registrado, pruebe con uno diferente.");
                return;
            }

            //Crear objeto
            ActividadDeportiva actividad = new()
            {
                Codigo = txtActividadCodigo.Text,
                Nombre = txtActividadNombre.Text,
                Horario = maskedTextBoxActividadHorario.Text.ToString(),
                Capacidad = (int)numericUpDownActividadCapacidad.Value,
                Miembros = new()
            };

            actividades.Add(actividad);

            MostrarActividades(actividades);
        }

        private void MostrarMiembros(List<Miembro> lst)
        {
            listViewMiembro.Items.Clear();

            foreach (Miembro m in lst)
            {
                ListViewItem fila = new(m.Codigo);
                fila.SubItems.Add(m.Nombre);
                fila.SubItems.Add(m.Edad.ToString());
                fila.SubItems.Add(m.Genero);

                listViewMiembro.Items.Add(fila);
            }
        }

        private void btnMiembroRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos ingresados
            if (txtMiembroCodigo.Text == "" || txtMiembroNombre.Text == "" || cbMiembroGenero.Text == "" || listViewActividad.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione una actividad para registrar a un miembro.");
                return;
            }

            //Validar código repetido

            foreach (ActividadDeportiva a in actividades)
            {
                bool repetido = a.Miembros.Exists(m => m.Codigo.Equals(txtMiembroCodigo.Text));

                if (repetido)
                {
                    MessageBox.Show("Lo sentimos, ya hay un miembro registrado con este código, pruebe con uno diferente.");
                    return;
                }
            }

            ActividadDeportiva? actividadSeleccionada = actividades.Find(a => a.Codigo.Equals(listViewActividad.SelectedItems[0].Text));

            if (actividadSeleccionada != null)
            {
                if (actividadSeleccionada.Miembros.Count < actividadSeleccionada.Capacidad)
                {
                    Miembro miembro = new()
                    {
                        Codigo = txtMiembroCodigo.Text,
                        Nombre = txtMiembroNombre.Text,
                        Edad = (int)numericUpDownMiembroEdad.Value,
                        Genero = cbMiembroGenero.Text
                    };

                    actividadSeleccionada.Miembros.Add(miembro);
                    MostrarMiembros(actividadSeleccionada.Miembros);
                }
                else
                {
                    MessageBox.Show("Esta actividad ha alcanzado su capacidad máxima.");
                    return;
                }
            }
        }

        private void listViewActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewActividad.SelectedItems.Count == 0)
            {
                return;
            }

            ActividadDeportiva? actividadSeleccionada = actividades.Find(a => a.Codigo.Equals(listViewActividad.SelectedItems[0].Text));

            if (actividadSeleccionada != null)
            {
                MostrarMiembros(actividadSeleccionada.Miembros);
            }
        }

        private void btnFiltrarActividadPorHorario_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxFiltrarHorario.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un horario");
                return;
            }

            List<ActividadDeportiva> actividadesTemp = new();

            foreach (ActividadDeportiva a in actividades)
            {
                bool existe = a.Horario.Equals(maskedTextBoxFiltrarHorario.Text);

                if (existe)
                {
                    actividadesTemp.Add(a);
                }
            }

            if (actividadesTemp.Count == 0)
            {
                MessageBox.Show("Lo sentimos, no se ha encontrado una actividad en este horario.");
                return;
            }

            MostrarActividades(actividadesTemp);
        }

        private void btnFiltrarMiembrosPorGenero_Click(object sender, EventArgs e)
        {
            if (cbFiltrarGenero.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un genero");
                return;
            }

            if (listViewActividad.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una actividad");
                return;
            }

            ActividadDeportiva? actividadSeleccionada = actividades.Find(a => a.Codigo.Equals(listViewActividad.SelectedItems[0].Text));

            if (actividadSeleccionada != null)
            {
                List<Miembro> miembrosTemp = actividadSeleccionada.Miembros.FindAll(m => m.Genero.Equals(cbFiltrarGenero.Text));

                if (miembrosTemp.Count == 0)
                {
                    MessageBox.Show("Lo sentimos, ningún miembro pertenece al género seleccionado.");
                    return;
                }

                MostrarMiembros(miembrosTemp);
            }
        }

        private void btnActividadLimpiar_Click(object sender, EventArgs e)
        {
            MostrarActividades(actividades);
        }

        private void btnMiembroLimpiar_Click(object sender, EventArgs e)
        {
            listViewMiembro.Items.Clear();
        }
    }
}