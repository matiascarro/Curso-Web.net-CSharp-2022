using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffAbstactInterface.Calculadora
{
    public class SumarDeA20 : ISuma
    {
        public double op1 { get; set; }
        
        public double Sumar()
        {
            return op1 + 20;
        }
    }
}
