namespace Master
{
    internal struct Pessoa //struct nao existe herança e nem vice-versa / pois pode ocorrer ambiguidade /utiliza-se interface
    {
        //campo
        public string nome;
        public long cpf;

        public Pessoa(string nome, long cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}
