using System;

namespace Aula9
{
public class Classificacao
{
    public String Familia;
    public String Genero;
    public String Especie;

    public Classificacao(String familia, String genero, String especie)
    {
        this.Familia = familia;
        this.Genero = genero;
        this.Especie = especie;
    }

    public String ImprimirEspecie()
    {
        return String.Format("{0} {1} (família {2})", this.Genero, this.Especie, this.Familia);
    }
}
}