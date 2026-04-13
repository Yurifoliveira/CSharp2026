using ImpostoApp.Interfaces;

namespace ImpostoApp.Models
{
    /// <summary>
    /// Classe base abstrata que representa qualquer contribuinte.
    /// Aplica Abstração, Encapsulamento e Herança.
    /// </summary>
    public abstract class Contribuinte : ITributavel
    {
        // Encapsulamento: campos privados com propriedades públicas
        private string _nome;
        private decimal _rendaAnual;

        // Construtor protegido — somente subclasses podem instanciar
        protected Contribuinte(string nome, decimal rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public string Nome
        {
            get => _nome;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome não pode ser vazio.");
                _nome = value;
            }
        }

        public decimal RendaAnual
        {
            get => _rendaAnual;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("A renda anual não pode ser negativa.");
                _rendaAnual = value;
            }
        }

        // Método abstrato: obriga cada subclasse a implementar sua própria regra
        public abstract decimal CalcularImposto();

        // Polimorfismo: representação textual personalizada por tipo
        public override string ToString()
        {
            return $"{GetType().Name.Replace("Pessoa", "Pessoa ")} | Nome: {Nome} | " +
                   $"Renda: {RendaAnual:C2} | Imposto: {CalcularImposto():C2}";
        }
    }
}