// See https://aka.ms/new-console-template for more information

using Clase2.FormasGeometricas;

Triangulo triangulo1 = new Triangulo("Triangulo Equilatero", 20, 20, 20);

ImprimirForma(triangulo1);

Circulo circulo = new Circulo("Circulo", 10.5);
ImprimirForma(circulo);

FormasGeometrica fg = new Triangulo("Triangulo2", 20,20,20);
ImprimirForma(fg);


void ImprimirForma(FormasGeometrica fg)
{
    Console.WriteLine(fg.Perimetro());
    Console.WriteLine(fg.ToString());
}


///  Clase de a - e deberia ser abstracta si f es final (concrete)
///       | clase a|
///            |
///        | clase b|
///            |
///        | clase c|
///            |
///        | clase d|
///            |
///        | clase e|
///            |
///        | clase f|
///        
