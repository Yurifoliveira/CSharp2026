using Banco;
using static System.Console;
using static System.Globalization.CultureInfo;
  Title = " Abertura de conta ";
    ContaBancaria conta;
    Console.ForegroundColor = ConsoleColor.Green;
    WriteLine("Abertura de conta - Global investiment");
    Console.ResetColor();
    Write("Entre com um numero de conta : ");
    int numero = int.Parse(ReadLine());
    Write("entre com o nome do titular :");
    string nome = ReadLine();
    Write("Deseja fazer um depósito inicial ? s/n :");
    char resposta = char.Parse(ReadLine().ToLower());

    if (resposta == 's')
    {
        Write("Entre com o valor de deposito : R$");
        double deposito = double.Parse(ReadLine());
        conta = new ContaBancaria(numero, nome, deposito);//sempre na mesma ordem do construtor
    }
    else
    {
        conta = new ContaBancaria(numero, nome);
    }
    conta.dados();

    WriteLine("Entre com um valor para deposito : ");
    double quantia = double.Parse(ReadLine());
    conta.Deposito(quantia);
    conta.dados();

    WriteLine("Entre com um valor para saque: ");
    quantia = double.Parse(ReadLine());
    conta.Saque(quantia);
    conta.dados();

ReadKey();
