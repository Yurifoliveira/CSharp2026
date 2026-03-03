using static System.Console;
//dec var
int numero , valor ;
try
{
    //entrad dados
    Write("quantos numeros voce vai digitar");
    numero= int.Parse(ReadLine());
    //processamento de dados
    for (int i = 0; i<numero; i ++)
    {
       Write("digite um numero ");
        valor = int.Parse(ReadLine());
        if (valor < 0 )
        {
            Write (" negativo");
        }
        else if ( valor > 0 )
        {
            Write("positivo");
        }
        else
        {
            Write ("nulo");
        }
        if ((valor % 2)== 0)
        {
            WriteLine("par");
        }
        else if ((valor % 2)!= 0)
        {
            WriteLine("impar");
        }
    }
}
catch (Exception ex)
{
    WriteLine("valor invalido , erro = ",ex.Message);
}