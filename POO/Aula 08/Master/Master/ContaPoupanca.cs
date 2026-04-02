namespace Master
{
    internal class ContaPoupanca : Conta
    {
		//campo
		private double rendimento;


        //propriedade
        public double RendimentoConta
		{
			get { return rendimento; }
			set { rendimento = value; }
		}
        //construtor
        public ContaPoupanca(int numeroConta, double saldoConta, Pessoa dadosCliente) : base(numeroConta, saldoConta, dadosCliente)
        {
            RendimentoConta = rendimento;
        }
        //metodos
        public void Consulta()
        {
            Console.WriteLine( $"Dados do Cliente : \n" + $"\tNome : {DadosCliente}\n"+$"\tNumero : {NumeroConta}\n"+$"\tSaldo : {SaldoConta}");
        }
	}
}
