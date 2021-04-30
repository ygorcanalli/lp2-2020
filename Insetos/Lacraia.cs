namespace Insetos
{
    public class Lacraia : Inseto
    {
        protected int _paresDePatas;

        public int ParesDePatas
        {
            get
            {
                return this._paresDePatas;
            }
        }

        public Lacraia(string especie, double peso, string cor, int paresDePatas) : base(especie, peso, cor)
        {
            this._paresDePatas = paresDePatas;
        }
        
        
    }
}