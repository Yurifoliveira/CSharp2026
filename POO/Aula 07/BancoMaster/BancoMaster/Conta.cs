namespace BancoMaster
{
    internal class Conta
    {
        private int numero;
        private string titular;
        private double saldo;

     

        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }
        

        public string TitularConta
        {
            get { return titular; }
            set { titular = value; }
        }


        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }
        //constr
        public Conta(string titularConta, int numeroConta, double saldoConta)
        {
            TitularConta = titularConta;
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
        }

        public Conta(string titularConta, int numeroConta) : this(titularConta, numeroConta,0)
        {

            SaldoConta = 0;
        }
        public virtual void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }
        public virtual void  Saque(double quantia)
        {
            SaldoConta -= quantia;
        }

        public override string ToString()
        {
            return $"Dados do cliente : " + $"\n\t Numero da conta : {NumeroConta}" + $"\n\t Titular da conta :{TitularConta}" + $"\n\t Saldo da conta : {SaldoConta:C}";
        }

        private double taxa_de_juros;


        public double TaxaDeJuros
        {
            get { return taxa_de_juros; }
            set { taxa_de_juros = value; }
        }
        public virtual void TaxaJuros(double quantia)
        {
            SaldoConta -= 5;
        }

    }
}
