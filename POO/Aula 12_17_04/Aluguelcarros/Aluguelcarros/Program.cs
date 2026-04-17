using Aluguelcarros.Entidades;
using Aluguelcarros.Servicos;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------\r\n   SERVIÇO DE ALUGUEL ILUMINI  \r\n-------------------------------\r\n        /\\\r\n       /  \\\r\n      /----\\\r\n     /      \\\r\n    /--------\\\r\n   /          \\\r\n  /------------\\");
        WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Entre com a data do aluguel");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Modelo do carro: ");
        Console.ResetColor();
        string modelo = Console.ReadLine()!;


        Console.Write("Retirada (dd/MM/yyyy hh:mm): ");
        DateTime inicio = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy HH:mm",
            System.Globalization.CultureInfo.InvariantCulture);

        Console.Write("Devolucao (dd/MM/yyyy hh:mm): ");
        DateTime fim = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy HH:mm",
            System.Globalization.CultureInfo.InvariantCulture);

        Console.Write("Entre com o preco por hora: ");
        double precoPorHora = double.Parse(Console.ReadLine()!,
            System.Globalization.CultureInfo.InvariantCulture);

        Console.Write("Entre com o preco por dia: ");
        double precoPorDia = double.Parse(Console.ReadLine()!,
            System.Globalization.CultureInfo.InvariantCulture);

        Veiculo veiculo = new Veiculo(modelo);
        AluguelCarro aluguel = new AluguelCarro(inicio, fim, veiculo);
        ServAluguel servAluguel = new ServAluguel(precoPorDia, precoPorHora);

        servAluguel.CalcularFatura(aluguel);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nFATURA:");
        Console.ResetColor();

        Console.WriteLine(aluguel.Fatura!.ToString());
    }
}