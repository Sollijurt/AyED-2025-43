using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese un número");
            int num = int.Parse(Console.ReadLine());
            for (int i = num ; i != -1; i--)
            {
                Console.WriteLine("Cuenta regresiva: " + i);
            }
            Console.ReadKey();
        }
    }
}
