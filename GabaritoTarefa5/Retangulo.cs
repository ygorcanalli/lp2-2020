using System;

namespace GabaritoTarefa5
{
    public class Retangulo : Figura 
    {
        private double _largura; // atributo
        private double _altura; // atributo
        
        public double Largura // propriedade
        {
            // leitura do atributo correspondente
            get
            {
                return this._largura;
            }
        
            // escrita do atributo correspondente
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Base inválida");
                }
                else
                {
                    this._largura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        
        public double Altura // propriedade
        {
            // leitura do atributo correspondente
            get
            {
                return this._altura;
            }
        
            // escrita do atributo correspondente
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Altura inválida");
                }
                else
                {
                    this._altura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Retangulo(double largura, double altura)
        {
            // escrita utilizando método set da propriedade
            this.Largura = largura;
            this.Altura = altura;
        }
        private void AtualizarArea()
        {
            this._area = this._altura * this._largura;
        }
        private void AtualizarPerimetro()
        {
            this._perimetro = 2 * (this._altura + this._altura);
        }
    }
}