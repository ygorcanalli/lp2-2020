using System;

namespace Aula9
{
public class Domestico : Animal
{
    public String Nome;
    public Classificacao Especie;
    public Humano Dono;
    
    public Domestico(String nome, Classificacao especie, DateTime dataNascimento, double peso) 
        : base(dataNascimento, peso)
    {
        this.Nome = nome;
        this.Especie = especie;
    }
    
    public String Imprimir()
    {
        String s = String.Format("Nome:\t\t{0}\n", this.Nome);
        s += String.Format("Espécie:\t{0}\n", this.Especie.ImprimirEspecie());
        s += String.Format("Nascimento:\t{0}\n", this.DataNascimento.ToShortDateString());
        s += String.Format("Peso:\t\t{0:0.0} Kg\n", this.Peso);
        if (this.Dono != null)
            s += String.Format("Dono:\t\t{0}\n", this.Dono.Nome);
        
        return s;
    }
    
}
}