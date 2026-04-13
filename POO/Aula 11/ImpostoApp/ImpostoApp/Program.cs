using ImpostoApp.Services;
using System.Globalization;

// Garantir formatação decimal com vírgula (pt-BR)
Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine("╔══════════════════════════════════════════════════╗");
Console.WriteLine("║       SISTEMA DE CÁLCULO DE IMPOSTOS            ║");
Console.WriteLine("╚══════════════════════════════════════════════════╝");

int quantidade = 0;
while (quantidade <= 0)
{
    Console.Write("\nQuantidade de contribuintes (N): ");
    if (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
        Console.WriteLine("[Erro] Informe um número inteiro positivo.");
}

var contribuintes = ContribuinteService.LerContribuintes(quantidade);
ContribuinteService.ExibirRelatorio(contribuintes);

Console.WriteLine("\nPressione qualquer tecla para encerrar...");
Console.ReadKey();
