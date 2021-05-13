using System;
using System.Collections.Generic;

namespace Aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            Licensa rwindols = new Licensa("Michaelsóft Rwildols", 699.90, "SUAA-HE52-W6WG-B8Y9");
            Assinatura alface123 = new Assinatura("Michaelsóft Alface", 39.90, 12, "5GNX-VM6Y-L6W8-SCPC");
            Assinatura cottonshopi =
                new Assinatura("Aldobo Cottonshopi", mensalidade: 89.90, 12, "H84A-8QDF-4XPT-A2WZ");
            Assinatura premillere =
                new Assinatura("Aldobo Premillere", mensalidade: 89.90, 12, "RLBD-YTRZ-UPH7-VQGM");
            Licensa corehul = new Licensa("Corehul Dreus", 2999.90, "XZLT-CXL9-SLHV-99UM");

            ProdutoFisico mausi = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99);
            ProdutoFisico lepetope = new ProdutoFisico("Lepetope Dehul", 3499.90, 123.45);

            Carrinho carrinho = new Carrinho();
        
            // adicionando uma unidade do item
            carrinho.Adicionar(rwindols);
        
            // adicionando três unidades do item
            carrinho.Adicionar(alface123, 3);
            
            // adicionando uma lista de itens no carrinho
            carrinho.Adicionar(new List<Produto>{cottonshopi, premillere});

            carrinho.Adicionar(corehul);
            
            // adicionando produtos ao carrinho
            carrinho.Adicionar(mausi, 3);
            carrinho.Adicionar(lepetope);
            
            carrinho.Imprimir();
        
        }
    }
}