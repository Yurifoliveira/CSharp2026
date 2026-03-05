using static System.Console;
//decl var
int x , resultado ;
while (true)
{
    Write (" digite um numero inteiro ou zero para sair: ");
    x = int.Parse(ReadLine());
    if (x == 0 )
    {
        WriteLine("programa encerrado");
        break;
    }

    if ((x % 2) == 0)
    {
        //numero par
        //proc dados n1

       resultado = x + (x+2) + (x+4) + (x+6) + (x+8);
    }
    else
        {
    
            //NUMERO IMPAR
            x = x + 1;
            resultado =  x + (x+2) + (x+4) + (x+6) + (x+8);
        }
        WriteLine($"soma = {resultado}");
}
