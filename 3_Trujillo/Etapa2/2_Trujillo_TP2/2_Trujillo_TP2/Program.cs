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
            int numtp = 0;
            int numex = 0;
            int promex = 0;
            double porcitp = 0;
            int promedio = 0, notaproba = 0;
            bool aprotp = false, aproex = false;

            Console.WriteLine("Ingrese la cantidad de tps");
            numtp = int.Parse(Console.ReadLine());
            int[] notatp = new int[numtp];
            porcitp = numtp;
            Console.WriteLine("Ingrese las notas de cada tp");
            for (int i = 0; i < numtp; i++)
            {
                notatp[i] = int.Parse(Console.ReadLine());
                

                if (notatp[i] >= 6)
                {
                    notaproba++;
                }
            }
            porcitp = porcitp * 0.75;
            if (porcitp <= notaproba)
            {
                aprotp = true;
            }


            Console.WriteLine("Ingrese la cantidad de examenes");
            numex = int.Parse(Console.ReadLine());
            int[] notaex = new int[numex];
            Console.WriteLine("Ingrese las notas de cada examen");
            
            for (int o = 0; o < numex; o++)
            {
                notaex[o] = int.Parse(Console.ReadLine());
                promex = notaex[o] + promex;
            }
            promedio = promex / numex;
            if (promedio >= 6)
            {
                aproex = true;
            }

            if (aproex == true && aprotp == true)
            {
                Console.WriteLine("Aprobo el año");
            }
            else
            {
                Console.WriteLine("Desaprobo el año");
            }
            Console.ReadKey();
            
        }
    }
}
