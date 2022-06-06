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
            /*
             * double suma = 0
             * foreach(p in pedido)
             * {
             *    suma=+ p.CalcularCosto()
             * }
             * return suma;
             */
            
            
            return pedido.ToList().Sum(p => 
            {
                //Type type = p.GetType();
                //Type type2 = typeof(Morron);

                //if (p is Morron)
                //{
                //    Console.WriteLine("Esto es un morron");
                //}
                //Console.WriteLine(p.GetType().Name);
                return p.CalcularCosto();
            });
        }

    }
}
