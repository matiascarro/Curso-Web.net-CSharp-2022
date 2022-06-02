using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffAbstactInterface.Vehiculos
{
    public abstract class Vehiculo : IVehiculo
    {
        
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerar");
        }

        public virtual void Frenar()
        {
            Console.WriteLine("Frenar");
        }

        public abstract string Mostrarme();

    }
}
