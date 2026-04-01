namespace BancoMaster
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca(string titularConta, int numeroConta) : base(titularConta, numeroConta)
        {
            SaldoConta = 0;
        }

        public ContaPoupanca(string titularConta, int numeroConta, double saldoConta) : base(titularConta, numeroConta, saldoConta)
        {
          
        }

        public double TaxadeJuros
        {
            get { return TaxadeJuros; }
            set { TaxadeJuros = value; }
        }

        public override void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }
        public void AtualizacaodeSaldo()
        {
            SaldoConta = SaldoConta + (SaldoConta * TaxadeJuros);
        }
        
        public override void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }
    }
}
