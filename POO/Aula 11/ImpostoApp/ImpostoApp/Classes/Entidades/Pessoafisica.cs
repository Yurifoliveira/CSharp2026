namespace ImpostoApp.Models
{
    /// <summary>
    /// Representa um contribuinte Pessoa Física.
    /// Herda de Contribuinte e implementa as regras específicas de imposto PF.
    /// </summary>
    public class PessoaFisica : Contribuinte
    {
        private const decimal AliquotaBaixa = 0.15m;  // renda < 20.000
        private const decimal AliquotaAlta = 0.25m;  // renda >= 20.000
        private const decimal LimiteRenda = 20_000m;
        private const decimal AbatimentoSaude = 0.50m;

        private decimal _gastosComSaude;

        public PessoaFisica(string nome, decimal rendaAnual, decimal gastosComSaude)
            : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public decimal GastosComSaude
        {
            get => _gastosComSaude;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Os gastos com saúde não podem ser negativos.");
                _gastosComSaude = value;
            }
        }

        /// <summary>
        /// Regras PF:
        ///   renda &lt; 20.000  → alíquota 15%
        ///   renda >= 20.000 → alíquota 25%
        ///   abate 50% dos gastos com saúde do imposto calculado
        /// </summary>
        public override decimal CalcularImposto()
        {
            decimal aliquota = RendaAnual < LimiteRenda ? AliquotaBaixa : AliquotaAlta;
            decimal imposto = RendaAnual * aliquota;
            decimal abatimento = GastosComSaude * AbatimentoSaude;

            // O imposto não pode ser negativo
            return Math.Max(0m, imposto - abatimento);
        }
    }
}