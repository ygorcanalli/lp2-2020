using System;

namespace LojaMagica
{
    public class Item
    {
        public string Nome;
        public string Descricao;
        public int Moedas;

        public Item(string nome, string descricao, int moedas)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Moedas = moedas;
        }

        public void ImprimirItem()
        {
            Console.WriteLine("Nome:\t\t{0}", this.Nome);
            Console.WriteLine("Descrição:\t{0}", this.Descricao);
            Console.WriteLine("Moedas:\t\t{0}", this.Moedas);
            Console.WriteLine("-----------------------");
        }
    }
}