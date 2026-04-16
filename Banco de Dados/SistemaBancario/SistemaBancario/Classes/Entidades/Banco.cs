namespace SistemaBancario.Classes.Entidades
{ ///<summary>
  /// classe que representa uma conta bancaria com operações basicas
  /// implementa as regras do negocio
  ///</summary>
    internal class Banco
    {
        //campo
        ///<summary>
        ///taxa fixa cobrada em cada operação de saque
        ///</summary>
        private const decimal taxaSaque = 5.00m;


        //proprieadades
        ///<summary>
        ///Identficador unico da conta bancaria no banco de dados
        ///gerado automaticamente
        ///</summary>
        public int Id { get; set; }
        ///<summary>
        ///numero da conta
        ///'init' garante que o valor só pod ser atribuido na (criação imutavel após construção)
        ///</summary>
        public int NumeroConta { get; init; }
        ///<summary>
        ///Nome do titular da conta
        ///</summary>
        public string Titular { get; init; }
        ///<summary>
        /// saldo atual da conta
        ///private set impede alteração direta 
        ///so pode mudar atrvés de depósito ou saque
        /// </summary>
        public decimal Saldo { get; private set; }

        //Construtores
        /// <summary>
        /// construtor privado sem parametro
        /// necessario para p entity framework instanciar a classe ao buscar no banco de dados
        /// nao deveser utilizado diretamente no codigo
        /// </summary>
        private Banco()
        {
        }
        /// <summary>
        /// Construtor principal para criar uma nova conta bancaria
        /// </summary>
        /// <param name="numeroConta">Número único da conta (não pode ser alterado depois)</param>
        /// <param name="titular">Nome do titular da conta</param>
        /// <param name="saldo">Valor do deposito inicial(opcional, padrão = 0 )</param>
        public Banco(int numeroConta, string titular, decimal saldo = 0)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }
        //metodos
        ///<summary>
        ///realiza um deposito na conta, aumentando o saldo da conta
        /// </summary>
        /// <param name="valor">Valor a ser depositado deve ser positivo
        /// </param>
        public void Deposito(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de deposito deveser positivo");
            }
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com êxito!");
        }
        ///<summary>
        ///realiza um saque na conta diminuindo o saldo 
        ///cobra automaticamente  uma taxa de R$ 5.00 por saque
        ///importante permite saldo negativo se nao houver fundos
        ///</summary>
        /// <param name="valor">Valor a ser sacado (deves ser positivo , nao inclui a taxa)</param>
        public void Saque(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque deve ser positivo");
                return;
            }
            Saldo -= (valor + taxaSaque);
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso !Taxa de {taxaSaque:C} cobrada");
        }
        ///<summary>
        ///exibe os dados da conta no console
        ///mostrat numero da conta , titular e saldo atual
        /// </summary>
        public void ExibirDados()
        {
            Console.WriteLine("\n--Dados da conta--");
            Console.WriteLine($"Conta : {NumeroConta}");
            Console.WriteLine($"Titular :{Titular}");
            Console.WriteLine($"Saldo : {Saldo:C}");
            Console.WriteLine("----------------------------\n");
        }
    }
}
