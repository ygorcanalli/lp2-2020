using System;
using System.Collections.Generic;

namespace Aula12
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

        Carrinho carrinho = new Carrinho();
        
        // adicionando uma unidade do item
        carrinho.Adicionar(rwindols);
        
        // adicionando três unidades do item
        carrinho.Adicionar(alface123, 3);

        List<Licensa> colecao_adolbo = new List<Licensa>();
        colecao_adolbo.Add(cottonshopi);
        colecao_adolbo.Add(premillere);
        
        // adicionando uma lista de itens no carrinho
        carrinho.Adicionar(colecao_adolbo);
        
        carrinho.Imprimir();

        Carrinho outroCarrinho = new Carrinho();
        outroCarrinho.Adicionar(corehul);
        
        // Adicionando todos os itens de um carrinho no outro
        outroCarrinho.Adicionar(carrinho.Itens);
        
        outroCarrinho.Imprimir();
      
    }
}
}