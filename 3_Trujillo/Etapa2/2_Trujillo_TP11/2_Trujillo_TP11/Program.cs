

Console.WriteLine("n matriz");
int n = int.Parse(Console.ReadLine());
int[,] matriz = new int[n,n];
int[,] resu = new int[n, n];
Random ale = new Random();



for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matriz[i, j] = ale.Next(0, 100);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        resu[j, n - 1 - i] = matriz[i, j];
    }
}


Console.WriteLine("");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        
        Console.Write(resu[i, j] + " ");

    }
    Console.WriteLine();
}