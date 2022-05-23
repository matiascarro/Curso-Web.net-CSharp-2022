using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.FormasGeometricas
{
    public class Circulo : FormasGeometrica
    {
        public Circulo(string nombre, double radio): base(nombre)
        {
            this.Radio = radio;
        }

        public double Radio { get; }
        public override double Perimetro()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
