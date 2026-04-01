using BancoMaster;
using static System.Console;

WriteLine("Bem Vindo ao Banco Master");
WriteLine("Escolha o tipo de conta:");
WriteLine("1 - Conta Corrente");
WriteLine("2 - Conta Poupança");
WriteLine("3 - Conta Empresarial");

char resposta = char.Parse(ReadLine());

Write("Digite o nome do titular: ");
string titular = ReadLine();

Write("Digite o número da conta: ");
int numero = int.Parse(ReadLine());

Write("Deseja fazer depósito inicial? (s/n): ");
char respDep = char.Parse(ReadLine().ToLower());

double deposito = 0;
if (respDep == 's' || respDep == 'S')
{
    Write("Digite o valor do depósito: ");
    deposito = double.Parse(ReadLine());
}

Conta conta;

switch (resposta)
{
    case '1':
        WriteLine("\nConta Corrente criada!");
        conta = new Conta(titular, numero, deposito);
        break;

    case '2':
        WriteLine("\nConta Poupança criada!");
        conta = new ContaPoupanca(titular, numero, deposito);
        break;

    case '3':
        WriteLine("\nConta Empresarial criada!");

        Write("Digite o limite de empréstimo: ");
        double limite = double.Parse(ReadLine());

        conta = new ContaEmpresa(titular, numero, deposito, limite);
        break;

    default:
        WriteLine("Opção inválida!");
        return;
}

WriteLine("\nDados da conta:");
WriteLine(conta);
ReadKey();