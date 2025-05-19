using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP1
{
    class Program
    {
        static void Main()
        {
            int vueltas = 0, total = 0, vueltarapida = 100000, numvuelta= 0;
            Console.WriteLine("Ingrese la cantidad de vueltas");
            vueltas = int.Parse(Console.ReadLine());
            int[] tiempo = new int[vueltas];
            for (int i = 0; i < vueltas; i++)
            {
                Console.WriteLine("Ingrese los tiempos de cada vuelta (en segundos)");
                tiempo[i] = int.Parse(Console.ReadLine());

                total = total + tiempo[i];

                if (vueltarapida > tiempo[i])
                {
                    vueltarapida = tiempo[i];
                    numvuelta = i;
                }
            }
            Console.WriteLine("El tiempo total de la carrera fue " + total);
            Console.WriteLine("El tiempo promedio de cada vuelta fue " + (total / vueltas));
            Console.WriteLine("La vuelta más rapida fue la " + (numvuelta + 1) + " Con " + vueltarapida + " segundos");
            Console.ReadKey();
        }
    }
}
