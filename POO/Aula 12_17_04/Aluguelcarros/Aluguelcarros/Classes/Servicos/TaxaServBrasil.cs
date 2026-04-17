namespace Aluguelcarros.Classes.Servicos
{
    public class TaxaServBrasil
    {
      public double Taxa (double pagamentoBasico)
        {
            if (pagamentoBasico <= 100.0)
                return 0.20;
            else
                return 0.15;
        }
    }
}
