using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP5
{
    class Program
    {
        static void Main()
        {
            Boolean comida = false, refugio = false, bate = false;
            Console.WriteLine("¿Usted tiene comida? (si o no)");
            if (Console.ReadLine().ToUpper() == "SI") 
            {
                comida = true;
            }
            Console.WriteLine("¿Usted tiene un refugio? (si o no)");
            if (Console.ReadLine().ToUpper() == "SI")
            {
                refugio = true;
            }
            Console.WriteLine("¿Usted tiene un bate? (si o no)");
            if (Console.ReadLine().ToUpper() == "SI")
            {
                bate = true;
            }
            if (comida && refugio && bate)
            {
                Console.WriteLine("Usted sobrevivira");
            }
            else
            {
                Console.WriteLine("Usted NO sobrevivira");
            }
            Console.ReadKey();
        }
    }
}
