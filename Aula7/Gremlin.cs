using System;

namespace Aula7
{
public class Gremlin
{
    public String Nome;
    public Int32 NivelDeMaldade;

    public Gremlin(String Nome)
    {
        this.Nome = Nome;
        this.NivelDeMaldade = 0;
    }

    public void Alimentar()
    {
        if (this.NivelDeMaldade < 3)
            this.NivelDeMaldade++;
    }
}
}