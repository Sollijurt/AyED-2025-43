using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Trujillo_TP14
{
    class Program
    {
        static void Main()
        {
            int fila = 75, columna = 6;
            string[,] pochidex = new string[fila,columna];
            bool salir = true;
            
            // columnas del pochidex
            int nombre = 1;
            int tipo = 2;
            int nivel = 3;
            int estado = 4;
            int investigador = 5;
           
            int encontrado = 0;

            do
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Menú Principal - Centro de Investigación de Pochimons");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Pochimones encontrados: " + (encontrado) + "/75");

                Console.WriteLine("1. Registrar Pochimon");
                Console.WriteLine("2. Asignar investigador Pochimon");
                Console.WriteLine("3. Actualizar nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como investigado");
                Console.WriteLine("5. Mostrar información de Pochimon");
                Console.WriteLine("6. Buscar Pochimons por tipo");
                Console.WriteLine("7. Mostrar Pochimons por investigador");
                Console.WriteLine("8. Mostrar Pochimons picados");
                Console.WriteLine("9. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Ingresar Pochimon
                        Console.Write("Ingrese el nombre del Pochimon: ");
                        pochidex[encontrado, nombre] = Console.ReadLine();
                        Console.Write("Ingrese el tipo del Pochimon (A/F/P): ");
                        pochidex[encontrado, tipo] = Console.ReadLine();
                        Console.Write("Ingrese el nivel del Pochimon: ");
                        pochidex[encontrado, nivel] = Console.ReadLine();
                        pochidex[encontrado, estado] = "0";
                        pochidex[encontrado, investigador] = "0";
                        encontrado = encontrado + 1;
                        break;
                    case 2:
                        
                        Console.WriteLine("|Fila\t" + "|Nombre\t" + "|Tipo\t" + "|Nivel\t");
                        // for para buscar en la pochi dex lo que no esten investigados
                        for (int i = 0; i<(encontrado +1); i++)
                        {

                        }
                        break;
                }


            } while (salir);
        }
    }
}
