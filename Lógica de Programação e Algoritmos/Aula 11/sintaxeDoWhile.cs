using static System.Console;


int n = 0;
do
{
    Write(n);
    n ++;
    Task.Delay(1000).Wait(); //pausa de 1 seg para visualizar 

} while (n <  5);
WriteLine(" fim do programa ");
n = 0;
while ( n < 5 )
{
     Write(n);
    n ++;
    Task.Delay(1000).Wait(); //pausa de 1 seg para visualizar 
}
WriteLine(" fim do programa 2 ");