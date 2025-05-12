using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Trujillo_TP11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba el ancho");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura");
            int y = int.Parse(Console.ReadLine());

            int perimetro = 2 * x + 2 * y;
            double area = x * y;
            double diagonal = Math.Sqrt(x * x + y * y);

            Console.WriteLine("El perimetro es " + perimetro + " el area es " + area + " la diagonal " + diagonal);
            Console.ReadKey();
        }
    }
}
