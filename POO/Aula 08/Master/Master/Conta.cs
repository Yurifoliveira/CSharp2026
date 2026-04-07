namespace Master
{
    internal class Conta : IOperacao
    {

        //campos

        private Pessoa cliente;
        private int numero;
        private double saldo;


        //propriedades
        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }

        }
        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }

        }
        public Pessoa DadosCliente
        {
            get {  return cliente; }
            set { cliente = value; }

        }

        //construtores

        public Conta(int numeroConta, double saldoConta, Pessoa dadosCliente)
        {
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
            DadosCliente = dadosCliente;
        }
        //metodos
        public void Deposito(double qtd)
        {
            SaldoConta += qtd;
        }

        public void Saque(double qtd)
        {
            SaldoConta -= qtd;
        }
        public override string ToString()
        {
            return $"dados da conta - {Tipo.ContaNormal}: " +  $"Dados da conta : " + $"\n\tNome do titular :{cliente.nome}" + $"\n\tCPF do titular : {cliente.cpf}" + $"\n\tNumero da conta : {numero}" + $"\n\tSaldo da conta : {saldo:C}";
        }
    }
}
