using figuras.classe.Entidades;
using Figuras.Classes.Enumeracao;

namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma
    {
		//campos
		private double largura;
		private double altura;


        //props
        protected double Largura
		{
			get { return largura; }
			set { largura = value; }
		}

		protected double Altura
		{
			get { return altura; }
			set { altura = value; }
		}
		//Construtor
        public Retangulo(Cor corDaForma , double largura , double altura) : base(corDaForma)
        {
			Largura = largura;
			Altura = altura;
        }
        /// <summary>
        /// Calcula a área da forma usando as dimensões atuais
        /// </summary>
        /// <returns>O valor da área calculada com base na largura e altura do retângulo</returns>
        public override double Area() => Largura * Altura; //Expressões lambda em C# são funções anônimas concisas que permitem criar métodos "na hora", sem precisar defini-los formalmente

    }
}
