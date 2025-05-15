using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP10
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i%5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 != 0 && i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i%5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else
                {
                    Console.WriteLine("Número: " + i);
                }
            }
            Console.ReadKey();
        }
    }
}
