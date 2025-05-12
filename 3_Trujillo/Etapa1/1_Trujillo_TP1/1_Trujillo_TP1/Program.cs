using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese una contraseña");
            string contra = Console.ReadLine().ToUpper();
            Console.WriteLine("Escriba su contraseña");
            string contra2 = Console.ReadLine().ToUpper();
            if (contra == contra2){
                Console.WriteLine("Contraseña es verdadera");
            }
            else
            {
                Console.WriteLine("Contraseña es falsa");

            }
            Console.ReadKey();
        }
    }
}
