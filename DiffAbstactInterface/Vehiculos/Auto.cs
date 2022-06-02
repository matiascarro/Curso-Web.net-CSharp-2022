using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffAbstactInterface.Vehiculos
{
    public class Auto: Vehiculo
    {
        public Conductor conductor { get; set; }
        public override string Mostrarme()
        {
            return "Soy un auto: " + this.Marca;
        }
    }
}
