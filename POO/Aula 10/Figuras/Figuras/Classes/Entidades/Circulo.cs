using figuras.classe.Entidades;
using Figuras.Classes.Enumeracao;

namespace Figuras.Classes.Entidades
{
    internal class Circulo : Forma
    {
        //campo
		private double raio;

        //propriedade

        public double Raio 
		{
			get { return raio; }
			set { raio = value; }
		}
        public Circulo(Cor corDaForma , double raio) : base(corDaForma)
        {
            Raio = raio;
        }
        //metodo
        public override double Area()
        {
            return Raio * Raio * 3.14;
        }

	}
}
