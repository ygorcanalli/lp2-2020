using System;

public class Professor : Pessoa
{
  private string _email;
  
  public string Email
  {
    get { return _email; }
  }
  
  public Professor(string nome, string email) : base(nome)
  {
    this._email = email;
  }

  public override void Imprimir()
  {
    base.Imprimir();
    Console.WriteLine("Email: {0}", _email);
  }
}