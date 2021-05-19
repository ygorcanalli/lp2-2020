using System;

namespace Aula8
{
class Program
{
    static void Main(string[] args)
    {
        Gremlin g = new Gremlin("Gizmo");
        Gremlin t = new Gremlin("Taribo");
        g.Falar();
        g.Alimentar();
        g.Falar();
        g.Alimentar();
        g.Falar();
        g.Alimentar();
        g.Falar();
        g.Alimentar();
        g.Falar();
        g.Alimentar();
        t.Falar();
        Gremlin.Instrucoes();
    }
}
}