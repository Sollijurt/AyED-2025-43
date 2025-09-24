static int suma(int n1, int n2)
{
    int resu = n1 + n2;
    return resu;
}


int num1, num2;
Console.WriteLine("Ingrese 2 numeros");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("La suma entre los dos números es " + suma(num1, num2));


