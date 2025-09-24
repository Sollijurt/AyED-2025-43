using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Trujillo_TP6
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("=== Mini Balatro (versión simplificado) ===");

            string[] mano = GenerarManoAleatoria();

            string tipo = TipoMano(mano);

            int basePts = puntajebase(mano);

            double mult = multiplicador(tipo);

            double total = basePts * mult;

            bool Joker2X = true;

            bool jokermas10 = true;

            total = AplicarJokers(total, Joker2X, jokermas10);


            MostrarResumen(mano, tipo, basePts, mult, total);
            Console.ReadKey();
        }
        static string[] GenerarManoAleatoria()
        {
            Random rand = new Random();

            string[] ValorCartas = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] PalosAsignados = { "H", "D", "C", "S" };
            string[] mano = new string[5];

            for (int i = 0; i < 5; i++)
            {
                mano[i] = ValorCartas[rand.Next(0, 12)] + PalosAsignados[rand.Next(0, 3)];
            }

            return mano;
        }
        static string TipoMano(string[] m)
        {
            string[] mano = { "Poker", "Full", "Trio", "Par", "Nada" };
            string ayuda2 = "";
            int num = 0;

            for (int i = 0; i < 5; i++)
            {
                string ayuda = m[i];
                ayuda2 += ayuda[0];
            }
            switch (busquedamano(ayuda2))
            {
                case 6:
                    num = 0;
                    break;
                case 4:
                    num = 1;
                    break;
                case 3:
                    num = 2;
                    break;
                case 1:
                    num = 3;
                    break;
                default:
                    num = 4;
                    break;
            }

            return mano[num];
        }
        static int busquedamano(string m)
        {
            int conta = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (m[i] == m[j])
                    {
                        conta++;
                    }
                }
            }
            return conta;
        }
        static int puntajebase(string[] m)
        {
            char ayudin;
            string ayuda2 = "";
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                string ayuda = m[i];
                ayuda2 += ayuda[0];
            }
            for (int i = 0; i < 5; i++)
            {
                ayudin = ayuda2[i];
                switch (ayudin)
                {
                    case 'A':
                        suma = suma + 14;
                        break;
                    case 'K':
                        suma = suma + 13;
                        break;
                    case 'Q':
                        suma = suma + 12;
                        break;
                    case 'J':
                        suma = suma + 11;
                        break;
                    case 'T':
                        suma = suma + 10;
                        break;
                    default:
                        suma = suma + (ayudin - '0');
                        break;
                }
            }

            return suma;
        }
        static double multiplicador(string tipo)
        {
            double num = 0;
            switch (tipo)
            {
                case "Poker":
                    num = 4.0;
                    break;
                case "Full":
                    num = 3.5;
                    break;
                case "Trio":
                    num = 2.5;
                    break;
                case "Par":
                    num = 1.5;
                    break;
                default:
                    num = 1.0;
                    break;
            }

            return num;
        }
        static double AplicarJokers(double total, bool jokerx2, bool joker10)
        {
            if (jokerx2)
            {
                total = total * 2;
            }
            if (joker10)
            {
                total = total + 10;
            }

            return total;
        }
        static void MostrarResumen(string[] m, string tipo, int puntos, double mult, double total)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(m[i] + " ");
            }
            Console.WriteLine("\n" + "El tipo de mano es: " + tipo);
            Console.WriteLine("Las fichas bases son: " + puntos);
            Console.WriteLine("El multi del tipo de mano: " + mult);
            Console.WriteLine("El total es: " + total);
        }

    }
}

