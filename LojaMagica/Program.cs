using System;

namespace LojaMagica
{
    class Program
    {
        static void Main(string[] args)
        {
            Item espada = new Item("Espada Carmesim", "Espada de chamas de luz", 50);
            Item machado = new Item("Machado Boomerang", "Machado australiano que vai e volta", 65);
            Item escudo = new Item("Escudo de Madeira", "Tradicional Escudo de madeira", 40);

            espada.ImprimirItem();
            machado.ImprimirItem();
            escudo.ImprimirItem();

            Personagem hermenegildo = new Personagem("Hermenegildo Benevides");
            Personagem zoroastra = new Personagem("Zoroastra Anxarmandro");
            
            hermenegildo.ComprarItem(escudo);
            hermenegildo.ComprarItem(espada);
            
            zoroastra.ComprarItem(machado);
            zoroastra.ComprarItem(escudo);
            
            hermenegildo.ImprimirPersonagem();
            zoroastra.ImprimirPersonagem();
        }
    }
}