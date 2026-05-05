using MasterBanco.Classes.Entidades;

namespace MasterBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Banco conta1 = new("Kewlvin", 1005, 1674.69m);
            Banco.CadastrarContas(conta1);*/
            
            Banco.LerContas();
            Banco.ModificarConta(2, "SENAI", 5000, 61.69m);
            Banco.LerContas();
            Banco.DeletarConta(4);
            Banco.LerContas();

        }
    }
}