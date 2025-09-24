using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
        string msg = "ctOS";
        string enc = Level4.CaesarPlusOne(msg);
        bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
        Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level4
{
    public static string CaesarPlusOne(string s)
    {
        int num;
        string solu = "";
        char c, j;
        for (int i = 0; i < 4; i++)
        {
            c = s[i];
            num = c - '1';
            j = Convert.ToChar(num + 50);
            solu = solu + j.ToString();
        }
        // TODO: implementar
        // Reglas: letras rotan (z→a, Z→A), mantener may/min; otros chars, igual.
        return solu; // <- reemplazar por tu solución
    }
}
