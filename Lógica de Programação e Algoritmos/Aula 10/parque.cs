using static System.Console;
using System;

string direcao;
int turistas, totalTuristas = 0;

while (true)
{
    Clear();

    // Título em azul
    ForegroundColor = ConsoleColor.Blue;
    WriteLine("Aplicativo de controle de fluxo de carro");
    WriteLine("Parque nacional dos Lençóis Maranhenses");
    ResetColor();

    WriteLine();
    Write("Digite a direção (entrando, voltando ou sair): ");
    direcao = ReadLine()!.ToLower();

    if (direcao == "sair")
    {
        WriteLine("Expediente encerrado.");
        break;
    }

    if (direcao != "entrando" && direcao != "voltando")
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine("Direção inválida. Digite entrando, voltando ou sair.");
        ResetColor();
        ReadKey();
        continue;
    }

    Write("Digite a quantidade de turistas (0 a 4): ");
    
    if (!int.TryParse(ReadLine(), out turistas))
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine("Entrada inválida. Digite apenas números.");
        ResetColor();
        ReadKey();
        continue;
    }

    if (turistas < 0 || turistas > 4)
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine("Quantidade de turistas inválida. Digite um número entre 0 e 4.");
        ResetColor();
        ReadKey();
        continue;
    }

    // Captura data e hora atual
    DateTime agora = DateTime.Now;
    string dataHora = agora.ToString("dd/MM/yyyy HH:mm:ss");

    if (direcao == "entrando")
    {
        totalTuristas += turistas;

        ForegroundColor = ConsoleColor.Green;
        WriteLine($"+{turistas} turistas entrando.");
        WriteLine($"Data e Hora: {dataHora}");
        ResetColor();
    }
    else if (direcao == "voltando")
    {
        if (turistas > totalTuristas)
        {
            WriteLine("Não há turistas suficientes no parque.");
            turistas = totalTuristas;
        }

        totalTuristas -= turistas;

        ForegroundColor = ConsoleColor.Red;
        WriteLine($"-{turistas} turistas saindo.");
        WriteLine($"Data e Hora: {dataHora}");
        ResetColor();
    }

    ForegroundColor = ConsoleColor.Yellow;
    WriteLine($"Total de turistas no parque: {totalTuristas}");
    ResetColor();

    WriteLine("\nPressione qualquer tecla para continuar...");
    ReadKey();
}