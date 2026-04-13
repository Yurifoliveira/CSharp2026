namespace ImpostoApp.Interfaces
{
    /// <summary>
    /// Interface que define o contrato de tributação.
    /// Qualquer contribuinte deve implementar o cálculo de imposto.
    /// </summary>
    public interface ITributavel
    {
        decimal CalcularImposto();
    }
}