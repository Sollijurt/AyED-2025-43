using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese la cantidad de alumnos");
            int n = int.Parse(Console.ReadLine());

            string[,] planilla = new string[n, 3];

            int nombre = 0;
            int edad = 1;
            int nota = 2;
            bool salir = true;
            do
            {
                Console.WriteLine("¿Que desea ingresar?");
                Console.WriteLine(" (1) para ver la lista");
                Console.WriteLine(" (2) para ingresar nombres");
                Console.WriteLine(" (3) para ingresar edad" );
                Console.WriteLine(" (4) para ingresar nota");
                Console.WriteLine(" (5) para salir");
                int opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        Console.WriteLine("NOMBRES" + "\tEDADES" + "\tNOTAS");
                        for(int i = 0; i<n; i++)
                        {
                            for(int j = 0; j<3; j++)
                            {
                                Console.Write(planilla[i, j] + "\t");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese los datos");
                        for (int i = 0; i<n; i++)
                        {
                            planilla[i, nombre] = Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese los datos");
                        for (int i = 0; i < n; i++)
                        {
                            planilla[i, edad] = Console.ReadLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ingrese los datos");
                        for (int i = 0; i < n; i++)
                        {
                            planilla[i, nota] = Console.ReadLine();
                        }
                        break;
                    case 5:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("Fuera de rango (1,2,3,4,5)");
                        break;
                }
            } while (salir);
            
        }
    }
}
