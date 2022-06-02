// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] arr1 = { "hola", "chau" };

IEnumerable<string> nuevoArra = arr1.ToList();
ICollection<string> arra = new List<string>();

foreach (string item in arr1)
{
    Console.WriteLine(item);
}

//public static void ForEach<string>(string[] array, Action<string> action)
//{
//}


Action<string> action = (item) => Console.WriteLine(item);
arr1.ToList().ForEach((item) => { Console.WriteLine(item); });
arr1.ToList().ForEach(action);

bool MayorIgualQue5(string palabra)
{
    return palabra.Length >= 5;
}

Func<string, bool> funcMayorIgualQue5 = (palabra) => palabra.Length >= 5;

IEnumerable<string> lista =  arr1.Where(MayorIgualQue5);
lista = arr1.Where(funcMayorIgualQue5);

lista = arr1.Where((palabra) => palabra.Length >= 5);

bool resultado = funcMayorIgualQue5("Hola");


//linq



