using System;

class Programss
{
    static void Main()
    {
        Console.WriteLine("Nivel 1 – Validación de llave (LITE)");
        bool ok = Level1.ValidateAccessKey("WD-700000")
                  && !Level1.ValidateAccessKey("WD-123123")
                  && !Level1.ValidateAccessKey("WX-000007")
                  && !Level1.ValidateAccessKey("WD-00007");
        if (ok) Console.WriteLine("✔ UNLOCK → Fragmento: CT");
        else Console.WriteLine("🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level1
{
    // Debe devolver true solo si:
    // - Empieza por "WD-"
    // - Luego hay exactamente 6 dígitos
    // - La suma de esos 6 dígitos es múltiplo de 7
    public static bool ValidateAccessKey(string key)
    {
        char c;
        int num = 0;
        bool salir = false;
        if (key.StartsWith("WD-") && key.Length == 9 && char.IsDigit(key[3]) && char.IsDigit(key[4]) && char.IsDigit(key[5]) && char.IsDigit(key[6]) && char.IsDigit(key[7]) && char.IsDigit(key[8]))
        {
            for (int i = 3; i < 8; i++)
            {
                c = Convert.ToChar(key[i]);
                num = (c - '0') + num;

            }
            if (num % 7 == 0)
            {
                salir = true;
            }

        }
        // TODO: implementar
        return salir; // <- reemplazar por tu solución
    }
}