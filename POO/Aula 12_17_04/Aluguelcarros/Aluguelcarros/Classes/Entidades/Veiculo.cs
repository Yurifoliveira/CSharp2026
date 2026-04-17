namespace Aluguelcarros.Entidades
{
    public class Veiculo
    {
        private String _modelo;

        public Veiculo(string modelo)
        {
            _modelo = modelo;
        }
        public string Modelo => _modelo;
    }
}
