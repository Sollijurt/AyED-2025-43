using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Trujillo_TP3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            string edada = Console.ReadLine();
            int edad = int.Parse(edada);
            Console.WriteLine("Hola " + nombre + " Tu edad es " + edad);
            Console.ReadKey();
        }
    }
}
