using System.Diagnostics.Tracing;

namespace GabaritoAula6
{
    public abstract class Produto : IImprimivel
    {
        
        protected string _nome;
        protected double _preco;
        protected Fornecedor _fornecedor;
        
        public double Preco
        {
            get { return this._preco;}
        }
        
        public string Nome
        {
            get { return this._nome; }
        }
        
        public Fornecedor Fornecedor
        {
            get { return this._fornecedor; }
        }

        public Produto(string nome, double preco, Fornecedor fornecedor)
        {
            this._nome = nome;
            this._preco = preco;
            this._fornecedor = fornecedor;
        }
        
        public abstract double CalculaValorTotal();
        public abstract void Imprimir();
        
    }
}