using System;

namespace GabaritoAula6
{
    public class Compra : IImprimivel
    {
        private Cliente Cliente;
        private DateTime DataHora;
        private Carrinho Carrinho;
        private bool Situacao;

        public Compra(Cliente cliente, DateTime dataHora, Carrinho carrinho, Estoque estoque)
        {
            this.Cliente = cliente;
            this.DataHora = dataHora;
            this.Carrinho = carrinho;
            this.Situacao = estoque.RemoverItens(carrinho.Itens);
        }
        public void Imprimir()
        {
            Console.WriteLine("Cliente:\t{0}", this.Cliente.Nome); 
            Console.WriteLine("Data e Hora:\tR$ {0}", this.DataHora);
            if (this.Situacao)
                Console.WriteLine("Total:\t\tR$ {0:0.00}", this.Carrinho.Total);
            else
                Console.WriteLine("Compra cancelada por falta de estoque");
        }
    }
}