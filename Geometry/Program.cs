// See https://aka.ms/new-console-template for more information
using Geometry;
using System.Drawing;

Console.WriteLine("Scegli la forma: C = cerchio, T = triangolo");
ConsoleKeyInfo key = Console.ReadKey();

MethodIf(key);

Console.ReadLine();

static void MethodIf(ConsoleKeyInfo key)
{
    if (key.KeyChar == 'C')
    {
        Circle c = new Circle();
        Console.WriteLine("Inserisci il raggio: ");
        string text = Console.ReadLine() ?? "0";
        float r = Convert.ToSingle(text);

        c.Raggio = r;
        Console.WriteLine($"Area del cerchio è : {c.Area}");
    }
    else if (key.KeyChar == 'T')
    {
        Triangle t = new Triangle();

        Console.WriteLine();
        Console.WriteLine("Inserisci la base: ");
        string text = Console.ReadLine() ?? "0";
        float b = Convert.ToSingle(text);

        t.Base = b;

        Console.WriteLine();
        Console.WriteLine("Inserisci l'altezza: ");
        text = Console.ReadLine() ?? "0";
        float h = Convert.ToSingle(text);

        t.Height = h;

        Console.WriteLine($"Area del triangolo: {t.Area}");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Hai sbagliato tasto!");
    }
}