using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese la cantidad de candidatos");
            int Candidatos = int.Parse(Console.ReadLine());
            int[] notas = new int[Candidatos];
            for (int i = 0; i < Candidatos; i++)
            {
                Console.WriteLine("Ingrese las notas de cada candidato");
                notas[i] = int.Parse(Console.ReadLine());
            }
            int aux = 0;
            for (int i = 0; i < Candidatos; i++)
            {
                for (int j = i; j < Candidatos; j++)
                {
                    if (notas[i] > notas[j])
                    {
                        aux = notas[i];
                        notas[i] = notas[j];
                        notas[j] = aux;
                    }
                }
            }
            Console.WriteLine("Ingrese un valor de filtro");
            
            int filtro = int.Parse(Console.ReadLine());
            Console.WriteLine("");                                                                                                                    
            for (int i = 0; i<Candidatos; i++)
            {
                Console.WriteLine(notas[i]);
                
            }
            for (int i = 0; i< Candidatos; i++)
            {
              if (notas[i] % filtro == 0)
                {
                    Console.WriteLine("Numeros que son multiplos del filtro");
                    Console.WriteLine(notas[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
