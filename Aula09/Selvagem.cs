using System;

namespace Aula9
{
public class Selvagem : Animal
{
    public String CodigoRastreio;
    public Classificacao Especie;
    public Selvagem(String codigoRastreio, Classificacao especie, DateTime dataNascimento, double peso) 
        : base(dataNascimento, peso)
    {
        this.CodigoRastreio = codigoRastreio;
        this.Especie = especie;
    }

    public String Imprimir()
    {
        String s = String.Format("Rastreio:\t{0}\n", this.CodigoRastreio);
        s += String.Format("Espécie:\t{0}\n", this.Especie.ImprimirEspecie());
        s += String.Format("Nascimento:\t{0}\n", this.DataNascimento.ToShortDateString());
        s += String.Format("Peso:\t\t{0:0.0} Kg\n", this.Peso);
        return s;
    }
}
    
    
}