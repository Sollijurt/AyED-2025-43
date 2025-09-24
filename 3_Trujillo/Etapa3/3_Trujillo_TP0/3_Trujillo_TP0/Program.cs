static string funcion(string nombre)
{
    nombre = ("Hola " +  nombre);
    return nombre;
}

Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine(funcion(nombre));
