namespace Heranca
{
    internal class PessoaFisica
    {
        //Campos
        private int numero;
        private string titular;
        private double saldo;

        //propriedades

        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }


        public string TitularConta
        {
            get { return titular; }
            set { titular = value; }
        }


        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }

        //construtor
        public PessoaFisica(string titularConta, int numeroConta, double saldoConta)
        {
            TitularConta = titularConta;
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
        }

        public PessoaFisica(string titularConta, int numeroConta) : this(titularConta, numeroConta, 0)
        {

            SaldoConta = 0;
        }
        //metodos
        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }
        public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }

        public override string ToString()
        {
            return $"Dados do cliente : " + $"\n\t Numero da conta : {NumeroConta}" + $"\n\t Titular da conta :{TitularConta}" + $"\n\t Saldo da conta : {SaldoConta:C}";
        }

    }
}
