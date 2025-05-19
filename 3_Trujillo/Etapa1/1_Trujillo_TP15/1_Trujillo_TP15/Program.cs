using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP15
{
    class Program
    {
        static void Main()
        {
            int salud = 100;
            int opcion = 0;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool salir = true;
            Random rand = new Random();
            
            do
            {
                int ale = rand.Next(1, 101);
                Console.WriteLine("");
                Console.WriteLine("Día" + dia + "¿Qué querés hacer?");
                Console.WriteLine("1.Buscar comida");
                Console.WriteLine("2.Dormir");
                Console.WriteLine("3.Explorar la isla");
                Console.WriteLine("4.Ver estado del personaje");
                Console.WriteLine("5.Salir del juego");
                Console.WriteLine("");
                opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            if (ale >= 30)
                            {
                                Console.WriteLine("Consiguio comida. + 20 hambre - 15 energia");
                                hambre = hambre + 20;
                                energia = energia - 15;
                            }
                            else
                            {
                                Console.WriteLine("Comiste algo en mal estado. -15 salud");
                                salud = salud - 15;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Va a dormir. +30 energia, -10 hambre, +1 dia");
                            dia = dia + 1;
                            hambre = hambre - 10;
                            energia = energia + 30;

                            break;
                        case 3:
                            if (ale >= 50)
                            {
                                Console.WriteLine("Ha ido a explorar la isla. -20 energia, -15 hambre");
                                energia = energia - 20;
                            hambre = hambre - 15;

                            }
                            else
                            {
                                Console.WriteLine("Encontraste una planta curativa. +10 salud");
                                salud = salud + 10;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Su estado es ");
                            Console.WriteLine("Salud " + salud);
                            Console.WriteLine("Energia " + energia);
                            Console.WriteLine("Hambre " + hambre);
                            Console.WriteLine("Dia " + dia);
                            break;
                        case 5:
                            Console.WriteLine("Gracias por jugar");
                            salir = false;
                            break;
                        default:
                            Console.WriteLine("Numero fuera de rango(1,2,3,4,5)");
                            break;
                    }
                if (energia < 0 || hambre <= 0 || salud <= 0)
                {
                    Console.WriteLine("usted murio");
                    salir = false;
                }
            } while (salir); 
           
        }
    }
}
