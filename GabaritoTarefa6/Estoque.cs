using System;
using System.Collections.Generic;

namespace GabaritoAula6
{
    public class Estoque
    {
        private Dictionary<Produto, int> _itens;
    
        public Dictionary<Produto, int> Itens
        {
            get { return this._itens; }
        }
        
        public Estoque()
        {
            this._itens = new Dictionary<Produto, int>();
        }
        
        public void Adicionar(Produto item, int quantidade)
        {
            if (this._itens.ContainsKey(item))
                this._itens[item] = this._itens[item] + quantidade;
            else
                this._itens[item] = quantidade;
        }
    
        public void Adicionar(Produto item)
        {
            this.Adicionar(item, 1);
        }
        
        public void Adicionar(List<Produto> itens)
        {
            foreach (var item in itens)
            {
                this.Adicionar(item);
            }
        }
        
        public void Adicionar(Dictionary<Produto, int> itens)
        {
            foreach (KeyValuePair<Produto, int> parOrdenado in itens)
            {
                this.Adicionar(parOrdenado.Key, parOrdenado.Value);
            }
        }
    
        private bool ConsultarDisponibilidade(Dictionary<Produto, int> carrinho)
        {
            foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
            {
                if (carrinho.ContainsKey(parOrdenado.Key))
                {
                    if (this._itens[parOrdenado.Key] < parOrdenado.Value)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
        
        public bool RemoverItens(Dictionary<Produto, int> carrinho)
        {
            bool disponibilidade = this.ConsultarDisponibilidade(carrinho);

            if (disponibilidade)
            {
                foreach (var item in carrinho)
                {
                    this._itens[item.Key] = this._itens[item.Key] - item.Value;
                }
            }

            return disponibilidade;
        }
    }
}