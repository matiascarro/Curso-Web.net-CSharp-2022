using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvTools
{
    public class Campo
    {
        public Campo(string columna, string valor)
        {
            Columna = columna;
            Valor = valor;
        }

        public string Columna { get; }
        public string Valor { get; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is Campo)
            {
                Campo c = obj as Campo;
                return c.Valor.Equals(this.Valor) && c.Columna.Equals(this.Columna);
            }
            return false;
        }
    }
}
