//Sumar dos matrices de igual tamaño nxn, almacenarlas en una nueva e imprimirla por pantalla.

Console.WriteLine("Ingrese el tamaño de la matriz");
int n = int.Parse(Console.ReadLine());
Random ale = new Random();

int[,] matriz1 = new int[n, n];
int[,] matriz2 = new int[n, n];
int[,] resu = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matriz1[i, j] = ale.Next(1, 100);
        matriz2[i, j] = ale.Next(1, 100);
        resu[i, j] = matriz1[i, j] + matriz2[i, j];
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(resu[i, j] + " ");
    }
    Console.WriteLine(" ");
}