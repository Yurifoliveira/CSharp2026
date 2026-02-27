//-- o usuario vai digitar um valor de 1 a 7 e esse codigo é pra mostrar o dia da semana correnpondente ao numero digitado pelo usuario 
using System.Reflection;
using static System.Console;
//declaração de variaveis 
int valor;
//entrada de dados
Write("digite um numero de 1 a 7 : ");
valor = int.Parse(Console.ReadLine());
if  (valor == 1)
{
WriteLine("domingo");
}
else if ( valor == 2)
{
    WriteLine("segunda");

}
else if ( valor == 3)
{
    WriteLine("terça-feira");

}
else if ( valor == 4)
{
    WriteLine("quarta-feira");

}
else if ( valor == 5)
{
    WriteLine("quinta-feira");

}
else if ( valor == 6)
{
    WriteLine("sexta-feira");

}
else if ( valor == 7)
{
    WriteLine("sabado");

}
else
{
    WriteLine("número fora do intervalo");
}