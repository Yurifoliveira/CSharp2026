using Banco1;
using static System.Console;
Title = "Cadastro de conta:";
ContaBancaria conta;
//entrada de dados
Write("entre com o numero da conta");
int n = int.Parse(ReadLine());
Write("entre com o nome do titular da conta :");
string nome = ReadLine();//ReadLIne vazio para ler texto
Write("Deseja fazer um deposito inicial (s / n) :");
char resposta = char.Parse(ReadLine());
if (resposta == 's')
{
    Write("entre com o valor do deposito inicial : ");
    double dep = double.Parse(ReadLine());
    conta = new ContaBancaria(n, nome, dep); //criação de objt
}
else
{
    conta = new(n, nome);//criaçao de objt
}
conta.Dados();
ReadKey();
