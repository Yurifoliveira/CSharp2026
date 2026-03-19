using terreno;
using static System.Console;

Write("digite a largura do terreno : ");
double Largura = double.Parse(Console.ReadLine());
Write("digite o comprimento do terreno :");
double Comprimento = double.Parse(Console.ReadLine());
Write("digite o valor do metro quadrado : ");
double Valor = double.Parse(Console.ReadLine());

Terreno t = new Terreno( Largura , Comprimento , Valor);

t.Saida();
ReadKey();