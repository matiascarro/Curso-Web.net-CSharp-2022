// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.ReadKey();

//Array
//for y while
//POO Clases y objetos
//Object thinking

string[] nombresAlumnos1 = new string[10];
string[] nombresAlumnos2 = { "Martin","Carlos", "Christian", "Diego", "Geraldine" };

string nombre = nombresAlumnos2[0];
///nombre = "Martin"

//Una vez sola al principio int i = 0
for (int i = 0; i < nombresAlumnos2.Length; i++)
{
    // siempre por cada iteraccion al principio i < nombresAlumnos2.Length
    Console.WriteLine("Lista de alumnos:" + nombresAlumnos2[i]);
// i++ siempre se ejecuta al final
}

int j = 0;
while(j < nombresAlumnos2.Length)
{
    Console.WriteLine("Lista de alumnos:" + nombresAlumnos2[j]);
    j++; //i = i+1
}


