using App02;
using static System.Console;

WriteLine("Entre com os dados do funcionario:");

Write("Digite o nome do funcionario: ");
string nome = ReadLine();

Write("Digite o salário bruto do funcionario: ");
double salarioBruto = double.Parse(ReadLine());

Write("Digite o valor total de imposto pago pelo funcionario: ");
double imposto = double.Parse(ReadLine());

Funcionario f = new Funcionario(nome, salarioBruto, imposto);

WriteLine("\nDados do Funcionario:");
WriteLine($"Nome: {f.Nome}");
WriteLine($"Salario Liquido: {f.Salario_Liquido()}");

Write("\nDigite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(ReadLine());

// Aplicando aumento
f.AumentarSalario(porcentagem);

WriteLine("\nDados atualizados:");
WriteLine($"Nome: {f.Nome}");
WriteLine($"Salario Liquido: {f.Salario_Liquido()}");
ReadKey();