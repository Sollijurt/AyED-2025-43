using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Trujillo_TP12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese 3 letras");
            string let = Console.ReadLine();
            Console.WriteLine(let[2]+ "" + let[1] + "" + let[0]);
            Console.ReadKey();

        }
    }
}
