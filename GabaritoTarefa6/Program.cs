using System;
using System.Collections.Generic;

namespace GabaritoAula6
{
    class Program
    {
        static void Main(string[] args)
        {

            Fornecedor michaelsoft = new Fornecedor("Michaelsóft", "12.345.678/0009-10");
            Fornecedor adolbo = new Fornecedor("Adolvo", "10.987.654/0003-21");
            Fornecedor dehul = new Fornecedor("Dehul", "12.678.345/0001-23");
            
            Licensa rwindols = new Licensa("Michaelsóft Rwildols", 699.90, "SUAA-HE52-W6WG-B8Y9", michaelsoft);
            Assinatura alface123 = new Assinatura("Michaelsóft Alface", 39.90, 12, "5GNX-VM6Y-L6W8-SCPC", michaelsoft);
            Assinatura cottonshopi =
                new Assinatura("Aldobo Cottonshopi", mensalidade: 89.90, 12, "H84A-8QDF-4XPT-A2WZ", adolbo);
            Assinatura premillere =
                new Assinatura("Aldobo Premillere", mensalidade: 89.90, 12, "RLBD-YTRZ-UPH7-VQGM", adolbo);

            ProdutoFisico mausi = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99, dehul);
            ProdutoFisico lepetope = new ProdutoFisico("Lepetope Dehul", 3499.90, 123.45, dehul);

            Estoque estoque = new Estoque();
            estoque.Adicionar(rwindols, Int32.MaxValue);
            estoque.Adicionar(alface123, Int32.MaxValue);
            estoque.Adicionar(cottonshopi, Int32.MaxValue);
            estoque.Adicionar(premillere, Int32.MaxValue);
            estoque.Adicionar(mausi, 100);
            estoque.Adicionar(lepetope, 3);
            
            Cliente hermenegildo = new Cliente("Hermenegildo Benevides", "123.456.789-10");
            Cliente zoroastra = new Cliente("Zoroastra Muad'dib", "109.876.543-21");

            Carrinho carrinhoHermenegildo = new Carrinho();
            
            carrinhoHermenegildo.Adicionar(rwindols);
            carrinhoHermenegildo.Adicionar(alface123, 3);
            carrinhoHermenegildo.Adicionar(cottonshopi);
            carrinhoHermenegildo.Adicionar(premillere);
            carrinhoHermenegildo.Adicionar(mausi, 3);
            carrinhoHermenegildo.Adicionar(lepetope, 2);

            Compra compraHermenegildo = new Compra(hermenegildo, DateTime.Now, carrinhoHermenegildo, estoque);
            
            Carrinho carrinhoZoroastra = new Carrinho();
            
            carrinhoZoroastra.Adicionar(rwindols, 50);
            carrinhoZoroastra.Adicionar(alface123, 50);
            carrinhoZoroastra.Adicionar(mausi, 50);
            carrinhoZoroastra.Adicionar(lepetope, 5);

            Compra compraZoroastra = new Compra(zoroastra, DateTime.Now, carrinhoZoroastra, estoque);

            Relatorio relatorioFornecedores =
                new Relatorio("Relatório de Fornecedores", "Todos os nossos fornecedores");
            relatorioFornecedores.AdicionarItem(michaelsoft);
            relatorioFornecedores.AdicionarItem(adolbo);
            relatorioFornecedores.AdicionarItem(dehul);
            relatorioFornecedores.ImprimirRelatorio();

            Relatorio relatorioCompras = new Relatorio("Relatório de compras", "Compras realizadas no dia de hoje");
            relatorioCompras.AdicionarItem(compraHermenegildo);
            relatorioCompras.AdicionarItem(compraZoroastra);
            relatorioCompras.ImprimirRelatorio();
            
            Relatorio relatorioClientes = new Relatorio("Relatório de Clientes",
                "Este relatório apresenta uma lista de todos os clientes que compraram no mês de abril");
            relatorioClientes.AdicionarItem(hermenegildo);
            relatorioClientes.AdicionarItem(zoroastra);
            relatorioClientes.ImprimirRelatorio();
            
            Relatorio relatorioArtistico = new Relatorio("Relatorio Artístico",
                "Este relatório apresenta todos os softwares artisticos vendidos na loja.");
            relatorioArtistico.AdicionarItem(cottonshopi);
            relatorioArtistico.AdicionarItem(premillere);
            relatorioArtistico.ImprimirRelatorio();
            



        }
    }
}