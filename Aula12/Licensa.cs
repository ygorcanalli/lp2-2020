namespace Aula12
{
public class Licensa
{
    protected string _nome;
    protected double _preco;
    protected string _chaveAtivacao;

    public string Nome
    {
        get { return this._nome; }
    }

    public string ChaveAtivacao
    {
        get { return this._chaveAtivacao; }
    }

    public double Preco
    {
        get { return this._preco;}
    }

    public Licensa(string nome, double preco, string chaveAtivacao)
    {
        this._nome = nome;
        this._preco = preco;
        this._chaveAtivacao = chaveAtivacao;
    }

    public virtual double CalculaValorTotal()
    {
        return this._preco;
    }
}
}