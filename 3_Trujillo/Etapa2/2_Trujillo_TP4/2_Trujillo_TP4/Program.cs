using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP4
{
    class Program
    {
        static void Main()
        {
            int canti_Productos = 0;
            Console.WriteLine("Ingrese la cantidad de productos vendidos en el hot sale");
            canti_Productos = int.Parse(Console.ReadLine());
            int[] Precios = new int[canti_Productos];
            Console.WriteLine("Ingrese el precio de cada producto");
            for (int i = 0; i < canti_Productos; i++)
            {
                Precios[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < canti_Productos - 1; i++)
            {
                for (int j = i + 1; j < canti_Productos; j++)
                {
                    if (Precios[i] > Precios[j])
                    {
                        int aux = Precios[i];

                        Precios[i] = Precios[j];
                        Precios[j] = aux;
                    }
                }
            }
            Console.WriteLine("El precio más bajo fue " + Precios[0]);

            Console.WriteLine("El precio más alto fue " + Precios[canti_Productos -1]);



            Console.WriteLine("Los precios más bajos fueron");
            for (int i = 0; i <= canti_Productos - 1 && i < 6; i++)
            {
                Console.WriteLine(Precios[i]);
            }
            Console.WriteLine("Los precios más altos fueron");
            
            for (int i = canti_Productos-1; i > canti_Productos - 6 && i >= canti_Productos -1 ; i--)
            {
                Console.WriteLine(Precios[i]);
            }
            Console.ReadKey();
        }
    }
}
