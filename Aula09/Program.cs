using System;

namespace Aula9
{
class Program
{
    static void Main(string[] args)
    {
        Classificacao jaguatirica = new Classificacao("Felidae", "Leopardus", "pardalis");
        Classificacao logoGuara = new Classificacao("Canidae", "Chrysocyon", "brachyurus");
        Classificacao cachorro = new Classificacao("Canidae", "Canis", "familiaris");
        Classificacao gato = new Classificacao("Felidae", "Felis", "catus");

        Selvagem s1 = new Selvagem("C5TFD00234", jaguatirica, DateTime.Parse("20/01/2018"), 12.5);
        Selvagem s2 = new Selvagem("B9GGF00147", logoGuara, DateTime.Parse("14/05/2017"), 22.7);
        Domestico c1 = new Domestico("Floquinha", cachorro, DateTime.Parse("07/06/2016"), 10.5);
        Domestico c2 = new Domestico("Baunilha", cachorro, DateTime.Parse("10/02/2017"), 6.3);
        Domestico g1 = new Domestico("Mel", gato, DateTime.Parse("09/12/2020"), 4.9);

        Humano p1 = new Humano("Zoroastra", "123.456.789-10", DateTime.Parse("07/03/1999"), 75.5);
        Humano p2 = new Humano("Hermenegildo", "109.876.543-21", DateTime.Parse("01/04/1998"), 85.6);
        
        p1.Adotar(c1);
        p2.Adotar(c2);
        p2.Adotar(g1);

        Console.WriteLine(s1.Imprimir());
        Console.WriteLine(s2.Imprimir());
        Console.WriteLine(c1.Imprimir());
        Console.WriteLine(c2.Imprimir());
        Console.WriteLine(g1.Imprimir());
        Console.WriteLine(p1.Imprimir());
        Console.WriteLine(p2.Imprimir());
    }
}
}