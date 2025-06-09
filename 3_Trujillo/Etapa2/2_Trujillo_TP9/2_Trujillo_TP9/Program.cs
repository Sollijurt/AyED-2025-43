Console.WriteLine("Ingrese la cantidad de filas");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de columnas");
int m = int.Parse(Console.ReadLine());

Random ale = new Random();

int[,] matriz = new int[n,m];

for (int i = 0; i < n; i++)
{
     for(int j = 0; j < m; j++)
    {
        matriz[i, j] = ale.Next(1, 100);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine("");
}