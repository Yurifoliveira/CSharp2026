using static System.Console;
using DepartamentoPessoal.Classes.Entidades;

List<Funcionario> colaboradores = new();
Write("quantos funcionarios ira cadastrar : ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    WriteLine($"Colaborador n {i + 1}");
    Write("O funcionario é terceirizado (S / N)  ? : ");
    char e = char.Parse(ReadLine().ToLower());
    if (e == 'n')
    {
        Write("Nome :");
        string nome = ReadLine();
        Write("Horas trabalhadas :");
        int h = int.Parse(ReadLine());
        Write("Valor da hora :");
        double v = double.Parse(ReadLine());
        colaboradores.Add(new Funcionario(nome, h, v)); //passsando o construtor
    }
    else
    {
        Write("Nome :");
        string nome = ReadLine();
        Write("Horas trabalhadas :");
        int h = int.Parse(ReadLine());
        Write("Valor da hora :");
        double v = double.Parse(ReadLine());
        Write("Despesa adicional : R$ ");
        double d = double.Parse(ReadLine());
        colaboradores.Add(new Terceiro(nome, h, v, d));
    }
}
    WriteLine("-PAGAMENTOS-");
    foreach (var colab in colaboradores)
    {
            WriteLine (colab.ToString());
    }
