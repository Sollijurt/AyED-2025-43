using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP2
{
    class Program
    {
        static void Main()
        {
            int numtp = 0, numex = 0;
            int promex = 0, prometp = 0;
            Console.WriteLine("Ingrese la cantidad de tps");
            numtp = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de examenes");
            numex = int.Parse(Console.ReadLine());
            int[] notatp = new int[numtp];
            int[] notaex = new int[numex];
            for (int i = 0; i < numtp; i++)
            {
                Console.WriteLine("Ingrese las notas de cada tp");
                notatp[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Ingrese las notas de cada examen");
                notaex[i] = int.Parse(Console.ReadLine());

                promex = promex + notaex[i];
                prometp = prometp + notatp[i];
            }

        }
    }
}
