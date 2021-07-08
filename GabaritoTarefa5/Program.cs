using System;
using System.Collections.Generic;
namespace GabaritoTarefa5
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circ1 = new Circulo(2.0);
            Circulo circ2 = new Circulo(3.0);
            Circulo circ3 = new Circulo(4.5);
            Retangulo ret1 = new Retangulo(3.5, 4.2);
            Retangulo ret2 = new Retangulo(2.5, 1.5);
            Retangulo ret3 = new Retangulo(3.3, 2.1);

            List<Figura> figuras = new List<Figura>();
            figuras.Add(circ1);
            figuras.Add(circ2);
            figuras.Add(circ3);
            figuras.Add(ret1);
            figuras.Add(ret2);
            figuras.Add(ret3);

            foreach (var figura in figuras)
            {
                Console.WriteLine("Área:\t\t{0:0.0}", figura.Area);
                Console.WriteLine("Perímetro\t{0:0.0}", figura.Perimetro);
                Console.WriteLine("---------------------------------");
            }
        }
    }
}