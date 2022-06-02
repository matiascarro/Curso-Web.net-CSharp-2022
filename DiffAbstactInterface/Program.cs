// See https://aka.ms/new-console-template for more information
using DiffAbstactInterface.Calculadora;
using DiffAbstactInterface.Vehiculos;

Console.WriteLine("Hello, World!");

//ImprimirSuma(new SumarDeA10 { op1 = 1, op2 = 2 });
//ImprimirSuma(new SumarDeA20 { op1 = 1});

void ImprimirSuma(ISuma suma)
{
    Console.WriteLine(suma.Sumar());
}

/*********Vehiculos********/

List<Vehiculo> vehiculos = new List<Vehiculo>();

vehiculos.Add(new Auto { Marca = "Peugeout" });
vehiculos.Add(new Omnibus { Marca = "Mercedes" });
ImprimirVehiculos(vehiculos.ToArray());

void ImprimirVehiculos(IEnumerable<Vehiculo> vehiculos)
{
    foreach (Vehiculo vehiculo in vehiculos)
    {
        Console.WriteLine(vehiculo.Mostrarme());
    }
}