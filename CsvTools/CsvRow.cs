using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvTools
{
    public class CsvRow
    {
        private List<Campo> campos = new List<Campo>();

        public void AgregarCampo(string columna, string valor)
        {
            campos.Add(new Campo(columna, valor));
        }

        public Campo this[string columna]
        {
            get { return campos.Single(c => c.Columna.Equals(columna)); }
        }

        public Campo this[int posicion]
        {
            get { return campos.ElementAt(posicion); }
        }

        public string ImprimirRegistro()
        {
            //A-B-C => "A"-"B"-"C" Select esto es un Map
            //A,B,C
            return string.Join(',', campos.Select(c=>c.Valor));
        }

    }
}
