using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Tujillo_TP10
{
    class Program
    {
        static void Main()
        {
            int centi;
            Console.WriteLine("Ingrese los grados Celcius");
            centi = int.Parse(Console.ReadLine());
            Console.WriteLine("El pasaje a Fahrenheith es " + ((centi * 1.8) + 32));
            Console.WriteLine("El pasaje a Kelvin es " + ((centi + 273.15)));
            Console.ReadKey();
        }
    }
}
