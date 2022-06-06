// See https://aka.ms/new-console-template for more information
using Modulo4_Ejercico2;

Console.WriteLine("Hello, World!");

var p1 = new Point(1, 2);
var p2 = new Point(2, 3);

bool esIgual = p1.X == p2.X && p1.Y == p2.Y;
bool esIgualSobrecargado = p1 == p2;
bool esDistintoSobrecargado = p1 != p2;

var p3 = p1 + p2;
