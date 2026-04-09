using Figuras.Classes.Contratos;
using Figuras.Classes.Enumeracao;


namespace figuras.classe.Entidades
{
    abstract class Forma : IArea
    {
        /// <summary>
        ///
        /// Cores disponiveis vermelho, Azul, Amarelo e Rosa
        ///
        /// </summary>




        //campo

        private Cor cor;


        // construtor

        public Forma(Cor corDaForma)
        {
            CorDaForma = corDaForma;
        }

        // propriedades
        protected Cor CorDaForma
        {
            get { return cor; }
            set { cor = value; }
        }


        // Metodo
        abstract public double Area(); //classe generica é abstrata e nao pode ser instanciada depois
    }
}