using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Trujillo_TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            int hpHornet = 10;
            int hpMaxHornet = 10;
            int atkHornet = 3;
            int hpEnemigo = 12;

            Console.WriteLine("=== Hollow Knight: Simulador básico ===");

            while (hpHornet > 0 && hpEnemigo > 0)
            {
                MostrarEstado(hpHornet, hpEnemigo);

                Console.Write("\nAcción (atacar/curar/salir):");
                string accion = Console.ReadLine();

                if (accion == "atacar")
                {
                    hpEnemigo = atacar(atkHornet, hpEnemigo);
                }
                else if (accion == "curar")
                {
                    hpHornet = curar(hpHornet, hpMaxHornet);
                }
                else if (accion == "salir")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Acción inválida");
                }
                if (hpEnemigo > 0)
                {
                    hpHornet -= 2;
                    Console.WriteLine("El enemigo contraataca y hace 2 de daño!");
                }

            }
            Console.WriteLine("\n === Resultado ===");
            if (hpHornet <= 0) Console.WriteLine("Hornet ha caido...");
            else if (hpEnemigo <= 0) Console.WriteLine("Hornet ha ganado!");
            else Console.WriteLine("Batalla interrumpida");
            Console.ReadKey();
        }

        static int atacar(int ataque, int vidaE)
        {
            int vidafinal = vidaE - ataque;
            return vidafinal;
        }
        static int curar(int vidaH, int MaxiVidaH)
        {
            int vidafinal;
            vidafinal = vidaH + 5;
            if ((vidaH + 5) >= MaxiVidaH)
            {
                vidafinal = vidaH + (MaxiVidaH - vidaH);
            }

            return vidafinal;
        }
        static void MostrarEstado(int Vidah, int VidaE)
        {
            Console.WriteLine("Hornet HP: " + Vidah + " | " + "Enemigo HP: " + VidaE);

        }
    }
}