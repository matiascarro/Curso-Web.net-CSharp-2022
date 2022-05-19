// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.ReadKey();

//<tipo> <label> (<inicializar>)
//= <valor>
/*
 * Ignorado por el compilador
 */
string nomprePersona = "Matias Carro";
char caracter;

const int MAYOR_DE_EDAD = 18;

int edad = 35;
long numberLong;

double precio; //numero de doble precision 64bits
float precioEnFloat; // numero con coma de simple precision, 32 bits

bool verdaderoOFalso;
byte unoOCero;

string datosCompletos = nomprePersona + " " + edad;
precio = edad;

if(edad > MAYOR_DE_EDAD)
{
    Console.WriteLine("Es mayor de edad");
    if(edad >= 35)
    {
        Console.WriteLine("Es mayor que 35");
    }

}
else if(edad > 12)
{
    Console.WriteLine("Es un adolescente");
}
else
{
    Console.WriteLine("Es un niño");
}

string condicionEdad = edad >= MAYOR_DE_EDAD ? "Es mayor de edad" : "Es menor de edad";
string opcion = "2";
pruebaDeSwitch();


void pruebaDeSwitch()
{
    switch (opcion)
    {
        case "1":
        case "2":
            Console.WriteLine("case 1 o 2");
            break;
        case "3":
            Console.WriteLine("case 3");
            break;
        default:
            Console.WriteLine("Ninguno de los anteriores");
            break;
    }

}

//valores null

