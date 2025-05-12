using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP4
{
    class Program
    {
        static void Main()
        {
            Boolean beca = false;
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su ingresos mensuales");
            Int64 ingresos = Int64.Parse(Console.ReadLine());

            if (edad == 19 && ingresos >= 50000)
            {
                beca = true;
            }
            else if (edad < 19 && ingresos == 0)
            {
                beca = true;
            }
            else if (edad > 19 && ingresos <= 100000)
            {
                beca = true;

            }
            
            if (beca)
            {
                Console.WriteLine("Usted puede cobrar la beca");
            }
            else
            {
                Console.WriteLine("Usted NO puede cobrar la beca");
            }
            Console.ReadKey();
        }
    }
}
