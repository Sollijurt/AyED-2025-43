using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP14
{
    class Program
    {
        static void Main()
        {
            string nombre = "Jugador1";
            int salud = 100;
            int monedas = 50;
            int enemigosDerrotados = 0;
            int opcion = 0;
            bool tieneEspada = false, salir = true;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("=== SIMULADOR GAMER ===");
                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine("1.Mostrar estado del jugador");
                Console.WriteLine("2.Encontrar espada mágica");
                Console.WriteLine("3.Pelear contra un enemigo");
                Console.WriteLine("4.Comprar poción de vida(vale 20 monedas)");
                Console.WriteLine("5.Salir del juego");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Estado del jugador");
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Monedas: " + monedas);
                        Console.WriteLine("Enemigos derrotados: " + enemigosDerrotados);
                        if (tieneEspada)
                        {
                            Console.WriteLine("Tienes espada");
                        }
                        else
                        {
                            Console.WriteLine("No tienes espada");
                        }
                        break;
                    case 2:
                        if (tieneEspada)
                        {
                            Console.WriteLine("Ya tienes la Espada mágica");
                        }
                        else
                        {
                            Console.WriteLine("Ha encontrado la Espada mágica");
                        }
                        break;
                    case 3:
                        if (tieneEspada)
                        {
                            salud = salud - 10;
                            enemigosDerrotados++;
                            Console.WriteLine("Ganaste la batalla, salud -10");
                        }
                        else
                        {
                            salud = salud - 30;
                            Console.WriteLine("Fue una pelea dura, salud -30");
                        }
                        break;
                    case 4:
                        if (monedas >= 20)
                        {
                            monedas = monedas - 20;
                            salud = salud + 20;
                            Console.WriteLine("Usaste una poción, salud +20");
                        }
                        else
                        {
                            Console.WriteLine("No tiene suficientes monedas");
                        }
                        break;
                    case 5:
                        salir = false;
                        Console.WriteLine("Gracias por jugar");
                        break;
                    default:
                        Console.WriteLine("Fuera de rango (1,2,3,4,5");
                        break;
                }


            } while (salir);
        }
    }
}
