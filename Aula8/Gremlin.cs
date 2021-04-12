using System;
using System.Collections.Generic;

namespace Aula8
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
    public void Falar()
    {
        if (this.NivelDeMaldade == 0)
            Console.WriteLine("Squeek! {0} <3", this.Nome);
        if (this.NivelDeMaldade == 1)
            Console.WriteLine("Hehehe grlewwwbl {0} Hehehe!", this.Nome);
        if (this.NivelDeMaldade == 2)
            Console.WriteLine("Ahahahah! {0} Grrrr waaaarrrgl", this.Nome);
        if (this.NivelDeMaldade == 3)
            Console.WriteLine("Muahahahaa! {0} @!@*$#&$@!!@#&", this.Nome);
    }

    public static void Instrucoes()
    {
        Console.WriteLine("Os gremlins são criaturas peludas fofas, mas que não devem ser alimentadas, pois conforme comem vão se tornando cada vez mais malignas. Em hipótese alguma molhe seu gremlin, pois isso fará com que ele se multiplique!");
    }
}
}