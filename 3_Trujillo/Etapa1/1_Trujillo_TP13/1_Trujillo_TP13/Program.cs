using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Trujillo_TP13
{
    class Program
    {
        static void Main()
        {
            Boolean salir = true;
            int opcion = 0;
            Console.WriteLine("Bienvenido al programa");
            Console.WriteLine("Ingrese su nombre");
            string usuario = Console.ReadLine();
            do
            {
                DateTime tiempo = DateTime.Now;
                DateTime fecha = tiempo.Date;
                TimeSpan hora = tiempo.TimeOfDay;

                Console.WriteLine("Escriba 1 para saludarlo");
                Console.WriteLine("Escriba 2 para saber la hora");
                Console.WriteLine("Escriba 3 Para saber la fecha");
                Console.WriteLine("Escriba 4 para salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Hola " + usuario);
                        break;
                    case 2:
                        Console.WriteLine("La fecha actual es " + fecha);
                        break;
                    case 3:
                        Console.WriteLine("La hora actual es " + hora);
                        break;
                    case 4:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("Fuera del rango (1,2,3,4)");
                        break;
                }
            

            } while (salir);

            
        }
    }
}
