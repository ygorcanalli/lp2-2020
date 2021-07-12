using System;

public abstract class Pessoa : IImprimivel
{
  private string _nome;

  public string Nome
  {
    get { return _nome; }
  }

  public Pessoa(string nome)
  {
    this._nome = nome;
  }

  public virtual void Imprimir()
  {
    Console.WriteLine("Nome: {0}", _nome);
  }
}