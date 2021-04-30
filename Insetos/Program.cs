using System;
using System.Globalization;

namespace Insetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Inseto chucrute = new Inseto("lagarta", 5.6, "verde");
            Console.WriteLine(chucrute.Especie); // usando o get
            Console.WriteLine(chucrute.Peso); // usando o get
            Console.WriteLine(chucrute.Peso = 5.7); // usando o set para engordar a lagarta
            
            Inseto foomegah = new Inseto("formiga", 1.6, "vermelha");
            Console.WriteLine(foomegah.Especie);
            Console.WriteLine(foomegah.Cor);

            Lacraia laracna = new Lacraia("lacraia de ralo", 2.2, "preta", 20);
            Console.WriteLine(laracna.Especie); // usando o get
            Console.WriteLine(laracna.ParesDePatas); // usando o get

            LacraiaDoInferno aquelaComChifres = new LacraiaDoInferno("lacria do inferno", 3.5, "preta", 8);
            Console.WriteLine(aquelaComChifres.Asas);
            aquelaComChifres.SairDoRio();
            Console.WriteLine(aquelaComChifres.Asas);


        }
    }
}