using Aluguelcarros.Classes.Servicos;
using Aluguelcarros.Entidades;
namespace Aluguelcarros.Servicos
{
    public class ServAluguel
    {
        private double _PrecoPorDia;

        private double _PrecoPorHora;
        private TaxaServBrasil _taxaServBrasil;

        public ServAluguel(double precoPorDia, double precoPorHora)
        {
            _PrecoPorDia = precoPorDia;
            _PrecoPorHora = precoPorHora;
            _taxaServBrasil = new TaxaServBrasil();
        }
        public double PrecoDia => _PrecoPorDia;
        public double PrecoHora=> _PrecoPorHora;
       
        public void CalcularFatura(AluguelCarro aluguel)
        {
            TimeSpan duracao = aluguel.Fim - aluguel.Inicio;
            double totalHoras = duracao.TotalHours;
            double pagamentobasico;
            if (totalHoras <= 12.0)
                {
                pagamentobasico = Math.Ceiling(totalHoras) * _PrecoPorHora;
             
            }
            else
            {
                double totalDias = duracao.TotalHours / 24.0;
                pagamentobasico = Math.Ceiling(totalDias)*_PrecoPorDia;
            }
            double percentutalTaxa = _taxaServBrasil.Taxa(pagamentobasico);
            double valorTaxa = pagamentobasico * percentutalTaxa;
            aluguel.Fatura = new Fatura(pagamentobasico, valorTaxa);
        }
    }
}
