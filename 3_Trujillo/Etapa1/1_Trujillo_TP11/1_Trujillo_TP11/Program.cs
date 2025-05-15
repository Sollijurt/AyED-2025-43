using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese un número");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1;i != num + 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Numero par " + i);
                }
            }
            Console.ReadKey();
        }
    }
}
