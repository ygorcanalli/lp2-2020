using System.ComponentModel;

namespace ExemploEncapsulamento
{
    public class Circulo
    {
        private double _raio;

        public double Raio
        {
            get
            {
                return this._raio;
            }
            set
            {
                if (value <= 0)
                {
                    
                }
                else
                {
                    this._raio = value;
                }
                
            }
        }

        public Circulo(double raio)
        {
            this._raio = raio;
        }
    }
}