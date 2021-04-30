namespace Insetos
{
    public class LacraiaDoInferno : Lacraia
    {
        private bool _asas;

        public bool Asas
        {
            get
            {
                return this._asas;
            }
        }

        public LacraiaDoInferno(string especie, double peso, string cor, int paresDePatas) : base(especie, peso, cor, paresDePatas)
        {
            this._asas = false;
        }

        public void SairDoRio()
        {
            this._asas = true;
        }
    }
}