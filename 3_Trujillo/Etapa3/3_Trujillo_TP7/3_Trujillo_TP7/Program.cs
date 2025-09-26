using static System.Runtime.InteropServices.JavaScript.JSType;

static void main()
{
    bool salir = true;
    string[] nombre = new string[20];
    string[] saga = new string[20];
    int[] fuerza = new int[20];
    int[] defensa = new int[20];
    bool[] esHeroe = new bool[20];
    int cant_pers = 0, pos = 0;

    string auxi = "";
    bool auxisalir = true;

    do
    {

        auxisalir = true;
        Console.WriteLine("== Bordelans MVM ==");
        Console.Write("Menu" + "\n" + "1) Ingresar nuevo personaje" + "\n" + "2) Consultar personaje por nombre" + "\n" + "3) Modificar personaje" + "\n" + "4) Eliminar personaje" + "\n" + "5) Mostrar todos los personajes" +"\n"+ "6) Salir del programa" + "\n" + "Eliga una opción: ");
        string opcion = Console.ReadLine();

        switch(opcion)
        {
            case "1":
                Nuevo_Personaje(auxi, pos, cant_pers, nombre, saga, fuerza, defensa, esHeroe);
                cant_pers++;
                break;
            case "2":
                BuscarPersonaje(auxi,nombre, saga, fuerza, defensa,  cant_pers, esHeroe);
                break;
            case "3":
                ModificarPersonaje(auxi,nombre, saga, fuerza, defensa,cant_pers, esHeroe, pos);
                    break;
            case "4":
                EliminarPersonaje(auxi,nombre, saga, fuerza, defensa, cant_pers, esHeroe, pos);
                cant_pers--;
                    break;
            case "5":
                MostrarOrdenados(auxi,nombre, saga, fuerza,defensa, cant_pers, esHeroe, pos);
                break; 
            case "6":
                Console.WriteLine("Gracias por usar el programa");
                salir = false;
                break; 
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
        Console.WriteLine("Presione cualquier tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    } while (salir);
}
static void Nuevo_Personaje(string auxi, int pos, int cant_pers, string[] nombre, string[] saga, int[] fuerza, int[] defensa, bool[] esHeroe)
{
    bool auxisalir = true;
    do
    {
        auxi = SinNulos(auxi, "Ingrese el nombre: ");
        pos = BuscarIguales(nombre, saga, fuerza, defensa, false, cant_pers, auxi, esHeroe);
        if (pos > -1 )
        {
            Console.WriteLine("Nombre ya existente, ingrese otro nuevamente");
        }
    } while (pos > -1);

    nombre[cant_pers] = EsNumero(auxi, false);

    auxi = SinNulos(auxi, "Ingrese la saga: ");
    saga[cant_pers] = EsNumero(auxi, false);

    auxi = SinNulos(auxi, "Ingrese la fuerza: ");
    fuerza[cant_pers] = int.Parse(EsNumero(auxi, true));

    auxi = SinNulos(auxi, "Ingrese la defenza: ");
    defensa[cant_pers] = int.Parse(EsNumero(auxi, true));
    do
    {
        auxisalir = true;
        Console.Write("¿Que es?" + "\n" + "1) Heroe" + "\n" + "2) Villano" + "\n" + "Eliga una opción: ");
        auxi = Console.ReadLine();
        switch (auxi)
        {
            case "1":
                esHeroe[cant_pers] = true;
                auxisalir = false;
                break;
            case "2":
                esHeroe[cant_pers] = false;
                auxisalir = false;
                break;
            default:
                Console.WriteLine("Opcion invalida ");
                break;
        }
    } while (auxisalir);
    
}

static void BuscarPersonaje(string auxi, string[] nombre, string[] saga, int[] fuerza, int[] defensa, int cant_pers, bool[] esHeroe)
{
    Console.Write("" + "\n" + "Ingrese el nombre para buscar al personaje: ");
    auxi = Console.ReadLine();
    if (BuscarIguales(nombre, saga, fuerza, defensa, true, cant_pers, auxi, esHeroe) == -1)
    {
        Console.WriteLine("No se encontro el personaje");
    }
}

static void ModificarPersonaje(string auxi, string[] nombre, string[] saga, int[] fuerza, int[] defensa, int cant_pers, bool[] esHeroe,int pos)
{
    
    Console.Write("" + "\n" + "Ingrese el nombre para buscar al personaje: ");
    auxi = Console.ReadLine();

    pos = BuscarIguales(nombre, saga, fuerza, defensa, false, cant_pers, auxi, esHeroe);

    if (pos == -1)
    {
        Console.WriteLine("No se encontro el personaje");
    }
    else
    {
        Console.WriteLine("¿Que desea modificar?");
        Console.Write("1) Fuerza" + "\n" + "2) Defensa" + "\n" + "Ingrese su opción: ");
        auxi = Console.ReadLine();
        switch (auxi)
        {
            case "1":
                auxi = SinNulos(auxi, "Ingrese el nuevo valor fuerza:");
                fuerza[pos] = int.Parse(EsNumero(auxi, true));
                break;
            case "2":
                auxi = SinNulos(auxi, "Ingrese el nuevo valor de defensa: ");
                defensa[pos] = int.Parse(EsNumero(auxi, true));
                break;
        }
    }
}

static void EliminarPersonaje(string auxi, string[] nombre, string[] saga, int[] fuerza, int[] defensa, int cant_pers, bool[] esHeroe, int pos)
{
    Console.Write("" + "\n" + "Ingrese el nombre para eliminar al personaje: ");
    auxi = Console.ReadLine();

    pos = BuscarIguales(nombre, saga, fuerza, defensa, false, cant_pers, auxi, esHeroe);

    if (pos == -1)
    {
        Console.WriteLine("No se encontro el personaje");
    }
    else
    {
        for (int i = pos; i < cant_pers - 1; i++)
        {
            
            nombre[i] = nombre[i + 1];
            saga[i] = saga[i + 1];
            fuerza[i] = fuerza[i + 1];
            defensa[i] = defensa[i + 1];
            esHeroe[i] = esHeroe[i + 1];
        }
        nombre[pos] = "";
        saga[pos] = "";
        fuerza[pos] = 0;
        defensa[pos] = 0;
        esHeroe[pos] = false;
    }
}

static void MostrarOrdenados(string auxi, string[] nombre, string[] saga, int[] fuerza, int[] defensa, int cant_pers, bool[] esHeroe, int pos)
{
    Console.WriteLine("Num\t" + "Nombre\t" + "Saga\t" + "Ataque\t" + "Defensa\t" + "Rol");
    int[] indices = new int[cant_pers];
    for (int i = 0; i < cant_pers; i++) indices[i] = i;
    Array.Sort(nombre, indices, 0, cant_pers);
    for (int g = 0;g < cant_pers; g++)
    {
        Console.Write((g + 1) + "\t");
        Personaje(nombre, saga, fuerza, defensa, esHeroe, g);
        rol(esHeroe, g);
        Console.WriteLine();
    }
}



// funciones funcionales

static string SinNulos(string auxi, string reescrito )
{
    bool auxisalir = true;
    Console.Write("" + "\n" + reescrito );
    auxi = Console.ReadLine();
    do
    { 
        auxisalir = true;
        if (auxi.Trim() == "")
        {
            Console.WriteLine("No se puede ingresar nulos");
            Console.Write("" + "\n" + reescrito);
            auxi = Console.ReadLine();
        }
        else
        {
            auxisalir = false;
        }
        
    } while (auxisalir);
    return auxi;
}
static int BuscarIguales(string[] nombre, string[] saga, int[] fuerza, int[] defensa, bool mostrar, int cant, string auxi, bool[] esHeroe)
{
    for (int i = 0; i < cant; i++)
    {
        if (auxi.ToLower() == nombre[i].ToLower())

        {
            if (mostrar)
            {
                Console.WriteLine("\nPersonaje encontrado:");
                Console.WriteLine("Num\t" + "Nombre\t" + "Saga\t" + "Ataque\t" + "Defensa\t" + "Rol");
                Console.Write((i+1) + "\t");
                Personaje(nombre, saga, fuerza, defensa, esHeroe, i);
                
                rol(esHeroe, i);
                Console.WriteLine(); 
            }
            return i;
        }
    }
    return -1; 
}

static void rol(bool[] esHeroe, int pos)
{
    if (esHeroe[pos])
    {
        Console.Write("\tHeroe");
    }
    else
    {
        Console.WriteLine("\tVillano");
    }
}

static string EsNumero(string auxi, bool letra)
{
    int verificar, num = 0;
    bool auxiliar = true;
    do
    {
        if(letra)
        {
            if (int.TryParse(auxi, out verificar))
            {
                auxiliar = false;
            }
            else
            {
                auxiliar = true;
                Console.WriteLine("Eso no es un número");
                Console.Write("Ingrese nuevamente un número: ");
                auxi = Console.ReadLine();

            }
        }
        else
        {
            if (int.TryParse(auxi, out verificar))
            {
                auxiliar = true;
                Console.WriteLine("Eso no es un texto");
                Console.Write("Ingrese nuevamente un texto: ");
                auxi = Console.ReadLine();
            }
            else
            {
                auxiliar = false;
            }
        }
        
    }while (auxiliar);
    return auxi;
}




static void Personaje(string[] nombre, string[] saga, int[] fuerza, int[] defensa, bool[] esHeroe, int i)
{
    Console.Write(nombre[i] + "\t" + saga[i] + "\t" + fuerza[i] +"\t" + defensa[i]);
}



main();