using System;
using System.Collections.Generic;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            
Dictionary<string, string> dicionarioCriaturas = new Dictionary<string, string>();
dicionarioCriaturas.Add("Humano", "Altos, razoavelmente educados e fortes, vida curta");
dicionarioCriaturas.Add("Elfo", "Esbeltos, extremamente cultos e com vida muito longa");
dicionarioCriaturas["Orc"] = "Fortes, repulsivos, numerosos e pouco inteligentes, vida muito curta";
dicionarioCriaturas["Anão"] = "Baixos, muito fortes, rabugentos e habilidosos, vida longa";

Console.WriteLine(dicionarioCriaturas["Elfo"]);

foreach (KeyValuePair<string, string> parOrdenado in dicionarioCriaturas)
{
    Console.WriteLine("{0} => {1}", parOrdenado.Key, parOrdenado.Value);
}
            


            
            
        }
    }
}