using Caso__A.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso__A.controller
{
    internal class ClienteController
    {
        public ClienteController() { }
        public bool Existe(String codigo, String dni)
        {
            ProyectoInmobiliario proyecto = ProyectoInmobiliarioController.ListarTodo().Find(p => p.Codigo.Equals(codigo));

            return proyecto.Clientes.Exists(c => c.Dni.Equals(dni));
        }

        public void Registrar(String codigo, Cliente cliente)
        {
            ProyectoInmobiliario proyecto = ProyectoInmobiliarioController.ListarTodo().Find(p => p.Codigo.Equals(codigo));

            proyecto.Clientes.Add(cliente);
        }

        public List<Cliente>ListarTodo(String codigo)
        {
            ProyectoInmobiliario proyecto = ProyectoInmobiliarioController.ListarTodo().Find(p => p.Codigo.Equals(codigo));

            return proyecto.Clientes;
        }
    }
}
