namespace exemplo1
{
    internal class Produto
    {
        //campos da classe
        public string nome;
        public double preco;
        public int quantidade;

        //construtor
        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
        //--------------//-------------------------//-----------------------------//
        //exemplo de sobre carga de metodo

       /* public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            quantidade = 0;
        }

        */
        
        //-----------------//-----------------------//----------------------------//

        //Métodos da classe
        public double Valor_Total_Em_Estoque()
        {
            return preco * quantidade;
        }
        public void Adicionar_Produtos(int qtd)
        {
            quantidade += qtd;
        }
        public void Remover_Produtos (int qtd)
        {
            quantidade -= qtd;
        }
        public string Dados_do_Produto()
        {
            return $"nome : {nome} , Preço : {preco} ,  Quantidade : {quantidade}" + $" Total : {Valor_Total_Em_Estoque()} " ;
        }
    }
}
