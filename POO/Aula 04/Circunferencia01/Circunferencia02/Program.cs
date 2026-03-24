using Circunferencia02;
using static System.Console;
using static System.ConsoleColor;

//entrad
Write("Digite o raio da circunferencia :");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();
//criar o objeto do tipo calculadora
Calculadora c1 = new Calculadora(raio);
//saida de dados
WriteLine($"Circunferencia : {c1.Circunferencia():F2}");
WriteLine($"Volume : {c1.Volume():F2}");
WriteLine($"PI : {c1.PI}");
ReadKey();