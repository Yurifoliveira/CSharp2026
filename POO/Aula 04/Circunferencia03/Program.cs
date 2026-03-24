using Circunferencia03;
using static System.Console;
using static System.ConsoleColor;
using static Circunferencia03.Calculadora;

Title = " Calculadora 03 ";
Write("digite o raio da circunferencia :");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();
//saida de dados
WriteLine($"Circunferencia : {Circunferencia(raio):F2}");
WriteLine($"Volume : {Volume(raio):F2)}");
Write($"PI : {PI}");
