using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Dominio.Abstracciones
{
    public abstract class ItemPedido: IPizza
    {
        public abstract double CalcularCosto();
    }
}
