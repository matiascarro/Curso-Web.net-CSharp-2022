using Pizzeria.Dominio.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Dominio.Concreto
{
    public class PizzaDobleQueso : ItemPedido, IPizza
    {
        public override double CalcularCosto()
        {
            return 450;
        }

        public void Imprimir()
        {
            Console.Write("Pizza con doble queso");
        }
    }
}
