namespace app3
{
    internal static class ConversorDeMoeda
    {
        public const double IOF = 6.00;
        public static double cotacao;
        public static double qtd;

        public static void Moeda(double cotacao, double qtd)
        {
            ConversorDeMoeda.cotacao = cotacao;
            ConversorDeMoeda.qtd = qtd;
        }
        public static double CalcularValor()
        {
            double Valor = cotacao * qtd;
            double ValorComIof = Valor + (Valor * IOF / 100);
            return ValorComIof;
        }
    }
}