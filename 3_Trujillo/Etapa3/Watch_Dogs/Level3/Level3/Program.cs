using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
        int[,] g =
        {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
        bool ok = Level3.CountAdjacent(g, 1, 1) == 4
               && Level3.CountAdjacent(g, 0, 0) == 2;
        Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level3
{
    public static int CountAdjacent(int[,] grid, int row, int col)
    {
        int conta = 0;
        int r = grid.GetLength(0);
        int c = grid.GetLength(1);
        for (int i = 1; i > -2; i = i - 2)
        {
            if (row + i >= 0 && col >= 0)
            {
                if (grid[row + i, col] == 1)
                {
                    conta++;
                }
            }
        }
        for (int j = 1; j > -2; j = j - 2)
        {
            if (row >= 0 && col + j >= 0)
            {
                if (grid[row, col + j] == 1)
                {
                    conta++;
                }
            }
        }
        // TODO: implementar
        // Considerar vecinos: (r-1,c), (r+1,c), (r,c-1), (r,c+1)
        // Devolver cuántos valen 1
        return conta; // <- reemplazar por tu solución
    }
}
