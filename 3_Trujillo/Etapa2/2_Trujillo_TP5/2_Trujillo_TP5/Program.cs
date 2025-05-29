using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el filtro a ser tomado");
            int Filtro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de objetos que desee analizar");
            int CapacidadObj = int.Parse(Console.ReadLine());
            

            int[] ListaObj = new int[CapacidadObj];

            for (int i = 0; i < CapacidadObj; i++)
            {
                Console.WriteLine("Ingrese el valor de cada objeto");
                ListaObj[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < CapacidadObj; i++)
            {
                if (ListaObj[i] > Filtro)
                {
                    Console.WriteLine("La posición " + (i + 1) + " Contiene un valor mayor al filtro");
                }
            }
            Console.ReadKey();

        }
    }
}
