using System;
using System.Globalization;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pessoa p = new Pessoa();
            p.Nome = "Fulano da Silva";
            p.Altura = 175;

            CultureInfo idioma = new CultureInfo("pt-BR");
            String formato = "dd/MM/yyyy";
            p.DataDeNascimento = DateTime.ParseExact("29/02/2000", formato, idioma);
            p.CorDoCabelo = "Castanho";
            
            Console.WriteLine("Nome: {0}", p.Nome);
            Console.WriteLine("Altura: {0}", p.Altura);
            Console.WriteLine("Data de Nascimento: {0}", p.DataDeNascimento);
            Console.WriteLine("Cor do Cabelo: {0}", p.CorDoCabelo);
        }
    }
}