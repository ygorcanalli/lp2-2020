using System;

namespace Aula9
{
public class Animal
{
    public DateTime DataNascimento;
    public Double Peso;

    public Animal(DateTime dataNascimento, Double peso)
    {
        this.DataNascimento = dataNascimento;
        this.Peso = peso;
    }
}
}