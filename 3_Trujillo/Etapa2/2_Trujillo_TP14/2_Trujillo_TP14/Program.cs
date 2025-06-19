using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            string[,] pochidex = new string[fila, columna];

            bool salir = true;
            int id = 0;
            string id_investigador;
            Random ale = new Random();
            // columnas del pochidex
             
            int nombre = 0;
            int tipo = 1;
            int nivel = 2;
            int estado = 3;
            int investigador = 4;

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
                Console.WriteLine("");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Ingresar Pochimon
                        // Registrar Pochimon: Permite al usuario registrar un nuevo Pochimon en la Pochidex. Se solicitarán todos los atributos del Pochimon excepto el estado y el investigador asignado, que se asignan automáticamente en 0.

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
                        // Asignar Investigador a Pochimon: Permite asignar un investigador a un Pochimon que no esté siendo investigado (estado 0), cambiando su estado a 1.
                        // Asignar Investigador a Pochimon: Mostrará una lista de Pochimons no investigados (estado 0) y permitirá al usuario seleccionar uno. Luego, solicitará el código numérico del investigador para asignarlo al Pochimon y cambiará su estado a 1.
                        Console.WriteLine("|ID\t" + "|Nombre\t" + "\t" + "|Tipo\t" + "|Nivel\t" + "|Estado\t" + "\t" + "|Investigador");
                        for (int i = 0; i < (encontrado + 1); i++)
                        {
                            if (pochidex[i, estado] == "0")
                            {
                                Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t"  + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t" + "|" + pochidex[i, estado] + "\t" + "|" + pochidex[i, investigador]);
                            }
                        }
                        Console.WriteLine("");
                        Console.Write("Elija un pochimon para investigar, ingrese su ID: ");
                        id = (int.Parse(Console.ReadLine())) - 1;
                        Console.WriteLine("Usted a elegido a :");
                        Console.WriteLine("|ID\t" + "|Nombre\t" + "|Tipo\t" + "|Nivel\t" + "|Estado\t" + "|Investigador");
                        Console.WriteLine("|" + (id + 1) + "\t" + "|" + pochidex[id, nombre] + "\t" + "|" + pochidex[id, tipo] + "\t" + "|" + pochidex[id, nivel] + "\t" + "|" + pochidex[id, estado] + "\t" + "|" + pochidex[id, investigador]);
                        Console.WriteLine("");
                        Console.Write("Ingrese el ID del investigador: ");
                        id_investigador = (Console.ReadLine());
                        Console.WriteLine("El pochimon estará en investigación");
                        pochidex[id, investigador] = id_investigador;
                        pochidex[id, estado] = "1";





                        break;
                    case 3:
                        //Actualizar Nivel de Pochimon: Permite al usuario actualizar el nivel de un Pochimon. Se muestra una lista de Pochimons con su ID y nombre, y el usuario selecciona cuál desea aumentar de nivel en un número aleatorio entre 1 y 3
                        // Actualizar Nivel de Pochimon: Permitirá al usuario ingresar el número de fila de un Pochimon y su nuevo nivel se incrementará en un número aleatorio entre 1 y 3.
                        Console.WriteLine("|ID\t" + "|Nombre\t");
                        for (int i = 0; i < (encontrado); i++)
                        {
                            Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t");
                        }
                        Console.Write("Elija al pochimon, ingrese su ID: ");
                        id = int.Parse(Console.ReadLine()) - 1;
                        int aleatorio = ale.Next(1, 3);
                        int subidanivel = int.Parse(pochidex[id, nivel]) + aleatorio;
                        pochidex[id, nivel] = subidanivel.ToString();
                        if (aleatorio == 1)
                        {
                            Console.WriteLine("+ " + aleatorio + " nivel");
                        }
                        else
                        {
                            Console.WriteLine("+ " + aleatorio + " niveles");
                        }
                        Console.WriteLine("Su Pochimon tiene " + pochidex[id, nivel] + " Niveles");
                        Console.WriteLine("");
                        break;
                    case 4:
                        // Marcar Pochimon como Investigado: Muestra a todos los Pochimons que se encuentran en estado de investigación y permite cambiar el estado de un Pochimon de "en investigación" a "investigado".
                        // Marcar Pochimon como Investigado: Mostrará todos los Pochimons en estado de investigación y permitirá cambiar el estado de un Pochimon de "en investigación" a "investigado".
                        Console.WriteLine("|ID\t" + "|Nombre\t" + "|Tipo\t" + "|Nivel\t" + "|Estado\t" + "|Investigador");

                        for (int i = 0; i < (encontrado + 1); i++)
                        {
                            if (pochidex[i, estado] == "1")
                            {
                                Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "\t" + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t" + "|" + pochidex[i, estado] + "\t" + "|" + pochidex[i, investigador]);
                            }
                        }

                        Console.Write("Eliga el Pochimon que desee terminar de investigar, ingrese su ID: ");
                        id = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("El Pochimon termino de ser investigador");
                        pochidex[id, estado] = "1";
                        break;
                    case 5:
                        //Mostrar Información de Pochimons: Muestra la información de todos los Pochimons registrados en la Pochidex.
                        // Mostrar Información de Pochimons: Mostrará en pantalla todos los Pochimons registrados con todos sus atributos.
                        Console.WriteLine("|ID\t" + "|Nombre\t" + "|Tipo\t" + "|Nivel\t" + "|Estado\t" + "|Investigador");
                        for (int i = 0; i < (encontrado + 1); i++)
                        {
                            if (pochidex[i, estado] == "1")
                            {
                                Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "\t" + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t" + "|" + pochidex[i, estado] + "\t" + "|" + pochidex[i, investigador]);
                            }
                        }



                        break;
                    case 6:
                        // Buscar Pochimons por Tipo: Permite buscar y mostrar Pochimons según el tipo ingresado por el usuario.
                        // Buscar Pochimons por Tipo: Solicitará al usuario ingresar un tipo y mostrará todos los Pochimons que coincidan con ese tipo.
                        Console.Write("Ingrese el tipo de Pochimon que busca (A,F,P)");
                        string clase = Console.ReadLine();
                        Console.WriteLine("|ID\t" + "|Nombre\t" + "|Tipo\t" + "|Nivel\t" + "|Estado\t" + "|Investigador");
                        for (int i = 0; i < (encontrado + 1); i++)
                        {
                            if (pochidex[i, tipo] == clase)
                            {
                                Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "\t" + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t" + "|" + pochidex[i, estado] + "\t" + "|" + pochidex[i, investigador]);
                            }
                        }


                        break;
                    case 7:
                        // Mostrar Pochimons por Investigador: Muestra todos los Pochimons asignados a un investigador específico.
                        // Mostrar Pochimons por Investigador: Solicitará al usuario ingresar el código numérico de un investigador y mostrará todos los Pochimons asignados a ese investigador.

                        Console.Write("Ingrese el código de investigador :");
                        id_investigador = Console.ReadLine();

                        Console.WriteLine("|ID\t" + "|Nombre\t" + "|Tipo\t" + "|Nivel\t" + "|Estado\t" + "|Investigador");
                        for (int i = 0; i < (encontrado + 1); i++)
                        {
                            if (pochidex[i, investigador] == id_investigador)
                            {
                                Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "\t" + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t" + "|" + pochidex[i, estado] + "\t" + "|" + pochidex[i, investigador]);
                            }
                        }

                        break;
                    case 8:
                        // Mostrar Pochimons Picados: Muestra todos los Pochimons cuyo nivel es mayor a 30.
                        // Mostrar Pochimons Picados: Mostrará todos los Pochimons cuyo nivel es mayor a 30.
                        Console.WriteLine("|ID\t" + "|Nombre\t" + "|Tipo\t" + "|Nivel\t" + "|Estado\t" + "|Investigador");
                        for (int i = 0; i < (encontrado + 1); i++)
                        {
                            Console.WriteLine("|" + (i + 1) + "\t" + "|" + pochidex[i, nombre] + "\t" + "\t" + "|" + pochidex[i, tipo] + "\t" + "|" + pochidex[i, nivel] + "\t" + "|" + pochidex[i, estado] + "\t" + "|" + pochidex[i, investigador]);
                        }

                        break;
                    case 9:
                        // Salir: Opción para salir del programa.
                        // Salir: Finalizará el programa.
                        Console.WriteLine("Gracias por usar el programa");
                        salir = false;

                        break;
                }

                Console.Clear();
            } while (salir);
        }
    }
}