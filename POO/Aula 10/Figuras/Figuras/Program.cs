using figuras.classe.Entidades;
using Figuras.Classes.Entidades;
using static System.Console;
using Figuras.Classes.Enumeracao;

List<Forma> formas = new();
Write("Digite a quantidade de formas :");
int qtd = int.Parse(ReadLine());
for (int i = 0; i < qtd; i++)
{
    WriteLine($"Dados do objeto geometrico n°{i + 1} :");
    Write($"Retângulo ou Circulo (R/C):");
    char escolha = char.Parse(ReadLine().ToLower());
    if (escolha == 'r')
    {
        WriteLine("Qual é a cor do objeto ? " + "\n\t1 - vermelho " + "\n\t 2 - Azul " + "\n\t 3 - Amarelo" + "\n\t 4 - Rosa");
        int cor = int.Parse(ReadLine());
    }
}