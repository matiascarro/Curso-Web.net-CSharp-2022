using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.FormasGeometricas
{
    public abstract class FormasGeometrica
    {
        protected FormasGeometrica(string nombre)
        {
            Nombre = nombre;
        }

        public int Id { get; set; }
        protected string Nombre { get; set; }
        public abstract double Perimetro();

        public override string ToString()
        {
            return "Es una forma geometrica";
        }
    }

}
