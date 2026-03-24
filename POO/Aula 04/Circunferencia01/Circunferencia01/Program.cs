using static System.Console;
using static System.ConsoleColor;
Title = "Calculadora 01";
//dclrvar
double raio;
const double PI = 3.14;
//entrada de dados
Write("Entre com o valor do raio da circunferencia : ");
ForegroundColor = Red;
raio = double.Parse(ReadLine());
ResetColor();
//saida de dados 
WriteLine($"Circunferencia : {Circunferencia(raio):F2}");
WriteLine($"Volume : {Volume(raio):F2}");
WriteLine($"PI : {PI}");

//calc circunferencia
double Circunferencia (double raio)
{
    return 2 * PI * raio;
}
double Volume(double r )
{
    return ((4 / 3) * PI * r * r * r);
        
        }
