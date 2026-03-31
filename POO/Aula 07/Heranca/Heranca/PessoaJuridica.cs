namespace Heranca
{
    internal class PessoaJuridica : PessoaFisica
    {
      //campos
        private double limite;

        //propriedades
        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }


        public PessoaJuridica(string titularConta, int numeroConta , double limiteConta) : base(titularConta, numeroConta) //comando base é para realizar a chamada do construtor da superclasse
        {
            LimiteEmprestimo = limiteConta;

        }
        public PessoaJuridica(double saldoConta, string titularConta, int numeroConta , double limiteConta) : base( titularConta, numeroConta , saldoConta)
        {
            LimiteEmprestimo = limiteConta;
        }
        //metodos
        public void Limite (double quantia)
        {
            SaldoConta += quantia;
        }
    }
}
