namespace Aluguelcarros.Entidades
{
    public class Fatura
    {
        private double _pagamentoBasico;
        private double _taxa;
        private double _totalPagamento;

        public double PagamentoBasico => _pagamentoBasico;
        public double Taxa => _taxa;
        public double TotalPagamento => _totalPagamento;
        public override string ToString()
        {
            return $"PagamentoBasico : {_pagamentoBasico:F2}\n"
                + $"Taxa : {_taxa:F2}\n"
                + $"Pagamento total : {_totalPagamento:F2}";
        }
        public Fatura(double pagementoBasico, double taxa)
        {
            _pagamentoBasico = pagementoBasico;
            _taxa = taxa;
            _totalPagamento = pagementoBasico + taxa;
        }
    }
}
