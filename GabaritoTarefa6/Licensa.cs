using System;

namespace GabaritoAula6
{
public class Licensa : Produto
{
    
    protected string _chaveAtivacao;

    public string ChaveAtivacao
    {
        get { return this._chaveAtivacao; }
    }

    public Licensa(string nome, double preco, string chaveAtivacao, Fornecedor fornecedor) : base(nome, preco, fornecedor)
    {
        this._chaveAtivacao = chaveAtivacao;
    }

    public override double CalculaValorTotal()
    {
        return this._preco;
    }

    public override void Imprimir()
    {
        Console.WriteLine("Software:\t{0}", this.Nome);
        Console.WriteLine("Fornecedor:\t{0}", this.Fornecedor.Nome);
        Console.WriteLine("Valor:\t\tR$ {0:0.00}", this.CalculaValorTotal());
    }
}
}