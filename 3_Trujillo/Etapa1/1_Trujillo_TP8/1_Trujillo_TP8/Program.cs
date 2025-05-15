using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¿Cual es tu edad?");
            int edad = int.Parse(Console.ReadLine());
            for (int i = 0; i != edad; i++)
            {
                Console.WriteLine("año " + (i+1));
            }
            Console.ReadKey(); 
        }
    }
}
