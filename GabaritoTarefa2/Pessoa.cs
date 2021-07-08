using System;

namespace GabaritoTarefa2
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private DateTime DataDeNascimento { get; set; }
        private int Altura { get; set; }
        private string CorDoCabelo { get; set; }


        public Pessoa(string nome, DateTime dataDeNascimento, int altura, string corDoCabelo)
        {
            this.Nome = nome;
            this.DataDeNascimento = dataDeNascimento;
            this.Altura = altura;
            this.CorDoCabelo = corDoCabelo;
        }

        public void ImprimirPessoa()
        {
            Console.WriteLine("Nome:\t\t\t{0}", this.Nome);
            Console.WriteLine("Data de Nascimento:\t{0}", this.DataDeNascimento);
            Console.WriteLine("Altura:\t\t\t{0}", this.Altura);
            Console.WriteLine("Cor do Cabelo:\t\t{0}", this.CorDoCabelo);
        }
    }
}