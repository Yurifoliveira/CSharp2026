using Microsoft.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace MasterBanco.Classes.Entidades
{
    internal class Banco
    {
        //campo

        private const decimal TaxaSaque = 5.00m;

        //propriedades
        public int Id { get; set; }

        public string Titular { get; set; }

        public int Numero_da_Conta { get; set; }

        public decimal Saldo { get; set; }

        //construtores
        public Banco() { }

        public Banco(string titular, int numero_da_Conta, decimal saldo)
        {
            Titular = titular;
            Numero_da_Conta = numero_da_Conta;
            Saldo = saldo;
        }

        public Banco(string titular, int numero_da_Conta)
        {
            Titular = titular;
            Numero_da_Conta = numero_da_Conta;
        }

        //caminho do servidor onde esta o banco de dados
        private static string conectatarCaminho = @"Server = ECFP507D1319375\SQLEXPRESS;Database = Clodoaldo;Trusted_Connection = True;TrustServerCertificate=True;";
        //OPERAÇÕES CRUD


        //("C") Creat
        public static void CadastrarContas(Banco banco)
        {
            //Query
            string consulta = "INSERT INTO Contas(Titular,Numero_da_conta,Saldo) VALUES (@Titular,@Numero_da_conta,@Saldo)";
            using (SqlConnection conexao = new SqlConnection(conectatarCaminho))
            using (SqlCommand comando = new SqlCommand(consulta, conexao))
            {
                comando.Parameters.AddWithValue("@Titular", banco.Titular);
                comando.Parameters.AddWithValue("@Numero_da_conta", banco.Numero_da_Conta);
                comando.Parameters.AddWithValue("@Saldo", banco.Saldo);

                conexao.Open();
                int resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    Console.WriteLine($"Conta cadastrada com sucesso!");
                }



            }

        }
        // ( R ) - READ
        public static void LerContas()
        {
            string consulta = "SELECT Id,Titular,Numero_da_conta,Saldo FROM Contas";
            using (SqlConnection conexao = new SqlConnection(conectatarCaminho))
            using (SqlCommand comando = new SqlCommand(consulta, conexao))
            {
                conexao.Open();
                using (SqlDataReader leitura = comando.ExecuteReader())
                {
                    if (leitura.HasRows)
                    {
                        while (leitura.Read())
                        {
                            Console.WriteLine($"Id:{leitura["Id"]}| " +
                                $"Conta:{leitura["Numero_da_Conta"]} |" +
                                $"Titular:{leitura["Titular"]}|" +
                                $"Saldo:R$ {leitura["Saldo"]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma conta encontrada");
                    }
                }
            }
        }




        //U - UPDATE
        public static void ModificarConta(int id, string titular, int numeroConta, decimal saldo)
        {
            string consulta = "UPDATE Contas SET Titular = @titular, Numero_da_Conta = @numeroConta, Saldo = @saldo WHERE Id = @id";
            using (SqlConnection conexao = new SqlConnection(conectatarCaminho))
            using (SqlCommand comando = new SqlCommand(consulta, conexao))
            {
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@titular", titular);
                comando.Parameters.AddWithValue("@numeroConta", numeroConta);
                comando.Parameters.AddWithValue("@saldo", saldo);
                conexao.Open();
                int resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    Console.WriteLine("cont Atualizada com sucesso");
                }
                else
                {
                    Console.WriteLine("Conta não encontrada!!!");
                }
            }
        }
        //D - DELETE
        public static void DeletarConta(int id)
        {
            string consulta = "DELETE FROM Contas WHERE Id = @id";
            using (SqlConnection conexao = new SqlConnection(conectatarCaminho))
            using (SqlCommand comando = new SqlCommand(consulta, conexao))
            {
                comando.Parameters.AddWithValue("@Id", id);
                conexao.Open();
                int resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    Console.WriteLine("conta deletada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Conta não encontrada!");
                }
            }
        }

    }
}




