using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.FormasGeometricas
{
    public sealed class Triangulo : FormasGeometrica
    {
        private double lado_A;
        private double lado_B;
        private double lado_C;

        public Triangulo(string nombre, double lado_A, double lado_B, double lado_C): base(nombre)
        {
            this.lado_A = lado_A;
            this.lado_B = lado_B;
            this.lado_C = lado_C;
        }


        //public double Perimetro => Lado_A + Lado_B + Lado_C;

        public override double Perimetro()
        {
            var test= () => { Console.WriteLine(""); return 0; };
            return lado_A + lado_B + lado_C;
            
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
