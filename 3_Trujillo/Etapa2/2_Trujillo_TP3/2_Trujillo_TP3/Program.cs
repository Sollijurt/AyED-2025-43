using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP3
{
    class Program
    {
        static void Main()
        {
            int num_jugadores = 0;
            Console.WriteLine("Ingrese la cantidad de jugadores");
            num_jugadores = int.Parse(Console.ReadLine());
            int[] jugadores = new int[num_jugadores];

            Console.WriteLine("Ingrese el puntaje de cada jugador");
            for (int i = 0; i < num_jugadores; i++)
            {
                jugadores[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num_jugadores - 1; i++)
            {
                for (int j = i + 1; j < num_jugadores; j++)
                {
                    if (jugadores[i] < jugadores[j])
                    {
                        int aux = jugadores[i];

                        jugadores[i] = jugadores[j];
                        jugadores[j] = aux;
                    }
                }
            }

            for(int i = 0; i< num_jugadores; i++)
            {
                Console.WriteLine(jugadores[i]);
            }
            Console.ReadKey();
        }
    }
}
