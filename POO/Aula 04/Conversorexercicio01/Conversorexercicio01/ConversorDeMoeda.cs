namespace Conversorexercicio01
{
    internal static class ConversorDeMoeda
    {
        public static double Iof;
        public static double cotacao;
        public static double qtd;
    }
    public static ConversorDeMoeda (double cotacao, double qtd, double Iof)
        {
           return (cotacao * qtd * 0.06) + (cotacao * qtd);
        }
}
