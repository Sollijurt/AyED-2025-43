using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el tamaño matriz");
            int n = int.Parse(Console.ReadLine());
            Random ale = new Random();

            int[,] matriz = new int[n, n];
            int[] vector = new int[n];

            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = ale.Next(1, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                vector[i] = matriz[i, i];
            }

            Console.WriteLine("La diagonal principal es");
            for (int i = 0; i<n; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
