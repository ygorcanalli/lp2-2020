using System;
using System.Collections.Generic;

namespace Aula9
{
public class Humano : Animal
{
    public String Nome;
    public String Cpf;
    public List<Domestico> Pets;

    public Humano(String nome, String cpf, DateTime dataNascimento, double peso) 
        : base(dataNascimento, peso)
    {
        this.Nome = nome;
        this.Cpf = cpf;
        this.Pets = new List<Domestico>();
    }

    public void Adotar(Domestico pet)
    {
        this.Pets.Add(pet);
        pet.Dono = this;
    }
    public String Imprimir()
    {
        String s = String.Format("Nome:\t\t{0}\n", this.Nome);
        s += String.Format("CPF:\t\t{0}\n", this.Cpf);
        s += String.Format("Nascimento:\t{0}\n", this.DataNascimento.ToShortDateString());
        s += String.Format("Peso:\t\t{0:0.0} Kg\n", this.Peso);
        s += String.Format("Pets:\t\t[ ");
        foreach (Domestico pet in Pets)
            s += String.Format("{0} ",pet.Nome);
        
        s += "]\n";
        return s;
    }
}
    
    
}