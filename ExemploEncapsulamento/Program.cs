using System;

namespace ExemploEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Circulo bolotinha = new Circulo(10.0);

            Console.WriteLine("Raio:{0}", bolotinha.Raio);

            bolotinha.Raio = 15.6;
            
            Console.WriteLine("Raio:{0}", bolotinha.Raio);

        }
    }
}