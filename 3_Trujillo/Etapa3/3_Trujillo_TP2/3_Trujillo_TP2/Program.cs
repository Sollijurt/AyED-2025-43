using System.Numerics;

static int suma(int n1, int n2)
{
    int resu = n1 + n2;
    return resu;
}

static int resta(int n1, int n2)
{
    int resu = n1 - n2;
    return resu;
}

static int multi(int n1, int n2)
{
    int resu = n1 + n2;
    return resu;
}

static double divi(double n1, double n2)
{
    double resu = n1 / n2;
    return resu;
}


static int calculadora(int num1, int num2)
{
    int salir = 0;
    Console.WriteLine("Ingrese una opción");
    Console.WriteLine("1) Suma");
    Console.WriteLine("2) Resta");
    Console.WriteLine("3) Multiplicación");
    Console.WriteLine("4) División");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("El resultado de la suma es " + suma(num1, num2));
            break;
        case "2":
            Console.WriteLine("El resultado de la resta es " + resta(num1, num2));
            break;
            case "3":
            Console.WriteLine("El resultado de la multiplicación es " + multi(num1, num2));
            break;
            case "4":
            Console.WriteLine("El resultado de la división es " + divi(num1, num2));
            break;
            case "5":
            Console.WriteLine("Gracias por usar");
            salir = 1;
            break;
        default:
            Console.WriteLine("Fuera de rango (1,2,3,4)");
            break;
            
    }
    Console.WriteLine("Aprete cualquier tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    return salir;
}


int num1, num2;

do
{
    Console.WriteLine("Ingrese 2 números");
    num1 = int.Parse(Console.ReadLine());
    num2 = int.Parse(Console.ReadLine());
} while (calculadora(num1, num2) == 0);

