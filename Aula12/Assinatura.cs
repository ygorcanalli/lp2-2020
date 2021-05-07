using System.Diagnostics.Tracing;

namespace Aula12
{
public class Assinatura : Licensa
{
    private int _duracao;

    public double Duracao
    {
        get { return this._duracao; }
    }

    public Assinatura(string nome, double mensalidade, int duracao, string chaveAtivacao) : base(nome, mensalidade, chaveAtivacao)
    {
        this._duracao = duracao;
    }

    public override double CalculaValorTotal()
    {
        return this._preco * this._duracao;
    }
}
}