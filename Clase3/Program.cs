// See https://aka.ms/new-console-template for more information
using Clase3;

Console.WriteLine("Hello, World!");

Utils utils = new Utils();
//Console.WriteLine(utils.Suma(2, 3));


static double MultiLocal(double x, double y)
{
    double resultado = x * y;
    Console.WriteLine("***** La multi es:" + resultado);
    return resultado;
}

static double Suma_Funcion(double x, double y)
{
    Console.WriteLine("----- La suma es:" + (x + y));
    return x + y;
}

utils.OtraSuma += MultiLocal;
utils.OtraSuma += Suma_Funcion;
utils.OtraSuma += (x,y) => 
    { 
        Console.WriteLine((x+y)*10 ); 
        return 10; 
    };
utils.OtraSuma += (x, y) => 10;
utils.OtraSuma += Calculadora.Multi;
utils.OtraSuma(2, 3);

//Func<>
//Action<>
Func<double, double, double> operacion = Calculadora.Multi;
operacion += Suma_Funcion;
Action<double, double> operacionSinRetorno = (x, y) => { Console.WriteLine(x + y); };
operacion(2, 3);

