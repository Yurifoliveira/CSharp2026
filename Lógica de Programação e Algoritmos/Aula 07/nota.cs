using static System.Console;
//declaração de variaveis
double nota1 , nota2 , resultado ;
// entrada de dados
Write ("Digite a primeira nota :");
nota1 = double.Parse(ReadLine());
Write ("Digite a segunda nota :");
nota2 = double.Parse(ReadLine());
//processamento de dados
resultado = nota1 + nota2;
if (resultado < 60 )
{
    System.Console.WriteLine($"nota final = {resultado:F2}");
    WriteLine("reprovado");
}
else
{
    WriteLine($"nota final = {resultado:F2}");
    WriteLine("aprovado");
}
