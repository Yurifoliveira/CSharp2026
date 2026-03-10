using static System.Console;
using static System.Linq.Enumerable; //biblioteca para o uso da foreach
//dclvar
int n ;
//entrdads
Write ("Quantos numeros voce vai digitar ? : ");
n = int.Parse(ReadLine());
if ( n < 0 )
{
    WriteLine ("valor invalido , digite somente números positivos");
}
else if (n>10)
{
    WriteLine ( "Máximo de valores para digitar igual a 10");
    WriteLine (" tente novamente");
}
else
{
    //declaraçao vetor
    int [] numeros = new int [n];
    for (int i = 0 ;i < numeros.Length ; i++)
    {
        Write ($"Dígite o {i+1} numero : ");
        numeros [i] = int.Parse(ReadLine());
    }
        WriteLine ( " NUMEROS NEGATIVOS ");
        foreach ( int item in Range (0, numeros.Length))
    {
        if (numeros [item]<0)
        {
            WriteLine (numeros[item]);
        }
    }
}