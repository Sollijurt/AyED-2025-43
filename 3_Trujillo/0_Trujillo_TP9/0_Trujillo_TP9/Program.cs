using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Trujillo_TP9
{
    class Program
    {
        static void Main()
        {
            double radio;
            Console.WriteLine("Ingrese el radio de la esfera");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("La superficie de la esfera es " + (4 * Math.PI * Math.Pow(radio, 2)));
            Console.WriteLine("El volumen de la esfera es " + (Math.PI * Math.Pow(radio, 3) * 4 / 3));
            Console.ReadKey();
        }
    }
}
