using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Trujillo_TP8
{
    class Program
    {
        static void Main()
        {
            double num1, num2;
            Console.WriteLine("Ingrese 2 números");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resto de los números es " + (num1 % num2));
            Console.ReadKey();
        }
    }
}
