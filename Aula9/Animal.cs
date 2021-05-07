using System;

namespace Aula9
{
public class Animal
{
    protected DateTime DataNascimento;
    protected Double Peso;
    
    public Animal(DateTime dataNascimento, double peso)
    {
        this.DataNascimento = dataNascimento;
        this.Peso = peso;
    }
}
}