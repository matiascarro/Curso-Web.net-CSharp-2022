using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvTools
{
    public class CsvIndexado
    {
        private Dictionary<Campo, CsvRow> registrosIndexados = new Dictionary<Campo, CsvRow>();

        public CsvIndexado()
        {

        }

        public CsvRow this[Campo c]
        {

            get { return registrosIndexados[c]; }
            set { registrosIndexados[c] = value; }
        }

    }
}
