// See https://aka.ms/new-console-template for more information
using Pizzeria.Dominio.Abstracciones;
using Pizzeria.Dominio.Concreto;
using Pizzeria.Dominio.Enum;
using Pizzeria.Dominio.Indexadores;

Console.WriteLine("Hello, World!");



PizzaSimple pizzaSimple = new PizzaSimple();
Pepperoni pizzaConPepperoni = new Pepperoni(pizzaSimple);

Console.WriteLine("La orden fue de costo: " + pizzaConPepperoni.CalcularCosto());
Console.WriteLine();
pizzaConPepperoni.Imprimir();


PizzaDobleQueso pizzaDobleQueso = new PizzaDobleQueso();
Jamon pizzaDobleQuesoYJamon = new Jamon(pizzaDobleQueso);
Jamon pizzaDobleQuesoYJamon2 = new Jamon(pizzaDobleQuesoYJamon);
Morron pizzaDobleQuesoConJamonYMorrones = new Morron(pizzaDobleQuesoYJamon2);

Console.WriteLine();

Console.WriteLine("La orden fue de costo: " + pizzaDobleQuesoConJamonYMorrones.CalcularCosto());
pizzaDobleQuesoConJamonYMorrones.Imprimir();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


var pedido = new Pedido();
pedido[0] = pizzaConPepperoni;
pedido[1] = pizzaDobleQuesoConJamonYMorrones;

Console.WriteLine(pedido.CalcularCosto());
string pass = "4UZ2Q5VDJMzqDF5Rc4Bfm2F/Y/LGx7GTUXnIWw42KwY=";
Console.WriteLine(pass.Length);
//test();

static void test()
{
    Console.WriteLine("Ingrese lo que quiere comer opcion 0 o 1:");
    string linea = Console.ReadLine();
    TiposDePizza tipos = (TiposDePizza)int.Parse(linea);


    switch (tipos)
    {
        case TiposDePizza.pizzaConPepperoni:
            PizzaSimple pizzaSimple = new PizzaSimple();
            Pepperoni pizzaConPepperoni = new Pepperoni(pizzaSimple);
            pizzaConPepperoni.Imprimir();
            break;
        case TiposDePizza.pizzaDobleQuesoConJamonYMorrones:
            PizzaDobleQueso pizzaDobleQueso = new PizzaDobleQueso();
            Jamon pizzaDobleQuesoYJamon = new Jamon(pizzaDobleQueso);
            Jamon pizzaDobleQuesoYJamon2 = new Jamon(pizzaDobleQuesoYJamon);
            Morron pizzaDobleQuesoConJamonYMorrones = new Morron(pizzaDobleQuesoYJamon2);
            pizzaDobleQuesoConJamonYMorrones.Imprimir();
            break;
        default: Console.WriteLine("No existe");
            break;
    }

}