using Pizzeria.Dominio.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Dominio.Indexadores
{
    public class Pedido
    {
        private readonly ItemPedido[] pedido = new ItemPedido[2];


        public ItemPedido this[int i]
        {
            set { pedido[i] = value; }
        }

        public double CalcularCosto()
        {
            return pedido.ToList().Sum(p => p.CalcularCosto());
        }

    }
}
