using static System.Console;
using Master;
/*Console.WriteLine(Tipo.ContaNormal);
Console.WriteLine(Tipo.ContaPoupanca);
Console.WriteLine(Tipo.ContaPj);*/
Conta conta = new Conta(12345, 1500.56, new Pessoa("Clodoaldo", 12345));

var a = conta.ToString();
Console.WriteLine(a);

ContaPJ pj = new ContaPJ(54321, 50000, new Pessoa("Cesar", 51978100), 20000);
var b = pj.ToString();
Console.WriteLine(b);

ContaPoupanca pp = new ContaPoupanca(666666, 666.66, new Pessoa("Lu", 66666666), 5.0);
pp.Consulta();
Console.ReadKey();