using System;
using System.Collections.Generic;

namespace LojaMagica
{
    public class Personagem
    {
        public string Nome;
        public int Moedas;
        public List<Item> Inventario;

        public Personagem(string nome)
        {
            this.Nome = nome;
            this.Moedas = 100;
            this.Inventario = new List<Item>();
        }
        
        public void ImprimirPersonagem()
        {
            Console.WriteLine("Nome:\t\t{0}", this.Nome);
            Console.WriteLine("Moedas:\t\t{0}", this.Moedas);
            Console.Write("Inventário:\t[ ");
            foreach (var item in Inventario)
            {
                Console.Write("{0}\t", item.Nome);
            }
            Console.WriteLine("]");
            Console.WriteLine("-----------------------");
        }

        public void PegarItem(Item item)
        {
            this.Inventario.Add(item);
        }

        public void ComprarItem(Item item)
        {
            if (this.Moedas > item.Moedas)
            {
                this.Moedas = this.Moedas - item.Moedas;
                this.PegarItem(item);
            }
            else
            {
                Console.WriteLine("Estou falido!!");
            }
        }
    }
}