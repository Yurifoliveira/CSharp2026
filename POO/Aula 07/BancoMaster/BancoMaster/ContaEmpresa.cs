using System.ComponentModel;

namespace BancoMaster
{
    internal class ContaEmpresa : Conta
    {
        private double limite;
        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }
        public ContaEmpresa(string titularConta, int numeroConta, double limiteConta) : base(titularConta, numeroConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public ContaEmpresa(string titularConta, int numeroConta, double saldoConta, double limiteConta) : base(titularConta, numeroConta, saldoConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public void Emprestimo(double quantia)
        {
            this.limite -= quantia;
            if (quantia > 0 && quantia <= LimiteEmprestimo)
            {
                SaldoConta += quantia; 
            }
            else
            {
                Console.WriteLine("Valor inválido ou limite insuficiente!");
            }
        }
        public override void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }
        public override void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }
      

    }
}
