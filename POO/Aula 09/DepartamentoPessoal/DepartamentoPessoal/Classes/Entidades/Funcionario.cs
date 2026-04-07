namespace DepartamentoPessoal.Classes.Entidades
{
    internal class Funcionario
    {
		//campos

		private string nome;
		private int jornada;
		private double valor;


        //props

        protected string NomeColaborador //protected é somente para super classe e subs
		{
			get { return nome; }
			set { nome = value; }
		}
        protected int JornadaTrabalho
		{
			get { return jornada; }
			set { jornada = value; }
		}
        protected double ValorHora
		{
			get { return valor; }
			set { valor = value; }
		}
		//constru
        public Funcionario(string nomeColaborador, int jornadaTrabalho, double valorHora)
        {
            NomeColaborador = nomeColaborador;
            JornadaTrabalho = jornadaTrabalho;
            ValorHora = valorHora;
        }
		//metodos
		public virtual double Pagamento()
		{
			return ValorHora * JornadaTrabalho;
		}
        public override string ToString()
        {
			return $"{NomeColaborador}- {Pagamento():C}";
        }
	}
}
