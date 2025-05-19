using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP0
{
    class Program
    {
        static void Main()
        {
            int invitado = 0, total = 0;
            Console.WriteLine("¿Cuantos invitados hay?");
            invitado = int.Parse(Console.ReadLine());
            int[] comida = new int[invitado];

            for (int i = 0; i < invitado; i++)
            {
                Console.WriteLine("¿Cuanta comida consumira el invitado " + i + " ?");
                int respuesta = int.Parse(Console.ReadLine());
                if (respuesta > 100 || respuesta < 0)
                {
                    Console.WriteLine("No se puede comer tanta comida");
                    i--;
                }
                comida[i] = respuesta;
                total = comida[i] + total;
            }

            Console.WriteLine("El promedio de comida por persona es " + total/invitado);
            Console.ReadKey();
        }
    }
}
