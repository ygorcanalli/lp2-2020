using System;

public class Aluno : Pessoa
{
  private string _matricula;

  public string Matricula
  {
    get { return _matricula; }
  }

  public Aluno(string nome, string matricula) : base(nome)
  {
    this._matricula = matricula;
  }

  public override void Imprimir()
  {
    base.Imprimir();
    Console.WriteLine("Matricula: {0}", _matricula);
  }
}