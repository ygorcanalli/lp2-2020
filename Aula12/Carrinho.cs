using System;
using System.Collections.Generic;

namespace Aula12
{
public class Carrinho
{
    private Dictionary<Licensa, int> _itens;

    public Dictionary<Licensa, int> Itens
    {
        get { return this._itens; }
    }

    public double Total
    {
        get
        {
            double somatorio = 0;
            // somatorio de valor total de cada item multiplicado pela quantidade de itens no carrinho
            foreach (KeyValuePair<Licensa, int> parOrdenado in this._itens)
                somatorio += parOrdenado.Key.CalculaValorTotal() * parOrdenado.Value;

            return somatorio;
        }
    }

    public Carrinho()
    {
        this._itens = new Dictionary<Licensa, int>();
    }
    
    public void Adicionar(Licensa item, int quantidade)
    {
        if (this._itens.ContainsKey(item))
            this._itens[item] = this._itens[item] + quantidade;
        else
            this._itens[item] = quantidade;
    }

    public void Adicionar(Licensa item)
    {
        this.Adicionar(item, 1);
    }
    
    public void Adicionar(List<Licensa> itens)
    {
        foreach (var item in itens)
        {
            this.Adicionar(item);
        }
    }
    
    public void Adicionar(Dictionary<Licensa, int> itens)
    {
        foreach (KeyValuePair<Licensa, int> parOrdenado in itens)
        {
            this.Adicionar(parOrdenado.Key, parOrdenado.Value);
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("======== CARRINHO ========");
        foreach (KeyValuePair<Licensa, int> parOrdenado in this._itens)
        {
            Console.WriteLine("Software:\t{0}", parOrdenado.Key.Nome);
            Console.WriteLine("Valor:\t\tR$ {0:0.00}", parOrdenado.Key.CalculaValorTotal());
            Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
            Console.WriteLine("Subtotal:\tR$ {0:0.00}", parOrdenado.Value * parOrdenado.Key.CalculaValorTotal());
            Console.WriteLine("==========================");
        }
        Console.WriteLine("Total do carrinho:\tR$ {0:0.00}", this.Total);
        Console.WriteLine("==========================");
    }
}
}