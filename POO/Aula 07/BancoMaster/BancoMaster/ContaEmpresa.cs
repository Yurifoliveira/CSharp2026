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

        public void Limite(double quantia)
        {
            SaldoConta += quantia;
        }



    }
}
