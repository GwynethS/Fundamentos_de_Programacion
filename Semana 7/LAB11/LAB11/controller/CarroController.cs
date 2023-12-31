﻿using LAB11.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11.controller
{
    internal class CarroController
    {
        private Queue<Carro> cola = new();

        public CarroController() { }

        public Queue<Carro> ObtenerCola()
        {
            return cola;
        }

        public void Ingresar(Carro carro)
        {
            cola.Enqueue(carro);
        }

        public int Salir(String matricula)
        {
            int movimientos = 1;
            bool encontrado = false;

            Queue<Carro> nuevaCola = new();

            while(cola.Count > 0)
            {
                Carro carro = cola.Peek();
                if(carro.Matricula.Equals(matricula))
                {
                    cola.Dequeue();
                    encontrado = true;
                }
                else
                {
                    nuevaCola.Enqueue(carro);
                    cola.Dequeue();
                    if (!encontrado)
                    {
                        movimientos++;
                    }
                }
            }
            cola = nuevaCola;
            return movimientos;
        }
    }
}
