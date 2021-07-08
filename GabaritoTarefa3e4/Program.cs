using System;
using System.Collections.Generic;

namespace GabaritoTarefa3e4
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Console.WriteLine("Seja bem vindo à Loja Mágica!");
            Dictionary<string, Item> catalogo = CarregarCatalogo();

            Personagem p = new Personagem("Hilda");
            
            do
            {
                Console.WriteLine("Este é nosso catálogo:");
                ImprimirCatalogo(catalogo);
                
                
                p.ImprimirPersonagem();
                Console.Write("Digite o nome do item que deseja comprar ou 'sair': ");
                opcao = Console.ReadLine();

                if (catalogo.ContainsKey(opcao) && opcao != "sair")
                {
                    Console.WriteLine("Deseja comprar o item abaixo?");
                    catalogo[opcao].ImprimirItem();
                    
                    Console.WriteLine("[S]im/[N]ão: ");
                    string confirmacao = Console.ReadLine().ToLower();

                    if (confirmacao.ToLower() == "s" || confirmacao.ToLower() == "sim")
                    {
                        p.ComprarItem(catalogo[opcao]);
                    }

                } else if (!catalogo.ContainsKey(opcao) && opcao != "sair")
                {
                    Console.WriteLine("Desculpe, não tenho esse produto no catálogo.");
                }

                
            } while (opcao != "sair");
        }

        static Dictionary<string, Item> CarregarCatalogo()
        {
            Dictionary<string, Item> catalogo = new Dictionary<string, Item>();

            Item item = new Item("Cachecol", "Cachecol para aquecer em dias frios", 20);
            catalogo[item.Nome.ToLower()] = item;
            item = new Item("Lenha", "Lenha para lareira", 5);
            catalogo[item.Nome.ToLower()] = item;
            item = new Item("Contrato élfico", "Contrato para enchergar elfos", 5);
            catalogo[item.Nome.ToLower()] = item;
            item = new Item("Prancheta", "Prancheta de desenho", 80);
            catalogo[item.Nome.ToLower()] = item;
            item = new Item("Livro de feitiços", "Livro mágico com feitiços e bruxarias", 150);
            catalogo[item.Nome.ToLower()] = item;
            item = new Item("Corda", "Corda para sair de buracos de Vittra", 20);
            catalogo[item.Nome.ToLower()] = item;

            return catalogo;

        }

        static void ImprimirCatalogo(Dictionary<string, Item> catalogo)
        {
            foreach (var item in catalogo)
            {
                Console.WriteLine("\n---------------------");
                Console.WriteLine("[{0}]", item.Key);
                item.Value.ImprimirItem();
            }
        }
    }
}