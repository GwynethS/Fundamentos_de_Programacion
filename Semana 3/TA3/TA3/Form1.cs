using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TA3
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        int totalEmpleados = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void MostrarRegistro(List<Empleado> lst)
        {
            listViewEmpleados.Items.Clear();
            foreach (Empleado e in lst)
            {
                ListViewItem fila = new ListViewItem(e.Codigo);
                fila.SubItems.Add(e.Nombre);
                fila.SubItems.Add(e.Apellidos);
                fila.SubItems.Add(e.Departamento);
                fila.SubItems.Add("S/. " + e.Salario.ToString());

                listViewEmpleados.Items.Add(fila);
            }
        }

        public void LimpiarRegistro()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            cbDepartamento.SelectedIndex = -1;
            txtSalario.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "" || cbDepartamento.Text == "" || txtSalario.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }

            //Validar código de empleado
            bool exist = empleados.Exists(emp => emp.Codigo == txtCodigo.Text);

            if (exist)
            {
                MessageBox.Show("Ya se ha registrado un empleado con este código, pruebe ingresar uno diferente.");
                return;
            }

            //Crear el objeto empleado
            Empleado empleado = new Empleado()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Departamento = cbDepartamento.SelectedItem.ToString(),
                Salario = double.Parse(txtSalario.Text)
            };

            empleados.Add(empleado); //Agregar el objeto a la lista
            totalEmpleados = empleados.Count();

            MostrarRegistro(empleados);
            lbTotalEmpleados.Text = totalEmpleados.ToString();
            LimpiarRegistro();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarRegistro();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Por favor, inserte un código, nombre o departamento a buscar");
                return;
            }

            List<Empleado>empleadosTemp  = empleados.FindAll(emp => emp.Codigo.Contains(txtBuscar.Text) || emp.Nombre.Contains(txtBuscar.Text) || emp.Apellidos.Contains(txtBuscar.Text) || emp.Departamento.Contains(txtBuscar.Text));

            if (empleadosTemp.Count == 0)
            {
                MessageBox.Show("Lo sentimos, la persona que busca no ha sido registrada aún.");
                lbResultadosBusqueda.Text = "No se encontraron coincidencias.";
                listViewEmpleados.Items.Clear();
                return;
            }

            MostrarRegistro(empleadosTemp);
            if (empleadosTemp.Count == 1) lbResultadosBusqueda.Text = "Se encontró " + empleadosTemp.Count + " coincidencia";
            else lbResultadosBusqueda.Text = "Se encontraron " + empleadosTemp.Count + " coincidencias";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            lbResultadosBusqueda.Text = "";
            MostrarRegistro(empleados);
        }

        private void cbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleados.Count == 0)
            {
                MessageBox.Show("Por favor, registre al menos 1 empleado.");
                return;
            }

            switch (cbOrdenar.SelectedItem.ToString())
            {
                case "Codigo":
                    empleados.Sort((e1, e2) =>
                    {
                        return String.Compare(e1.Codigo, e2.Codigo);
                    });
                    break;
                case "Nombre":
                    empleados.Sort((e1, e2) =>
                    {
                        int resultNombre = String.Compare(e1.Nombre, e2.Nombre);
                        if (resultNombre == 0)
                        {
                            int resultApellido = String.Compare(e1.Apellidos, e2.Apellidos);
                            if (resultApellido == 0) return String.Compare(e1.Codigo, e2.Codigo);
                            else return resultApellido;
                        }
                        else return resultNombre;
                    });
                    break;
                case "Departamento":
                    empleados.Sort((e1, e2) =>
                    {
                        int resultDepartamento = String.Compare(e1.Departamento, e2.Departamento);
                        if (resultDepartamento == 0)
                        {
                            return String.Compare(e1.Codigo, e2.Codigo);
                        }
                        else return resultDepartamento;
                    });
                    break;
                case "Salario":
                    empleados.Sort((e1, e2) =>
                    {
                        if (e1.Salario < e2.Salario) return 1;
                        else if (e1.Salario == e2.Salario) return String.Compare(e1.Codigo, e2.Codigo);
                        else return -1;
                    });
                    break;
            }

            MostrarRegistro(empleados);
            
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            //Validar selección
            if (listViewEmpleados.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro");
                return;
            }

            String codigo = listViewEmpleados.SelectedItems[0].Text;

            empleados.RemoveAll(emp => emp.Codigo.Equals(codigo));

            MostrarRegistro(empleados);

            totalEmpleados = empleados.Count();
            lbTotalEmpleados.Text = totalEmpleados.ToString();
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            empleados.Clear();
            MostrarRegistro(empleados);
            totalEmpleados = empleados.Count();
            lbTotalEmpleados.Text = totalEmpleados.ToString();
        }
    }
}
