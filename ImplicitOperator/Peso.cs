using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitOperator
{
    public class Peso
    {
        public double Valor { get; set; }

        public static implicit operator double(Peso p) => p.Valor;
        public static explicit operator Peso(double p) => new Peso { Valor = p};

        public override string ToString()
        {
            return "$" + Valor;
        }
    }
}
