using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese la temperatura en grados celcius");
            int celcius = int.Parse(Console.ReadLine());
            if (celcius >= 100)
            {
                Console.WriteLine("Hierve");
            }
            else if (celcius <= 0)
            {
                Console.WriteLine("Congela");
            }
            else
            {
                Console.WriteLine("Estado liquido");
            }
            Console.ReadKey();
        }
    }
}
