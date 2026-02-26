double resultado = 1 ;
//-----entrada de dados------
System.Console.WriteLine("digite um numerador para realizar a divisao : ");
double entrada = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite um denominador para realizar a divisao :");
double senai = double.Parse(Console.ReadLine());
//---processamento de dados--
if ( (entrada > 0) && (senai > 0) )
{
     resultado = 2 / entrada ;
}
else if (entrada == 0)
{
   resultado = 2 - entrada ;
}
else
{
    resultado = 2 + entrada;
}
//--saída de dados--
System.Console.WriteLine($" o resultado é {resultado}");
