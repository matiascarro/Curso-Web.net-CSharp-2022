using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.FormasGeometricas
{
    public class Circulo : FormasGeometrica
    {
        public static readonly double PI = 3.14;
        public Circulo(string nombre, double radio): base(nombre)
        {
            this.Radio = radio;
        }

        public double Radio { get; }
        public override double Perimetro()
        {
            return PI * Radio * Radio;
        }
    }
}
