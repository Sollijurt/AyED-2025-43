using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP0
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad > 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
            }
            Console.ReadKey();

        }
    }
}
