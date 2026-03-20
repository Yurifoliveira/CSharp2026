using App02;
using static System.Console;

WriteLine("Entre com os dados do funcionario : ");

Write("Digite o nome do funcionario : ");
f.Nome = (ReadLine());

Write("Digite o salário bruto do funcionario : ");
f.Salario_Bruto = double.Parse(ReadLine());

Write("Digite o valor total de imposto pago pelo funcionario : ");
f.Imposto = double.Parse(ReadLine());

Funcionario f = new Funcionario (Nome, Salario_bruto, Imposto);
WriteLine("Dados do Funcionario :");

Write($"Nome do funcionario : {f.Nome} ");

Write($"Salario Liquido :{f.Salario_liquido);
Write
Write("Dados do funcionario atualizados : ");
Write($"Nome do funcionario : {f.Nome}");
Write($"Salario Liquido : {f.Salario_liquido}");


