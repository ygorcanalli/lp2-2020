using System;
using System.Security.Claims;

namespace Insetos
{
    public class Inseto
    {
        protected string _especie;
        protected double _peso;
        protected string _cor;

        public string Especie
        {
            get
            {
                return this._especie;
            }
        }
        
        public double Peso
        {
            get
            {
                return this._peso;
            }
            set
            {
                this._peso = value;
            }
        }
        
        public string Cor
        {
            get
            {
                return this._cor;
            }
            set
            {
                this._cor = value;
            }
        }

        public Inseto(string especie, double peso, string cor)
        {
            this._especie = especie;
            this._peso = peso;
            this._cor = cor;
        }
        
    }
}