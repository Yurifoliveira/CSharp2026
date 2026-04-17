namespace Aluguelcarros.Entidades
{
    public class AluguelCarro
    {
        private DateTime _Inicio;
        private DateTime _Fim;
        private Veiculo _veiculo;

        public AluguelCarro(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            _Inicio = inicio;
            _Fim = fim;
            _veiculo = veiculo;
        }
     public DateTime Inicio => _Inicio;
        public DateTime Fim => _Fim;
        public  Veiculo Veiculo => _veiculo;
        public Fatura? Fatura {  get; set; }
    }
}
