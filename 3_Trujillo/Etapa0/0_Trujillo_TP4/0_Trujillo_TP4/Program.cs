using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Trujillo_TP4
{
    class Program
    {
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("Ingrese 2 números");
            string snum1 = Console.ReadLine();
            string snum2 = Console.ReadLine();
            num1 = int.Parse(snum1);
            num2 = int.Parse(snum2);
            Console.WriteLine("La suma de los números es " + (num1 + num2));
            Console.ReadKey();
        }
    }
}
