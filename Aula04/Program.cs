using System;
using System.Globalization;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pessoa minhaPessoa = new Pessoa();
            
            minhaPessoa.Nome = "Fulano da Silva";
            minhaPessoa.Altura = 175;
            minhaPessoa.CorDoCabelo = "Castanho";

            Console.WriteLine("Nome: {0}", minhaPessoa.Nome);
            Console.WriteLine("Altura: {0}", minhaPessoa.Altura);
            Console.WriteLine("Cor do Cabelo: {0}", minhaPessoa.CorDoCabelo);
            
            DateTime minhaData = new DateTime(2000, 2, 29);
            minhaPessoa.DataDeNascimento = minhaData;
            Console.WriteLine("Data de Nascimento: {0}", minhaPessoa.DataDeNascimento);
        }
    }
}