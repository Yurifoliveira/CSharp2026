//problema baskara
//---declaração de variaveis ---
using static System.Console ; 
double a , b , c , delta ,  x1 , x2 ;
//----- entrada de dados---
WriteLine("Digite o valor de a: ");
a = double.Parse(ReadLine());
Write("Digite o valor de b: ");
b = double.Parse(ReadLine());
Write("Digite o valor de c: ");
c = double.Parse(ReadLine());
//----PROCESSAMEnTO DE DADOS---
delta = (b*b) - (4 * a * c );
// estrutura de controle
if (delta < 0)
{
    WriteLine("raizes impossiveis");
}
else if (delta == 0)
{
    x1 = -b/ (2*a);
    x2 = x1;
}
else
{
   x1 = (-b - Math.Sqrt(delta)) / ( 2 * a);
   x2 = (-b + Math.Sqrt(delta)) / ( 2 * a);
WriteLine($" x1 = {x1}\nx2 = {x2}");
}
