using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP2
{
    class Program
    {
        static void Main()
        {
            double dividendo, divisor;
            Console.WriteLine("Ingrese el dividendo");
            dividendo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el divisor");
            divisor = int.Parse(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("Error (división por 0)");
            }
            else
            {
                Console.WriteLine("El resultado de la división es " + (dividendo / divisor));
            }
            Console.ReadKey();
        }
    }
}
