using System;
using System.Collections.Generic;

namespace GabaritoTarefa2
{
    class Program
    {

        static void Incluir(List<Pessoa> pessoas)
        {
            Console.WriteLine("\nIncluir Pessoa");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Altura: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cor do cabelo: ");
            string corDoCabelo = Console.ReadLine();

            Pessoa p = new Pessoa(nome, dataNascimento, altura, corDoCabelo);
            pessoas.Add(p);
        }

        static void Imprimir(List<Pessoa> pessoas)
        {
            Console.WriteLine("======Pessoas cadastradas======");
            foreach (var p in pessoas)
            {
                Console.WriteLine("\n-----------------");
                p.ImprimirPessoa();
            }
            Console.WriteLine("===============================");
        }
        static void Main(string[] args)
        {
            int opcao;
            List<Pessoa> pessoas = new List<Pessoa>();
            do
            {
                Console.WriteLine("Sistema de Cadastro de Pessoas - Opções disponíveis:");
                Console.WriteLine("[1] Incluir");
                Console.WriteLine("[2] Consultar");
                Console.WriteLine("[0] Sair\n");
                Console.Write("Opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Incluir(pessoas);
                        break;
                    case 2:
                        Imprimir(pessoas);
                        break;
                    case 0:
                        Console.WriteLine("Adeus!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }
    }
}