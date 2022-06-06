using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Dominio.Abstracciones
{
    public interface IPizza
    {
        double CalcularCosto();

        void Imprimir();
    }
}
