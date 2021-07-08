namespace GabaritoTarefa5
{
    public class Figura
    {
        protected double _area; // atributo
        protected double _perimetro; // atributo

        public double Area // propriedade
        {
            // leitura do atributo correspondente
            get { return this._area; }
        }

        public double Perimetro // propriedade
        {
            // leitura do atributo correspondente
            get { return this._perimetro; }
        }
    }
}