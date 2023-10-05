using Caso__A.controller;
using Caso__A.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso__A.reports
{
    internal class ClienteReport
    {
        ClienteController cC = new ClienteController();
        public ClienteReport() { }
        public bool Registrar(String codigo, Cliente cliente)
        {
            if(cC.Existe(codigo, cliente.Dni))
            {
                return false;
            }
            else
            {
                cC.Registrar(codigo, cliente);
                return true;
            }
        }
        public List<Cliente>ListarTodo(String codigo)
        {
            return cC.ListarTodo(codigo);
        }
    }
}
