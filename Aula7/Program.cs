using System;

namespace Aula7
{
class Program
{
    static void Main(string[] args)
    {
        Gremlin g = new Gremlin("Gizmo");
        Console.WriteLine(g.Nome);
        Console.WriteLine(g.NivelDeMaldade);
        g.Alimentar();
        Console.WriteLine(g.NivelDeMaldade);
    }
}
}