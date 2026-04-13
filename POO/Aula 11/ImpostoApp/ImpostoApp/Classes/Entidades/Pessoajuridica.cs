namespace ImpostoApp.Models
{
    /// <summary>
    /// Representa um contribuinte Pessoa Jurídica.
    /// Herda de Contribuinte e implementa as regras específicas de imposto PJ.
    /// </summary>
    public class PessoaJuridica : Contribuinte
    {
        private const decimal AliquotaPadrao = 0.16m;  // até 10 funcionários
        private const decimal AliquotaReduzida = 0.14m;  // mais de 10 funcionários
        private const int LimiteFuncionarios = 10;

        private int _numeroFuncionarios;

        public PessoaJuridica(string nome, decimal rendaAnual, int numeroFuncionarios)
            : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public int NumeroFuncionarios
        {
            get => _numeroFuncionarios;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("O número de funcionários não pode ser negativo.");
                _numeroFuncionarios = value;
            }
        }

        /// <summary>
        /// Regras PJ:
        ///   funcionários &lt;= 10 → alíquota 16%
        ///   funcionários  > 10 → alíquota 14%
        /// </summary>
        public override decimal CalcularImposto()
        {
            decimal aliquota = NumeroFuncionarios > LimiteFuncionarios
                ? AliquotaReduzida
                : AliquotaPadrao;

            return RendaAnual * aliquota;
        }
    }
}