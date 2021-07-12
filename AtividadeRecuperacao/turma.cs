using System;
using System.Collections.Generic;

public class Turma : IImprimivel
{
  private Professor _professor1;
  private Professor _professor2;
  private List<Aluno> _alunos;
  private string _serie;
  private string _nome;

  public Turma(string nome, string serie, Professor professor1, Professor professor2)
  {
    this._nome = nome;
    this._serie = serie;
    this._professor1 = professor1;
    this._professor2 = professor2;
    this._alunos = new List<Aluno>();
  }

  public void AdicionarAluno(Aluno aluno)
  {
    this._alunos.Add(aluno);
  }

  public void Imprimir()
  {
    Console.WriteLine("Turma: {0}", this._nome);
    Console.WriteLine("Serie: {0}", this._serie);
    Console.WriteLine("Professores {0} e {1}", this._professor1.Nome, this._professor2.Nome);
    Console.Write("Alunos:");
    foreach (var aluno in _alunos)
    {
      Console.Write(" {0}", aluno.Nome);
    }
    Console.WriteLine("");
  }
}