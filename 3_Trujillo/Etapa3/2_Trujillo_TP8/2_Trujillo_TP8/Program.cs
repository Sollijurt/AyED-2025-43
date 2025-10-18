Console.WriteLine("Ingrese las filas de la matriz");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese las columnas de la matriz");
int m = int.Parse(Console.ReadLine());

int[,] matriz = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine("");
}