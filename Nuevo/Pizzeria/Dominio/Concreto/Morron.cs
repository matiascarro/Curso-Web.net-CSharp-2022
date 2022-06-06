using Pizzeria.Dominio.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Dominio.Concreto
{
    public class Morron : DecoradorPizza
    {
        public Morron(IPizza pizza) : base(pizza)
        {
        }

        public override double CalcularCosto()
        {
            return base.CalcularCosto() + 150;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.Write("Morron");
        }
    }
}
