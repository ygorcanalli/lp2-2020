using System;

namespace Aula9
{
public class Animal
{
    public DateTime DataNascimento;
    public Double Peso;


    public Animal(DateTime dataNascimento, double peso)
    {
        this.DataNascimento = dataNascimento;
        this.Peso = peso;
    }
}
}