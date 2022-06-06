using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Dominio.Abstracciones
{
    public abstract class DecoradorPizza : ItemPedido, IPizza
    {
        private readonly IPizza _pizza;

        protected DecoradorPizza(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override double CalcularCosto()
        {
            return _pizza.CalcularCosto();
        }

        public virtual void Imprimir()
        {
            _pizza.Imprimir();
        }
    }
}
