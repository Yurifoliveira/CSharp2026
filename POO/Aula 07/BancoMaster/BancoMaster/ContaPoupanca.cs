namespace BancoMaster
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca(string titularConta, int numeroConta) : base(titularConta, numeroConta)
        {
            
        }

        public ContaPoupanca(string titularConta, int numeroConta, double saldoConta) : base(titularConta, numeroConta, saldoConta)
        {
          
        }
        

    }
}
