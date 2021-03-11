using System;
using System.Collections.Generic;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Casa minhaCasa = new Casa();
            minhaCasa.Endereco = "Rua das abobrinhas 20, País das Maravilhas";
            minhaCasa.MetragemQuadrada = 77.5;
            minhaCasa.QuantidadeDeComodos = 5;
            minhaCasa.DataDeConstrucao = new DateTime(1920, 7, 15);
            minhaCasa.Residentes = new List<Pessoa>();

            Pessoa minhaPessoa = new Pessoa();
            minhaPessoa.Nome = "Fulano da Silva";
            minhaPessoa.Altura = 175;
            minhaPessoa.CorDoCabelo = "Castanho";
            minhaPessoa.DataDeNascimento = new DateTime(2000, 2, 29);
            minhaPessoa.Residencia = minhaCasa;

            Pessoa outraPessoa = new Pessoa();
            outraPessoa.Nome = "Beltrana Oliveira";
            outraPessoa.Altura = 165;
            outraPessoa.CorDoCabelo = "Preto";
            outraPessoa.DataDeNascimento = new DateTime(1998, 4, 15);
            outraPessoa.Residencia = minhaCasa;

            minhaCasa.Residentes.Add(minhaPessoa);
            minhaCasa.Residentes.Add(outraPessoa);
        }
    }
}