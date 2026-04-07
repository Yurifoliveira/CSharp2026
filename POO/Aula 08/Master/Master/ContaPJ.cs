namespace Master
{
    internal class ContaPJ : Conta
    {
        private double limite;

        public double LimiteConta
        {
            get { return limite; }
            set { limite = value; }
        }
        public ContaPJ(int numeroConta, double saldoConta, Pessoa dadosCliente, double limite ) : base(numeroConta, saldoConta, dadosCliente)
        {
            LimiteConta = limite;
        }

        public void Emprestimo(double qtd)
        {
            LimiteConta -= qtd;
            SaldoConta += qtd;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\tLimite conta : {limite:C}"; //sobrescrita com reaproveitamento de codigo
        }
    }
}