namespace DepartamentoPessoal.Classes.Entidades
{
    internal class Terceiro : Funcionario
    {
        //campo
        private double despesa;

        //props
        protected double DespesaAdicional
        {
			get { return despesa; }
			set { despesa = value; }
		}
        //constru
        public Terceiro(string nomeColaborador, int jornadaTrabalho, double valorHora ,double despesa) : base(nomeColaborador, jornadaTrabalho, valorHora)
        {
            DespesaAdicional = despesa;
        }
        //metodo
        public override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdicional * 0.2);
        }
	}
}
