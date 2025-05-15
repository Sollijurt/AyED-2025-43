using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP12
{
    class Program
    {
        static void Main()
        {   
            string hola = "no";
            do
            {
                Console.WriteLine("¿Quiere salir del programa?");
                hola = Console.ReadLine();
            } while (hola != "SI");
        }
    }
}
