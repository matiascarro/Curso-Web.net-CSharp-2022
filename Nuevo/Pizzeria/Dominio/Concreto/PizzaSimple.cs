using Pizzeria.Dominio.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Dominio.Concreto
{
    public class PizzaSimple : ItemPedido, IPizza
    {
        public override double CalcularCosto()
        {
            return 300;
        }

        public void Imprimir()
        {
            Console.Write("Pizza simple");
        }
    }
}
