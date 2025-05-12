using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese un número entero");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
            Console.ReadKey();
        }
    }
}
