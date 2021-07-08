using System;
using System.Collections.Generic;

class MainClass {

  public static void Cadastrar(){
    Console.WriteLine("\n\nCadastro de Produto");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Preço: ");
    double preco = Convert.ToDouble(Console.ReadLine());
    Produto p = new Produto(nome, preco);
    p.Persistir();
  }

  public static void Buscar(){
    Console.Write("\n\nBuscar: ");
    string nome = Console.ReadLine();
    List<Produto> produtos = Produto.BuscarProdutos(nome);
    foreach(var produto in produtos)
    {
      produto.Imprimir();
    }
  }

  public static void Listar()
  {
    Console.WriteLine("\n");
    List<Produto> produtos = Produto.ConsultarProdutos();
    foreach(var produto in produtos)
    {
      produto.Imprimir();
    }
  }

  public static void Menu(){
    char opcao;
    do {
      Console.WriteLine("\nOpções: [C]adastrar [L]istar [B]uscar [S]air");
      opcao = Char.ToLower(Console.ReadKey().KeyChar);
      switch (opcao)
      {
        case 'c':
          Cadastrar();
          break;

        case 'l':
          Listar();
          break;
        
        case 'b':
          Buscar();
          break;

        case 's':
          break;

        default:
          Console.WriteLine("Opção Inválida!");
          break;
      } 
    } while (opcao != 's');
  }
  
  public static void Main (string[] args) {
    Console.WriteLine("Seja bem vindo ao cadastro de produtos!\n");
    Menu();
    Console.WriteLine("\nAté breve!");
  }
}