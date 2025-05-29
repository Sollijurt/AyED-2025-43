using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP7
{
    class Program
    {
        static void Main()

        {
            bool salir = true;
            Random rand = new Random();
            Console.WriteLine("Ingrese el tamaño del vector");
            int tamano = int.Parse(Console.ReadLine());
            int[] numeros = new int[tamano];
            for (int i = 0; i < tamano; i++)
            {
                numeros[i] = rand.Next(0, 100);
            }
            do
            {
                Console.WriteLine("Ingrese una opción");
                Console.WriteLine("(1) Muestra todo el vector");
                Console.WriteLine("(2) Buscar número");
                Console.WriteLine("(3) Ordenar el vector (Ascendente o descendente");
                Console.WriteLine("(4) Salir del programa");
                int opcion = int.Parse(Console.ReadLine()); 
                switch (opcion)
                {
                    case 1:
                        for (int i = 0; i < tamano; i++)
                        {
                            Console.WriteLine(numeros[i]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un número a buscar");
                        bool nohay = true;
                        int buscar = int.Parse(Console.ReadLine());
                        int pos = 0;
                        for (int i = 0; i < tamano; i++)
                        {
                            if (numeros[i] == buscar)
                            {
                                pos = i;
                                Console.WriteLine("La posicion es " + (pos + 1));
                                nohay = false;
                            }
                        }
                        if (nohay)
                        {
                            Console.WriteLine("No se encontro el número");
                        }

                        break;
                    case 3:
                        Console.WriteLine("(1) ascendete");
                        Console.WriteLine("(2) descendete");
                        int opti = int.Parse(Console.ReadLine());
                        int aux = 0;
                        switch (opti)
                        {
                            case 1:
                                
                                for(int i = 0; i < tamano; i++)
                                {
                                    for (int j = i; j< tamano; j++)
                                    {
                                        if(numeros[i] > numeros[j])
                                        {
                                            aux = numeros[i];
                                            numeros[i] = numeros[j];
                                            numeros[j] = aux;
                                        }
                                    }
                                }
                                break;
                            case 2:
                                for (int i = 0; i < tamano; i++)
                                {
                                    for (int j = i; j < tamano; j++)
                                    {
                                        if (numeros[i] < numeros[j])
                                        {
                                            aux = numeros[i];
                                            numeros[i] = numeros[j];
                                            numeros[j] = aux;
                                        }
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Fuera de rango(1,2)");
                                break;
                        }
                        break;
                    case 4:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("Fuera de rango (1,2,3,4)");
                        break;

                }
            } while (salir);
            Console.ReadKey();
            

        }
    }
}
