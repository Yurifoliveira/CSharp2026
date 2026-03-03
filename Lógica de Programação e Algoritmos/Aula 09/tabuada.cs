using static System.Console;
//declaração de variavel
int numero;
//entrada de dados
numero = int.Parse(ReadLine());
//processamento de dados
for ( int i = 0 ; i < 10 ; i++) // (looping determinado)
{
    //------saida de dados-------
    WriteLine ($"{numero} x {i+1} = {numero * (i+1)}");
}
