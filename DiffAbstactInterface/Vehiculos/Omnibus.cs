using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffAbstactInterface.Vehiculos
{
    public class Omnibus : Vehiculo, IOmnibus
    {
        public IEnumerable<Conductor> conductor { get; set; }
        public void CobrarBoleto()
        {
            throw new NotImplementedException();
        }

        public override void Acelerar()
        {
            base.Acelerar();
            Console.WriteLine("Acelero como un Bondi");
        }

        public override string Mostrarme()
        {
            return "Soy un bondi: " + Marca; 
        }

        public void SubenPasajeros()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.Matricula;
        }
    }
}
