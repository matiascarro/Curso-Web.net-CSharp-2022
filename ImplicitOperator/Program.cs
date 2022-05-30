// See https://aka.ms/new-console-template for more information
using ImplicitOperator;

Console.WriteLine("Hello, World!");

double dinero = 50.2;

//Peso p = new Peso{Valor = dinero}
Peso p = (Peso)dinero;

static void imprimirPeso(Peso p)
{
    Console.WriteLine(p.ToString());
}



